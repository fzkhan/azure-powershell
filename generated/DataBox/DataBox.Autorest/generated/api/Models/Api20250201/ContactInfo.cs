// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Contact Info.</summary>
    public partial class ContactInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IContactInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IContactInfoInternal
    {

        /// <summary>Backing field for <see cref="ContactName" /> property.</summary>
        private string _contactName;

        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ContactName { get => this._contactName; set => this._contactName = value; }

        /// <summary>Backing field for <see cref="Mobile" /> property.</summary>
        private string _mobile;

        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Mobile { get => this._mobile; set => this._mobile = value; }

        /// <summary>Backing field for <see cref="Phone" /> property.</summary>
        private string _phone;

        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Phone { get => this._phone; set => this._phone = value; }

        /// <summary>Backing field for <see cref="PhoneExtension" /> property.</summary>
        private string _phoneExtension;

        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string PhoneExtension { get => this._phoneExtension; set => this._phoneExtension = value; }

        /// <summary>Creates an new <see cref="ContactInfo" /> instance.</summary>
        public ContactInfo()
        {

        }
    }
    /// Contact Info.
    public partial interface IContactInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Contact name of the person.",
        SerializedName = @"contactName",
        PossibleTypes = new [] { typeof(string) })]
        string ContactName { get; set; }
        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mobile number of the contact person.",
        SerializedName = @"mobile",
        PossibleTypes = new [] { typeof(string) })]
        string Mobile { get; set; }
        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Phone number of the contact person.",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string Phone { get; set; }
        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Phone extension number of the contact person.",
        SerializedName = @"phoneExtension",
        PossibleTypes = new [] { typeof(string) })]
        string PhoneExtension { get; set; }

    }
    /// Contact Info.
    internal partial interface IContactInfoInternal

    {
        /// <summary>Contact name of the person.</summary>
        string ContactName { get; set; }
        /// <summary>Mobile number of the contact person.</summary>
        string Mobile { get; set; }
        /// <summary>Phone number of the contact person.</summary>
        string Phone { get; set; }
        /// <summary>Phone extension number of the contact person.</summary>
        string PhoneExtension { get; set; }

    }
}