
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a new Kubernetes Cluster Extension.
.Description
Create a new Kubernetes Cluster Extension.
.Example
New-AzKubernetesExtension -ClusterName azpstest_cluster_arc -ClusterType ConnectedClusters -Name azpstest-extension -ResourceGroupName azps_test_group -ExtensionType azuremonitor-containers
.Example
New-AzKubernetesExtension -ClusterName azpstest_cluster_arc -ClusterType ConnectedClusters -Name flux -ResourceGroupName azps_test_group -ExtensionType microsoft.flux -AutoUpgradeMinorVersion -ReleaseNamespace flux-system -EnableSystemAssignedIdentity

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IExtension
.Link
https://learn.microsoft.com/powershell/module/az.kubernetesconfiguration/new-azkubernetesextension
#>
function New-AzKubernetesExtension {
    [Alias('New-AzK8sExtension')]
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IExtension])]
    [CmdletBinding(DefaultParameterSetName = 'CreateExpanded', PositionalBinding = $false, SupportsShouldProcess, ConfirmImpact = 'Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The name of the kubernetes cluster.
        ${ClusterName},

        [Parameter(Mandatory)]
        [ArgumentCompleter({ 'ManagedClusters', 'ConnectedClusters', 'ProvisionedClusters' })]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The Kubernetes cluster resource name - i.e.
        # managedClusters, connectedClusters, provisionedClusters.
        ${ClusterType},

        [Parameter(Mandatory)]
        [Alias('ExtensionName')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # Name of the Extension.
        ${Name},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.DefaultInfo(Script = '(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The identity type.
        ${AkAssignedIdentityType},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Flag to note if this extension participates in auto upgrade of minor version, or not.
        ${AutoUpgradeMinorVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Namespace where the extension Release must be placed, for a Cluster scoped extension.
        # If this namespace does not exist, it will be created
        ${ReleaseNamespace},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(PossibleTypes = ([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IExtensionPropertiesConfigurationProtectedSettings]))]
        [System.Collections.Hashtable]
        # Configuration settings that are sensitive, as name-value pairs for configuring this extension.
        ${ConfigurationProtectedSetting},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(PossibleTypes = ([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IExtensionPropertiesConfigurationSettings]))]
        [System.Collections.Hashtable]
        # Configuration settings, as name-value pairs for configuring this extension.
        ${ConfigurationSetting},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Determines whether to enable a system-assigned identity for the resource.
        ${EnableSystemAssignedIdentity},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Type of the Extension, of which this resource is an instance of.
        # It must be one of the Extension Types registered with Microsoft.KubernetesConfiguration by the Extension publisher.
        ${ExtensionType},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Namespace where the extension will be created for an Namespace scoped extension.
        # If this namespace does not exist, it will be created
        ${TargetNamespace},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # A user defined name of the 3rd Party Artifact that is being procured.
        ${PlanName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The 3rd Party artifact that is being procured.
        # E.g.
        # NewRelic.
        # Product maps to the OfferID specified for the artifact at the time of Data Market onboarding.
        ${PlanProduct},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # A publisher provided promotion code as provisioned in Data Market for the said product/artifact.
        ${PlanPromotionCode},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The publisher of the 3rd Party Artifact that is being bought.
        # E.g.
        # NewRelic
        ${PlanPublisher},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The version of the desired product/artifact.
        ${PlanVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # ReleaseTrain this extension participates in for auto-upgrade (e.g.
        # Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.
        ${ReleaseTrain},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # User-specified version of the extension for this extension to 'pin'.
        # To use 'version', autoUpgradeMinorVersion must be 'false'.
        ${Version},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command asynchronously
        ${NoWait},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        try {
            if ($ClusterType -eq 'ManagedClusters') {
                $PSBoundParameters.Add('ClusterRp', 'Microsoft.ContainerService')
            }
            elseif ($ClusterType -eq 'ConnectedClusters') {
                $PSBoundParameters.Add('ClusterRp', 'Microsoft.Kubernetes')
            }
            elseif ($ClusterType -eq 'ProvisionedClusters') {
                $PSBoundParameters.Add('ClusterRp', 'Microsoft.HybridContainerService')
            }
            else {
                Write-Error "Please select ClusterType from the following three values: 'ManagedClusters', 'ConnectedClusters', 'ProvisionedClusters'"
            }

            write-host "Azure Kubernetes Configuration Extension is being created, need to wait a few minutes..."
            Az.KubernetesConfiguration.internal\New-AzKubernetesExtension @PSBoundParameters
        }
        catch {
            throw
        }
    }
}