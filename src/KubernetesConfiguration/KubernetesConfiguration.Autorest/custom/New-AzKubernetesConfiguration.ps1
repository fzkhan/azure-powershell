
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
Create a new Kubernetes Source Control Configuration.
.Description
Create a new Kubernetes Source Control Configuration.
.Example
New-AzConnectedKubernetes -ClusterName azpstest_cluster_arc -ResourceGroupName azps_test_group -Location eastus -KubeConfig $HOME\.kube\config -KubeContext azps_aks_t01
New-AzKubernetesConfiguration -ResourceGroupName azps_test_group -ClusterName azpstest_cluster_arc -Name azpstestk8s -RepositoryUrl http://github.com/xxxx -ClusterType ConnectedClusters
.Example
New-AzConnectedKubernetes -ClusterName azpstest_cluster_arc -ResourceGroupName azps_test_group -Location eastus -KubeConfig $HOME\.kube\config -KubeContext azps_aks_t01
New-AzKubernetesConfiguration -ResourceGroupName azps_test_group -ClusterName azpstest_cluster_arc -Name azpstestk8s-operator -RepositoryUrl http://github.com/xxxx -OperatorScope 'cluster' -ClusterType ConnectedClusters

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.ISourceControlConfiguration
.Link
https://learn.microsoft.com/powershell/module/az.kubernetesconfiguration/new-azkubernetesconfiguration
#>
function New-AzKubernetesConfiguration {
    [Alias('New-AzK8sConfiguration')]
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.ISourceControlConfiguration])]
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
        [Alias('SourceControlConfigurationName')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Path')]
        [System.String]
        # Name of the Source Control Configuration.
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
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Info(PossibleTypes = ([Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.IConfigurationProtectedSettings]))]
        [System.Collections.Hashtable]
        # Name-value pairs of protected configuration settings for the configuration
        ${ConfigurationProtectedSetting},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Option to enable Helm Operator for this git configuration.
        ${EnableHelmOperator},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Values override for the operator Helm chart.
        ${HelmOperatorChartValue},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Version of the operator Helm chart.
        ${HelmOperatorChartVersion},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Instance name of the operator - identifying the specific configuration.
        ${OperatorInstanceName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # The namespace to which this operator is installed to.
        # Maximum of 253 lower case alphanumeric characters, hyphen and period only.
        ${OperatorNamespace},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Any Parameters for the Operator instance in string format.
        ${OperatorParam},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PSArgumentCompleterAttribute("cluster", "namespace")]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Scope at which the operator will be installed.
        ${OperatorScope},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.PSArgumentCompleterAttribute("Flux")]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Type of the operator
        ${OperatorType},

        [Parameter(HelpMessage="If passed set the scope of the Configuration to Cluster (default is nameSpace).")]
        [switch]
        ${ClusterScoped},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Url of the SourceControl Repository.
        ${RepositoryUrl},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Body')]
        [System.String]
        # Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
        ${SshKnownHost},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

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
            if ($PSBoundParameters.ContainsKey('ClusterScoped')) {
                $PSBoundParameters.OperatorScope = 'Cluster'
            }
            else {
                $PSBoundParameters.OperatorScope = 'Namespace'
            }
            
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
        
            $PSBoundParameters.Add('OperatorType', 'Flux')
        
            write-host "Azure Kubernetes Configuration is being created, need to wait a few minutes..."
            Az.KubernetesConfiguration.internal\New-AzKubernetesConfiguration @PSBoundParameters
        }
        catch {
            throw
        }
    }
}