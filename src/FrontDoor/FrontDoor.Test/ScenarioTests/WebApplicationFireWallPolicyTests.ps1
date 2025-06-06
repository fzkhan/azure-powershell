﻿# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.SYNOPSIS
Full WAF policy CRUD cycle
#>
function Test-PolicyCrud
{
    $Name = getAssetName
    $resourceGroup = TestSetup-CreateResourceGroup
    $resourceGroupName = $resourceGroup.ResourceGroupName
    $tags = @{"tag1" = "value1"; "tag2" = "value2"}
    $matchCondition1 = New-AzFrontDoorWafMatchConditionObject -MatchVariable RequestHeader -OperatorProperty Contains -Selector "UserAgent" -MatchValue "WINDOWS" -Transform "Uppercase"
    $customRule1 = New-AzFrontDoorWafCustomRuleObject -Name "Rule1" -RuleType MatchRule -MatchCondition $matchCondition1 -Action Block -Priority 2

    # Create exclusion objects
    $exclusionRule = New-AzFrontDoorWafManagedRuleExclusionObject -Variable QueryStringArgNames -Operator Equals -Selector "ExcludeInRule"
    $exclusionGroup = New-AzFrontDoorWafManagedRuleExclusionObject -Variable QueryStringArgNames -Operator Equals -Selector "ExcludeInGroup"
    $exclusionSet = New-AzFrontDoorWafManagedRuleExclusionObject -Variable QueryStringArgNames -Operator Equals -Selector "ExcludeInSet"

    $ruleOverride = New-AzFrontDoorWafManagedRuleOverrideObject -RuleId "942100" -Action Log -Exclusion $exclusionRule
    $override1 = New-AzFrontDoorWafRuleGroupOverrideObject -RuleGroupName SQLI -ManagedRuleOverride $ruleOverride -Exclusion $exclusionGroup
    $managedRule1 = New-AzFrontDoorWafManagedRuleObject -Type DefaultRuleSet -Version "1.0" -RuleGroupOverride $override1 -Exclusion $exclusionSet
    $managedRule2 = New-AzFrontDoorWafManagedRuleObject -Type BotProtection -Version "preview-0.1"

    $LogScrubbingRule = New-AzFrontDoorWafLogScrubbingRuleObject -MatchVariable "RequestHeaderNames" -SelectorMatchOperator "EqualsAny" -State "Enabled"
    $logscrubbingSetting = New-AzFrontDoorWafLogScrubbingSettingObject -State Enabled -ScrubbingRule @($LogScrubbingRule)

    New-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -CaptchaExpirationInMinutes 5 -Sku Premium_AzureFrontDoor -Customrule $customRule1 -ManagedRule $managedRule1,$managedRule2 -EnabledState Enabled -Mode Prevention -RequestBodyCheck Disabled -LogScrubbingSetting $logscrubbingSetting -JavascriptChallengeExpirationInMinutes 30  
	
    $retrievedPolicy = Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName 
    Assert-NotNull $retrievedPolicy
    Assert-AreEqual $Name $retrievedPolicy.Name
    Assert-AreEqual "Disabled" $retrievedPolicy.RequestBodyCheck
    Assert-AreEqual $customRule1.Name $retrievedPolicy.CustomRules[0].Name
    Assert-AreEqual $customRule1.RuleType $retrievedPolicy.CustomRules[0].RuleType
    Assert-AreEqual $customRule1.Action $retrievedPolicy.CustomRules[0].Action
    Assert-AreEqual $customRule1.Priority $retrievedPolicy.CustomRules[0].Priority
    Assert-AreEqual $matchCondition1.MatchVariable $retrievedPolicy.CustomRules[0].MatchConditions[0].MatchVariable
    Assert-AreEqual $matchCondition1.Selector $retrievedPolicy.CustomRules[0].MatchConditions[0].Selector
    Assert-AreEqual $matchCondition1.OperatorProperty $retrievedPolicy.CustomRules[0].MatchConditions[0].OperatorProperty
    Assert-AreEqual $matchCondition1.MatchValue[0] $retrievedPolicy.CustomRules[0].MatchConditions[0].MatchValue[0]
    Assert-AreEqual $matchCondition1.Transform[0] $retrievedPolicy.CustomRules[0].MatchConditions[0].Transform[0]
    Assert-AreEqual $managedRule1.Exclusions[0].Selector $retrievedPolicy.ManagedRules[0].Exclusions[0].Selector
    Assert-AreEqual $managedRule1.RuleGroupOverrides[0].ManagedRuleOverrides[0].Action $retrievedPolicy.ManagedRules[0].RuleGroupOverrides[0].ManagedRuleOverrides[0].Action
    Assert-AreEqual $managedRule1.RuleGroupOverrides[0].Exclusions[0].Selector $retrievedPolicy.ManagedRules[0].RuleGroupOverrides[0].Exclusions[0].Selector
    Assert-AreEqual $managedRule1.RuleGroupOverrides[0].ManagedRuleOverrides[0].Exclusions[0].Selector $retrievedPolicy.ManagedRules[0].RuleGroupOverrides[0].ManagedRuleOverrides[0].Exclusions[0].Selector
    Assert-AreEqual $managedRule1.RuleSetType $retrievedPolicy.ManagedRules[0].RuleSetType
    Assert-AreEqual $managedRule1.RuleSetVersion $retrievedPolicy.ManagedRules[0].RuleSetVersion
    Assert-AreEqual $managedRule2.RuleSetType $retrievedPolicy.ManagedRules[1].RuleSetType
    Assert-AreEqual $managedRule2.RuleSetVersion $retrievedPolicy.ManagedRules[1].RuleSetVersion
    Assert-AreEqual "Enabled" $retrievedPolicy.LogScrubbing.State
    Assert-AreEqual $logscrubbingSetting.ScrubbingRule[0].MatchVariable $retrievedPolicy.LogScrubbing.ScrubbingRule[0].MatchVariable
    Assert-AreEqual 30 $retrievedPolicy.JavascriptChallengeExpirationInMinutes
    Assert-AreEqual 5 $retrievedPolicy.CaptchaExpirationInMinutes
    
    $customRule2 = New-AzFrontDoorWafCustomRuleObject -Name "Rule2" -RuleType MatchRule -MatchCondition $matchCondition1 -Action Log -Priority 2
    $updatedPolicy = Update-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -Customrule $customRule2 -LogScrubbingSetting @{}
    Assert-NotNull $updatedPolicy
    Assert-AreEqual $Name $updatedPolicy.Name
    Assert-AreEqual $customRule2.Name $updatedPolicy.CustomRules[0].Name
    Assert-AreEqual $customRule2.Action $updatedPolicy.CustomRules[0].Action
    Assert-AreEqual $customRule2.Priority $updatedPolicy.CustomRules[0].Priority
    Assert-AreEqual $managedRule1.RuleGroupOverrides[0].ManagedRuleOverrides[0].Action $updatedPolicy.ManagedRules[0].RuleGroupOverrides[0].ManagedRuleOverrides[0].Action
    Assert-Null $updatedPolicy.LogScrubbing

    $customRule3 = New-AzFrontDoorWafCustomRuleObject -Name "Rule3" -RuleType MatchRule -MatchCondition $matchCondition1 -Action Log -Priority 3 -EnabledState Disabled
    $updatedPolicy = Update-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -Customrule $customRule3
    Assert-NotNull $updatedPolicy
    Assert-AreEqual $Name $updatedPolicy.Name
    Assert-AreEqual $customRule3.Name $updatedPolicy.CustomRules[0].Name
    Assert-AreEqual $customRule3.Action $updatedPolicy.CustomRules[0].Action
    Assert-AreEqual $customRule3.Priority $updatedPolicy.CustomRules[0].Priority
    Assert-AreEqual $customRule3.EnabledState $updatedPolicy.CustomRules[0].EnabledState
    Assert-AreEqual $managedRule1.RuleGroupOverrides[0].ManagedRuleOverrides[0].Action $updatedPolicy.ManagedRules[0].RuleGroupOverrides[0].ManagedRuleOverrides[0].Action

    $removed = Remove-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -PassThru
    Assert-True { $removed }
    Assert-ThrowsContains { Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName } "does not exist."
}

