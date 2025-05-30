// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    /// <summary>Put subscription creation result properties.</summary>
    public partial class SubscriptionAliasResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AcceptOwnershipState" /> property.</summary>
        private string _acceptOwnershipState;

        /// <summary>The accept ownership state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string AcceptOwnershipState { get => this._acceptOwnershipState; }

        /// <summary>Backing field for <see cref="AcceptOwnershipUrl" /> property.</summary>
        private string _acceptOwnershipUrl;

        /// <summary>Url to accept ownership of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string AcceptOwnershipUrl { get => this._acceptOwnershipUrl; }

        /// <summary>Backing field for <see cref="BillingScope" /> property.</summary>
        private string _billingScope;

        /// <summary>
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string BillingScope { get => this._billingScope; set => this._billingScope = value; }

        /// <summary>Backing field for <see cref="CreatedTime" /> property.</summary>
        private string _createdTime;

        /// <summary>Created Time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string CreatedTime { get => this._createdTime; set => this._createdTime = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="ManagementGroupId" /> property.</summary>
        private string _managementGroupId;

        /// <summary>The Management Group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string ManagementGroupId { get => this._managementGroupId; set => this._managementGroupId = value; }

        /// <summary>Internal Acessors for AcceptOwnershipState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesInternal.AcceptOwnershipState { get => this._acceptOwnershipState; set { {_acceptOwnershipState = value;} } }

        /// <summary>Internal Acessors for AcceptOwnershipUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesInternal.AcceptOwnershipUrl { get => this._acceptOwnershipUrl; set { {_acceptOwnershipUrl = value;} } }

        /// <summary>Internal Acessors for SubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesInternal.SubscriptionId { get => this._subscriptionId; set { {_subscriptionId = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="ResellerId" /> property.</summary>
        private string _resellerId;

        /// <summary>Reseller Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string ResellerId { get => this._resellerId; set => this._resellerId = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>Newly created subscription Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; }

        /// <summary>Backing field for <see cref="SubscriptionOwnerId" /> property.</summary>
        private string _subscriptionOwnerId;

        /// <summary>Owner Id of the subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string SubscriptionOwnerId { get => this._subscriptionOwnerId; set => this._subscriptionOwnerId = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesTags _tag;

        /// <summary>Tags for the subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.SubscriptionAliasResponsePropertiesTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Workload" /> property.</summary>
        private string _workload;

        /// <summary>The workload type of the subscription. It can be either Production or DevTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Workload { get => this._workload; set => this._workload = value; }

        /// <summary>Creates an new <see cref="SubscriptionAliasResponseProperties" /> instance.</summary>
        public SubscriptionAliasResponseProperties()
        {

        }
    }
    /// Put subscription creation result properties.
    public partial interface ISubscriptionAliasResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable
    {
        /// <summary>The accept ownership state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The accept ownership state of the resource.",
        SerializedName = @"acceptOwnershipState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("Pending", "Completed", "Expired")]
        string AcceptOwnershipState { get;  }
        /// <summary>Url to accept ownership of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url to accept ownership of the subscription.",
        SerializedName = @"acceptOwnershipUrl",
        PossibleTypes = new [] { typeof(string) })]
        string AcceptOwnershipUrl { get;  }
        /// <summary>
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Billing scope of the subscription.
        For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}",
        SerializedName = @"billingScope",
        PossibleTypes = new [] { typeof(string) })]
        string BillingScope { get; set; }
        /// <summary>Created Time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Created Time",
        SerializedName = @"createdTime",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedTime { get; set; }
        /// <summary>The display name of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The display name of the subscription.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The Management Group Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Management Group Id.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagementGroupId { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Failed")]
        string ProvisioningState { get; set; }
        /// <summary>Reseller Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reseller Id",
        SerializedName = @"resellerId",
        PossibleTypes = new [] { typeof(string) })]
        string ResellerId { get; set; }
        /// <summary>Newly created subscription Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Newly created subscription Id.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get;  }
        /// <summary>Owner Id of the subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Owner Id of the subscription",
        SerializedName = @"subscriptionOwnerId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionOwnerId { get; set; }
        /// <summary>Tags for the subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tags for the subscription",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesTags Tag { get; set; }
        /// <summary>The workload type of the subscription. It can be either Production or DevTest.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The workload type of the subscription. It can be either Production or DevTest.",
        SerializedName = @"workload",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("Production", "DevTest")]
        string Workload { get; set; }

    }
    /// Put subscription creation result properties.
    internal partial interface ISubscriptionAliasResponsePropertiesInternal

    {
        /// <summary>The accept ownership state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("Pending", "Completed", "Expired")]
        string AcceptOwnershipState { get; set; }
        /// <summary>Url to accept ownership of the subscription.</summary>
        string AcceptOwnershipUrl { get; set; }
        /// <summary>
        /// Billing scope of the subscription.
        /// For CustomerLed and FieldLed - /billingAccounts/{billingAccountName}/billingProfiles/{billingProfileName}/invoiceSections/{invoiceSectionName}
        /// For PartnerLed - /billingAccounts/{billingAccountName}/customers/{customerName}
        /// For Legacy EA - /billingAccounts/{billingAccountName}/enrollmentAccounts/{enrollmentAccountName}
        /// </summary>
        string BillingScope { get; set; }
        /// <summary>Created Time</summary>
        string CreatedTime { get; set; }
        /// <summary>The display name of the subscription.</summary>
        string DisplayName { get; set; }
        /// <summary>The Management Group Id.</summary>
        string ManagementGroupId { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Failed")]
        string ProvisioningState { get; set; }
        /// <summary>Reseller Id</summary>
        string ResellerId { get; set; }
        /// <summary>Newly created subscription Id.</summary>
        string SubscriptionId { get; set; }
        /// <summary>Owner Id of the subscription</summary>
        string SubscriptionOwnerId { get; set; }
        /// <summary>Tags for the subscription</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISubscriptionAliasResponsePropertiesTags Tag { get; set; }
        /// <summary>The workload type of the subscription. It can be either Production or DevTest.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("Production", "DevTest")]
        string Workload { get; set; }

    }
}