// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Extensions;

    /// <summary>Solution response.</summary>
    public partial class SolutionResource :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResource,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ProxyResource();

        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public string Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Content; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>Internal Acessors for Content</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.Content { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Content; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Content = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceProperties Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.SolutionResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ReplacementMap</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IReplacementMaps Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ReplacementMap { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMap; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMap = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReplacementMapDiagnostic</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsDiagnostic> Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ReplacementMapDiagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapMetricsBasedChart</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IMetricsBasedChart> Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ReplacementMapMetricsBasedChart { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapTroubleshooter</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsTroubleshooters> Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ReplacementMapTroubleshooter { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapVideo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideo> Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ReplacementMapVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapVideoGroup</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideoGroup> Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ReplacementMapVideoGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ReplacementMapWebResult</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IWebResult> Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.ReplacementMapWebResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Section</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISection> Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.Section { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Section; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Section = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for SolutionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.SolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).SolutionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).SolutionId = value ?? null; }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal.Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Title = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Client input parameters to run Solution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesParameters Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Parameter = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceProperties _property;

        /// <summary>Solution result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.SolutionResourceProperties()); set => this._property = value; }

        /// <summary>Status of solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Solution diagnostics results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsDiagnostic> ReplacementMapDiagnostic { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapDiagnostic; }

        /// <summary>Solution metrics based charts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IMetricsBasedChart> ReplacementMapMetricsBasedChart { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapMetricsBasedChart; }

        /// <summary>Solutions Troubleshooters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsTroubleshooters> ReplacementMapTroubleshooter { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapTroubleshooter; }

        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideo> ReplacementMapVideo { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideo; }

        /// <summary>Group of Videos</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideoGroup> ReplacementMapVideoGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapVideoGroup; }

        /// <summary>Solution AzureKB results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IWebResult> ReplacementMapWebResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).ReplacementMapWebResult; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>List of section object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISection> Section { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Section; }

        /// <summary>Solution Id to identify single solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public string SolutionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).SolutionId; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>The title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).Title; }

        /// <summary>Solution request trigger criteria</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ITriggerCriterion> TriggerCriterion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).TriggerCriterion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesInternal)Property).TriggerCriterion = value ?? null /* arrayOf */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IResourceInternal)__proxyResource).Type; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="SolutionResource" /> instance.</summary>
        public SolutionResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Solution response.
    public partial interface ISolutionResource :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IProxyResource
    {
        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The HTML content that needs to be rendered and shown to customer.",
        SerializedName = @"content",
        PossibleTypes = new [] { typeof(string) })]
        string Content { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Client input parameters to run Solution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client input parameters to run Solution",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Status of solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of solution provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Solution diagnostics results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution diagnostics results.",
        SerializedName = @"diagnostics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsDiagnostic) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsDiagnostic> ReplacementMapDiagnostic { get;  }
        /// <summary>Solution metrics based charts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution metrics based charts",
        SerializedName = @"metricsBasedCharts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IMetricsBasedChart) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IMetricsBasedChart> ReplacementMapMetricsBasedChart { get;  }
        /// <summary>Solutions Troubleshooters</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solutions Troubleshooters",
        SerializedName = @"troubleshooters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsTroubleshooters) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsTroubleshooters> ReplacementMapTroubleshooter { get;  }
        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Video solutions, which have the power to engage the customer by stimulating their senses",
        SerializedName = @"videos",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideo> ReplacementMapVideo { get;  }
        /// <summary>Group of Videos</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Group of Videos",
        SerializedName = @"videoGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideoGroup) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideoGroup> ReplacementMapVideoGroup { get;  }
        /// <summary>Solution AzureKB results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution AzureKB results",
        SerializedName = @"webResults",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IWebResult) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IWebResult> ReplacementMapWebResult { get;  }
        /// <summary>List of section object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of section object.",
        SerializedName = @"sections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISection> Section { get;  }
        /// <summary>Solution Id to identify single solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Solution Id to identify single solution.",
        SerializedName = @"solutionId",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionId { get;  }
        /// <summary>The title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The title.",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get;  }
        /// <summary>Solution request trigger criteria</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution request trigger criteria",
        SerializedName = @"triggerCriteria",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ITriggerCriterion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ITriggerCriterion> TriggerCriterion { get; set; }

    }
    /// Solution response.
    internal partial interface ISolutionResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IProxyResourceInternal
    {
        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        string Content { get; set; }

        string Location { get; set; }
        /// <summary>Client input parameters to run Solution</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Solution result</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionResourceProperties Property { get; set; }
        /// <summary>Status of solution provisioning.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Solution replacement maps.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IReplacementMaps ReplacementMap { get; set; }
        /// <summary>Solution diagnostics results.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsDiagnostic> ReplacementMapDiagnostic { get; set; }
        /// <summary>Solution metrics based charts</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IMetricsBasedChart> ReplacementMapMetricsBasedChart { get; set; }
        /// <summary>Solutions Troubleshooters</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISolutionsTroubleshooters> ReplacementMapTroubleshooter { get; set; }
        /// <summary>
        /// Video solutions, which have the power to engage the customer by stimulating their senses
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideo> ReplacementMapVideo { get; set; }
        /// <summary>Group of Videos</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IVideoGroup> ReplacementMapVideoGroup { get; set; }
        /// <summary>Solution AzureKB results</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IWebResult> ReplacementMapWebResult { get; set; }
        /// <summary>List of section object.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISection> Section { get; set; }
        /// <summary>Solution Id to identify single solution.</summary>
        string SolutionId { get; set; }
        /// <summary>The title.</summary>
        string Title { get; set; }
        /// <summary>Solution request trigger criteria</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ITriggerCriterion> TriggerCriterion { get; set; }

    }
}