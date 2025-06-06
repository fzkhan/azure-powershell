// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>The list of OS option properties.</summary>
    public partial class OSOptionPropertyList :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOSOptionPropertyList,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOSOptionPropertyListInternal
    {

        /// <summary>Backing field for <see cref="OSOptionPropertyList1" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOSOptionProperty> _oSOptionPropertyList1;

        /// <summary>The list of OS options.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOSOptionProperty> OSOptionPropertyList1 { get => this._oSOptionPropertyList1; set => this._oSOptionPropertyList1 = value; }

        /// <summary>Creates an new <see cref="OSOptionPropertyList" /> instance.</summary>
        public OSOptionPropertyList()
        {

        }
    }
    /// The list of OS option properties.
    public partial interface IOSOptionPropertyList :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>The list of OS options.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of OS options.",
        SerializedName = @"osOptionPropertyList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOSOptionProperty) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOSOptionProperty> OSOptionPropertyList1 { get; set; }

    }
    /// The list of OS option properties.
    internal partial interface IOSOptionPropertyListInternal

    {
        /// <summary>The list of OS options.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IOSOptionProperty> OSOptionPropertyList1 { get; set; }

    }
}