<#
.SYNOPSIS
WAF policy cycle with piping
#>
function Test-PolicyCrudWithPiping
{
    $Name = getAssetName
    $resourceGroup = TestSetup-CreateResourceGroup
    $resourceGroupName = $resourceGroup.ResourceGroupName
    $tag = @{"tag1" = "value1"; "tag2" = "value2"}
    $matchCondition1 = New-AzFrontDoorWafMatchConditionObject -MatchVariable RequestHeader -OperatorProperty Contains -Selector "UserAgent" -MatchValue "WINDOWS" -Transform "Uppercase"
    $customRule1 = New-AzFrontDoorWafCustomRuleObject -Name "Rule1" -RuleType MatchRule -MatchCondition $matchCondition1 -Action Block -Priority 2

    $ruleOverride = New-AzFrontDoorWafManagedRuleOverrideObject -RuleId "942100" -Action Log
    $override1 = New-AzFrontDoorWafRuleGroupOverrideObject -RuleGroupName SQLI -ManagedRuleOverride $ruleOverride
    $managedRule1 = New-AzFrontDoorWafManagedRuleObject -Type DefaultRuleSet -Version "1.0" -RuleGroupOverride $override1
    $managedRule2 = New-AzFrontDoorWafManagedRuleObject -Type BotProtection -Version "preview-0.1"

    New-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -Customrule $customRule1 -ManagedRule $managedRule1,$managedRule2 -EnabledState Enabled -Mode Prevention -RequestBodyCheck Disabled

    $customRule2 = New-AzFrontDoorWafCustomRuleObject -Name "Rule2" -RuleType MatchRule -MatchCondition $matchCondition1 -Action Log -Priority 2
    $updatedPolicy = Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName | Update-AzFrontDoorWafPolicy -Customrule $customRule2
    Assert-NotNull $updatedPolicy
    Assert-AreEqual $Name $updatedPolicy.Name
    Assert-AreEqual "Disabled" $updatedPolicy.RequestBodyCheck
    Assert-AreEqual $customRule2.Name $updatedPolicy.CustomRules[0].Name
    Assert-AreEqual $customRule2.Action $updatedPolicy.CustomRules[0].Action
    Assert-AreEqual $customRule2.Priority $updatedPolicy.CustomRules[0].Priority
    Assert-AreEqual $managedRule1.RuleGroupOverrides[0].ManagedRuleOverrides[0].Action $updatedPolicy.ManagedRules[0].RuleGroupOverrides[0].ManagedRuleOverrides[0].Action

    $removed = Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName | Remove-AzFrontDoorWafPolicy -PassThru
    Assert-True { $removed }
    Assert-ThrowsContains { Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName } "does not exist."
}

