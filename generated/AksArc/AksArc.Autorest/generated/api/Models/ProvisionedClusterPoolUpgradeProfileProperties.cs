// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Extensions;

    /// <summary>The upgrade properties.</summary>
    public partial class ProvisionedClusterPoolUpgradeProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedClusterPoolUpgradeProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedClusterPoolUpgradeProfilePropertiesInternal
    {

        /// <summary>Backing field for <see cref="IsPreview" /> property.</summary>
        private bool? _isPreview;

        /// <summary>Whether the Kubernetes version is currently in preview.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public bool? IsPreview { get => this._isPreview; }

        /// <summary>Backing field for <see cref="KubernetesVersion" /> property.</summary>
        private string _kubernetesVersion;

        /// <summary>The Kubernetes version (major.minor.patch).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string KubernetesVersion { get => this._kubernetesVersion; }

        /// <summary>Internal Acessors for IsPreview</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedClusterPoolUpgradeProfilePropertiesInternal.IsPreview { get => this._isPreview; set { {_isPreview = value;} } }

        /// <summary>Internal Acessors for KubernetesVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedClusterPoolUpgradeProfilePropertiesInternal.KubernetesVersion { get => this._kubernetesVersion; set { {_kubernetesVersion = value;} } }

        /// <summary>
        /// Creates an new <see cref="ProvisionedClusterPoolUpgradeProfileProperties" /> instance.
        /// </summary>
        public ProvisionedClusterPoolUpgradeProfileProperties()
        {

        }
    }
    /// The upgrade properties.
    public partial interface IProvisionedClusterPoolUpgradeProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IJsonSerializable
    {
        /// <summary>Whether the Kubernetes version is currently in preview.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether the Kubernetes version is currently in preview.",
        SerializedName = @"isPreview",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPreview { get;  }
        /// <summary>The Kubernetes version (major.minor.patch).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Kubernetes version (major.minor.patch).",
        SerializedName = @"kubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KubernetesVersion { get;  }

    }
    /// The upgrade properties.
    internal partial interface IProvisionedClusterPoolUpgradeProfilePropertiesInternal

    {
        /// <summary>Whether the Kubernetes version is currently in preview.</summary>
        bool? IsPreview { get; set; }
        /// <summary>The Kubernetes version (major.minor.patch).</summary>
        string KubernetesVersion { get; set; }

    }
}