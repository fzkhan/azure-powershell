// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Extensions;

    /// <summary>Health Monitor Description</summary>
    public partial class HealthMonitor :
        Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IHealthMonitor,
        Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IHealthMonitorInternal
    {

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private string _detail;

        /// <summary>Health Monitor Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string Detail { get => this._detail; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Health Monitor Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Detail</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IHealthMonitorInternal.Detail { get => this._detail; set { {_detail = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IHealthMonitorInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IHealthMonitorInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Health Monitor Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="HealthMonitor" /> instance.</summary>
        public HealthMonitor()
        {

        }
    }
    /// Health Monitor Description
    public partial interface IHealthMonitor :
        Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.IJsonSerializable
    {
        /// <summary>Health Monitor Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Health Monitor Details",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(string) })]
        string Detail { get;  }
        /// <summary>Health Monitor Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Health Monitor Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Health Monitor Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Health Monitor Name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Health Monitor Description
    internal partial interface IHealthMonitorInternal

    {
        /// <summary>Health Monitor Details</summary>
        string Detail { get; set; }
        /// <summary>Health Monitor Id</summary>
        string Id { get; set; }
        /// <summary>Health Monitor Name</summary>
        string Name { get; set; }

    }
}