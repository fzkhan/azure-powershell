// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>SIM name and encrypted properties.</summary>
    public partial class SimNameAndEncryptedProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal
    {

        /// <summary>
        /// An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video
        /// camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string DeviceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).DeviceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).DeviceType = value ?? null; }

        /// <summary>The encrypted SIM credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string EncryptedCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormatInternal)Property).EncryptedCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormatInternal)Property).EncryptedCredentials = value ?? null; }

        /// <summary>The integrated circuit card ID (ICCID) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string IntegratedCircuitCardIdentifier { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).IntegratedCircuitCardIdentifier; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).IntegratedCircuitCardIdentifier = value ?? null; }

        /// <summary>The international mobile subscriber identity (IMSI) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string InternationalMobileSubscriberIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).InternationalMobileSubscriberIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).InternationalMobileSubscriberIdentity = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.EncryptedSimPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for SimPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimPolicyResourceId Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal.SimPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SimPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SimPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SimState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal.SimState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SimState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SimState = value ?? null; }

        /// <summary>Internal Acessors for SiteProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteProvisioning Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal.SiteProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SiteProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SiteProvisioningState = value ?? null /* model class */; }

        /// <summary>Internal Acessors for VendorKeyFingerprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal.VendorKeyFingerprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).VendorKeyFingerprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).VendorKeyFingerprint = value ?? null; }

        /// <summary>Internal Acessors for VendorName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal.VendorName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).VendorName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).VendorName = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormat _property;

        /// <summary>Encrypted SIM Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.EncryptedSimPropertiesFormat()); set => this._property = value; }

        /// <summary>The provisioning state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).ProvisioningState; }

        /// <summary>SIM policy resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string SimPolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SimPolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SimPolicyId = value ?? null; }

        /// <summary>The state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string SimState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SimState; }

        /// <summary>A dictionary of sites to the provisioning state of this SIM on that site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteProvisioning SiteProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).SiteProvisioningState; }

        /// <summary>
        /// A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached
        /// data network, slice}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties> StaticIPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).StaticIPConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).StaticIPConfiguration = value ?? null /* arrayOf */; }

        /// <summary>The public key fingerprint of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string VendorKeyFingerprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).VendorKeyFingerprint; }

        /// <summary>The name of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Inlined)]
        public string VendorName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ICommonSimPropertiesFormatInternal)Property).VendorName; }

        /// <summary>Creates an new <see cref="SimNameAndEncryptedProperties" /> instance.</summary>
        public SimNameAndEncryptedProperties()
        {

        }
    }
    /// SIM name and encrypted properties.
    public partial interface ISimNameAndEncryptedProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>
        /// An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video
        /// camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.",
        SerializedName = @"deviceType",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceType { get; set; }
        /// <summary>The encrypted SIM credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The encrypted SIM credentials.",
        SerializedName = @"encryptedCredentials",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptedCredentials { get; set; }
        /// <summary>The integrated circuit card ID (ICCID) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The integrated circuit card ID (ICCID) for the SIM.",
        SerializedName = @"integratedCircuitCardIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string IntegratedCircuitCardIdentifier { get; set; }
        /// <summary>The international mobile subscriber identity (IMSI) for the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The international mobile subscriber identity (IMSI) for the SIM.",
        SerializedName = @"internationalMobileSubscriberIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string InternationalMobileSubscriberIdentity { get; set; }
        /// <summary>The name of the SIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the SIM.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The provisioning state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the SIM resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PSArgumentCompleterAttribute("Unknown", "Succeeded", "Accepted", "Deleting", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get;  }
        /// <summary>SIM policy resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SIM policy resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SimPolicyId { get; set; }
        /// <summary>The state of the SIM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The state of the SIM resource.",
        SerializedName = @"simState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PSArgumentCompleterAttribute("Disabled", "Enabled", "Invalid")]
        string SimState { get;  }
        /// <summary>A dictionary of sites to the provisioning state of this SIM on that site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A dictionary of sites to the provisioning state of this SIM on that site.",
        SerializedName = @"siteProvisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteProvisioning) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteProvisioning SiteProvisioningState { get;  }
        /// <summary>
        /// A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached
        /// data network, slice}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached data network, slice}.",
        SerializedName = @"staticIpConfiguration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties> StaticIPConfiguration { get; set; }
        /// <summary>The public key fingerprint of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The public key fingerprint of the SIM vendor who provided this SIM, if any.",
        SerializedName = @"vendorKeyFingerprint",
        PossibleTypes = new [] { typeof(string) })]
        string VendorKeyFingerprint { get;  }
        /// <summary>The name of the SIM vendor who provided this SIM, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the SIM vendor who provided this SIM, if any.",
        SerializedName = @"vendorName",
        PossibleTypes = new [] { typeof(string) })]
        string VendorName { get;  }

    }
    /// SIM name and encrypted properties.
    internal partial interface ISimNameAndEncryptedPropertiesInternal

    {
        /// <summary>
        /// An optional free-form text field that can be used to record the device type this SIM is associated with, for example 'Video
        /// camera'. The Azure portal allows SIMs to be grouped and filtered based on this value.
        /// </summary>
        string DeviceType { get; set; }
        /// <summary>The encrypted SIM credentials.</summary>
        string EncryptedCredentials { get; set; }
        /// <summary>The integrated circuit card ID (ICCID) for the SIM.</summary>
        string IntegratedCircuitCardIdentifier { get; set; }
        /// <summary>The international mobile subscriber identity (IMSI) for the SIM.</summary>
        string InternationalMobileSubscriberIdentity { get; set; }
        /// <summary>The name of the SIM.</summary>
        string Name { get; set; }
        /// <summary>Encrypted SIM Properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormat Property { get; set; }
        /// <summary>The provisioning state of the SIM resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PSArgumentCompleterAttribute("Unknown", "Succeeded", "Accepted", "Deleting", "Failed", "Canceled", "Deleted")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// The SIM policy used by this SIM. The SIM policy must be in the same location as the SIM.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimPolicyResourceId SimPolicy { get; set; }
        /// <summary>SIM policy resource ID.</summary>
        string SimPolicyId { get; set; }
        /// <summary>The state of the SIM resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PSArgumentCompleterAttribute("Disabled", "Enabled", "Invalid")]
        string SimState { get; set; }
        /// <summary>A dictionary of sites to the provisioning state of this SIM on that site.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteProvisioning SiteProvisioningState { get; set; }
        /// <summary>
        /// A list of static IP addresses assigned to this SIM. Each address is assigned at a defined network scope, made up of {attached
        /// data network, slice}.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties> StaticIPConfiguration { get; set; }
        /// <summary>The public key fingerprint of the SIM vendor who provided this SIM, if any.</summary>
        string VendorKeyFingerprint { get; set; }
        /// <summary>The name of the SIM vendor who provided this SIM, if any.</summary>
        string VendorName { get; set; }

    }
}