<#
.SYNOPSIS
WAF managed rule set definitions retrieval
#>
function Test-ManagedRuleSetDefinition
{
    $definitions = Get-AzFrontDoorWafManagedRuleSetDefinition
}

<#
.SYNOPSIS
Policy Action test
#>
function Test-PolicyAction
{
    $Name = getAssetName
    $resourceGroup = TestSetup-CreateResourceGroup
    $resourceGroupName = $resourceGroup.ResourceGroupName
    $managedSet = New-AzFrontDoorWafManagedRuleObject -Type Microsoft_DefaultRuleSet -Version 2.0 -RuleGroupOverride $ruleGroupOverride -Action Block # Should use v2.0 but it's not enabled for all subscriptions
    New-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -ManagedRule $managedSet -EnabledState Enabled -Mode Prevention -Sku Premium_AzureFrontDoor
    $retrievedPolicy = Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName

    Assert-NotNull $retrievedPolicy
    Assert-AreEqual $Name $retrievedPolicy.Name
    Assert-AreEqual "Enabled" $retrievedPolicy.RequestBodyCheck
    Assert-AreEqual "Block" $retrievedPolicy.ManagedRules[0].RuleSetAction

    $removed = Remove-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -PassThru
    Assert-True { $removed }
    Assert-ThrowsContains { Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName } "does not exist."
}

