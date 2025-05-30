// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>
    /// Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
    /// </summary>
    public partial class AfdDomain :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomain,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ProxyResource();

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string AzureDnsZoneId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).AzureDnsZoneId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).AzureDnsZoneId = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)Property).DeploymentStatus; }

        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string DomainValidationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).DomainValidationState; }

        /// <summary>Key-Value pair representing migration properties for domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesExtendedProperties ExtendedProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ExtendedProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ExtendedProperty = value ?? null /* model class */; }

        /// <summary>The host name of the domain. Must be a domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).HostName = value ?? null; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for AzureDnsZone</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.AzureDnsZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).AzureDnsZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).AzureDnsZone = value; }

        /// <summary>Internal Acessors for DeploymentStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.DeploymentStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)Property).DeploymentStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)Property).DeploymentStatus = value; }

        /// <summary>Internal Acessors for DomainValidationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.DomainValidationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).DomainValidationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).DomainValidationState = value; }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).ProfileName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).ProfileName = value; }

        /// <summary>Internal Acessors for PropertiesPreValidatedCustomDomainResourceId</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceReference Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.PropertiesPreValidatedCustomDomainResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).PreValidatedCustomDomainResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).PreValidatedCustomDomainResourceId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdDomainProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for ValidationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDomainValidationProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.ValidationProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationProperty = value; }

        /// <summary>Internal Acessors for ValidationPropertyExpirationDate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.ValidationPropertyExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationPropertyExpirationDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationPropertyExpirationDate = value; }

        /// <summary>Internal Acessors for ValidationPropertyValidationToken</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal.ValidationPropertyValidationToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationPropertyValidationToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationPropertyValidationToken = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>The name of the profile which holds the domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).ProfileName; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PropertiesPreValidatedCustomDomainResourceIdId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).PreValidatedCustomDomainResourceIdId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).PreValidatedCustomDomainResourceIdId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainProperties _property;

        /// <summary>The JSON object that contains the properties of the domain to create.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.AfdDomainProperties()); set => this._property = value; }

        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdStatePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.FormatTable]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Read only system data</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>An identifier for the identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>An identifier for the identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.DoNotFormat]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own
        /// certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainHttpsParameters TlsSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).TlsSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainUpdatePropertiesParametersInternal)Property).TlsSetting = value ?? null /* model class */; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>The date time that the token expires</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ValidationPropertyExpirationDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationPropertyExpirationDate; }

        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string ValidationPropertyValidationToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesInternal)Property).ValidationPropertyValidationToken; }

        /// <summary>Creates an new <see cref="AfdDomain" /> instance.</summary>
        public AfdDomain()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
    public partial interface IAfdDomain :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProxyResource
    {
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string AzureDnsZoneId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"deploymentStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("NotStarted", "InProgress", "Succeeded", "Failed")]
        string DeploymentStatus { get;  }
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.",
        SerializedName = @"domainValidationState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Unknown", "Submitting", "Pending", "Rejected", "TimedOut", "PendingRevalidation", "Approved", "RefreshingValidationToken", "InternalError")]
        string DomainValidationState { get;  }
        /// <summary>Key-Value pair representing migration properties for domains.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Key-Value pair representing migration properties for domains.",
        SerializedName = @"extendedProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesExtendedProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesExtendedProperties ExtendedProperty { get; set; }
        /// <summary>The host name of the domain. Must be a domain name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The host name of the domain. Must be a domain name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The name of the profile which holds the domain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the profile which holds the domain.",
        SerializedName = @"profileName",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileName { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesPreValidatedCustomDomainResourceIdId { get; set; }
        /// <summary>Provisioning status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning status",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Succeeded", "Failed", "Updating", "Deleting", "Creating")]
        string ProvisioningState { get;  }
        /// <summary>
        /// The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own
        /// certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default.",
        SerializedName = @"tlsSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainHttpsParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainHttpsParameters TlsSetting { get; set; }
        /// <summary>The date time that the token expires</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The date time that the token expires",
        SerializedName = @"expirationDate",
        PossibleTypes = new [] { typeof(string) })]
        string ValidationPropertyExpirationDate { get;  }
        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Challenge used for DNS TXT record or file based validation",
        SerializedName = @"validationToken",
        PossibleTypes = new [] { typeof(string) })]
        string ValidationPropertyValidationToken { get;  }

    }
    /// Friendly domain name mapping to the endpoint hostname that the customer provides for branding purposes, e.g. www.contoso.com.
    internal partial interface IAfdDomainInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IProxyResourceInternal
    {
        /// <summary>Resource reference to the Azure DNS zone</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceReference AzureDnsZone { get; set; }
        /// <summary>Resource ID.</summary>
        string AzureDnsZoneId { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("NotStarted", "InProgress", "Succeeded", "Failed")]
        string DeploymentStatus { get; set; }
        /// <summary>
        /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Unknown", "Submitting", "Pending", "Rejected", "TimedOut", "PendingRevalidation", "Approved", "RefreshingValidationToken", "InternalError")]
        string DomainValidationState { get; set; }
        /// <summary>Key-Value pair representing migration properties for domains.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainPropertiesExtendedProperties ExtendedProperty { get; set; }
        /// <summary>The host name of the domain. Must be a domain name.</summary>
        string HostName { get; set; }

        string Location { get; set; }
        /// <summary>The name of the profile which holds the domain.</summary>
        string ProfileName { get; set; }
        /// <summary>
        /// Resource reference to the Azure resource where custom domain ownership was prevalidated
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IResourceReference PropertiesPreValidatedCustomDomainResourceId { get; set; }
        /// <summary>Resource ID.</summary>
        string PropertiesPreValidatedCustomDomainResourceIdId { get; set; }
        /// <summary>The JSON object that contains the properties of the domain to create.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainProperties Property { get; set; }
        /// <summary>Provisioning status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("Succeeded", "Failed", "Updating", "Deleting", "Creating")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// The configuration specifying how to enable HTTPS for the domain - using AzureFrontDoor managed certificate or user's own
        /// certificate. If not specified, enabling ssl uses AzureFrontDoor managed certificate by default.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IAfdDomainHttpsParameters TlsSetting { get; set; }
        /// <summary>Values the customer needs to validate domain ownership</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDomainValidationProperties ValidationProperty { get; set; }
        /// <summary>The date time that the token expires</summary>
        string ValidationPropertyExpirationDate { get; set; }
        /// <summary>Challenge used for DNS TXT record or file based validation</summary>
        string ValidationPropertyValidationToken { get; set; }

    }
}