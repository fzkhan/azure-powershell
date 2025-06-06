// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>The profile of managed cluster add-on.</summary>
    public partial class ManagedClusterPropertiesAddonProfiles :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPropertiesAddonProfiles,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterPropertiesAddonProfilesInternal
    {

        /// <summary>Creates an new <see cref="ManagedClusterPropertiesAddonProfiles" /> instance.</summary>
        public ManagedClusterPropertiesAddonProfiles()
        {

        }
    }
    /// The profile of managed cluster add-on.
    public partial interface IManagedClusterPropertiesAddonProfiles :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAddonProfile>
    {

    }
    /// The profile of managed cluster add-on.
    internal partial interface IManagedClusterPropertiesAddonProfilesInternal

    {

    }
}