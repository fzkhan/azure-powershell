// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Reference to a data network resource.</summary>
    public partial class DataNetworkResourceId :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IDataNetworkResourceId,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IDataNetworkResourceIdInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Data network resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="DataNetworkResourceId" /> instance.</summary>
        public DataNetworkResourceId()
        {

        }
    }
    /// Reference to a data network resource.
    public partial interface IDataNetworkResourceId :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>Data network resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data network resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Reference to a data network resource.
    internal partial interface IDataNetworkResourceIdInternal

    {
        /// <summary>Data network resource ID.</summary>
        string Id { get; set; }

    }
}