function Test-CustomBlockResponseBody
{
    $Name = getAssetName
    $resourceGroup = TestSetup-CreateResourceGroup
    $resourceGroupName = $resourceGroup.ResourceGroupName
    $tags = @{"tag1" = "value1"; "tag2" = "value2"}
    $matchCondition1 = New-AzFrontDoorWafMatchConditionObject -MatchVariable RequestHeader -OperatorProperty Contains -Selector "UserAgent" -MatchValue "WINDOWS" -Transform "Uppercase"
    $customRule1 = New-AzFrontDoorWafCustomRuleObject -Name "Rule1" -RuleType MatchRule -MatchCondition $matchCondition1 -Action Block -Priority 2

    # Create exclusion objects
    $exclusionRule = New-AzFrontDoorWafManagedRuleExclusionObject -Variable QueryStringArgNames -Operator Equals -Selector "ExcludeInRule"
    $exclusionGroup = New-AzFrontDoorWafManagedRuleExclusionObject -Variable QueryStringArgNames -Operator Equals -Selector "ExcludeInGroup"
    $exclusionSet = New-AzFrontDoorWafManagedRuleExclusionObject -Variable QueryStringArgNames -Operator Equals -Selector "ExcludeInSet"

    $ruleOverride = New-AzFrontDoorWafManagedRuleOverrideObject -RuleId "942100" -Action Log -Exclusion $exclusionRule
    $override1 = New-AzFrontDoorWafRuleGroupOverrideObject -RuleGroupName SQLI -ManagedRuleOverride $ruleOverride -Exclusion $exclusionGroup
    $managedRule1 = New-AzFrontDoorWafManagedRuleObject -Type DefaultRuleSet -Version "1.0" -RuleGroupOverride $override1 -Exclusion $exclusionSet
    $managedRule2 = New-AzFrontDoorWafManagedRuleObject -Type BotProtection -Version "preview-0.1"

    New-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName -Sku Premium_AzureFrontDoor -Customrule $customRule1 -ManagedRule $managedRule1,$managedRule2 -EnabledState Enabled -Mode Prevention -RequestBodyCheck Disabled -CustomBlockResponseBody "<html><head><title>WAF Demo1</title></head><bodybgcolor=`"#FFB29Z`"><p><h1><strong>WAF Custom Response Page</strong></h1></p><p>Please contact us with the below reference ID: {{azure-ref}}<br></p></body></html>"

    $afdWafPolicy = Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName
    Assert-AreEqual $afdWafPolicy.CustomBlockResponseBody "<html><head><title>WAF Demo1</title></head><bodybgcolor=`"#FFB29Z`"><p><h1><strong>WAF Custom Response Page</strong></h1></p><p>Please contact us with the below reference ID: {{azure-ref}}<br></p></body></html>"

    $afdWafPolicy.CustomBlockResponseBody = "<html><head><title>WAF Demo2</title></head><bodybgcolor=`"#FFB29Z`"><p><h1><strong>WAF Custom Response Page</strong></h1></p><p>Please contact us with the below reference ID: {{azure-ref}}<br></p></body></html>"
    $afdWafPolicy | Update-AzFrontDoorWafPolicy

    $retrievedPolicy = Get-AzFrontDoorWafPolicy -Name $Name -ResourceGroupName $resourceGroupName

    Assert-AreEqual $retrievedPolicy.CustomBlockResponseBody "<html><head><title>WAF Demo2</title></head><bodybgcolor=`"#FFB29Z`"><p><h1><strong>WAF Custom Response Page</strong></h1></p><p>Please contact us with the below reference ID: {{azure-ref}}<br></p></body></html>"
}