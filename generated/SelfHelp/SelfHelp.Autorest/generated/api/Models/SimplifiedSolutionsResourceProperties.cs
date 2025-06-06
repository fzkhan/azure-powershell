// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Extensions;

    /// <summary>Simplified Solutions result</summary>
    public partial class SimplifiedSolutionsResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Appendix" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesAppendix _appendix;

        /// <summary>Additional parameter response for Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesAppendix Appendix { get => (this._appendix = this._appendix ?? new Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.SimplifiedSolutionsResourcePropertiesAppendix()); }

        /// <summary>Backing field for <see cref="Content" /> property.</summary>
        private string _content;

        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string Content { get => this._content; }

        /// <summary>Internal Acessors for Appendix</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesAppendix Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesInternal.Appendix { get => (this._appendix = this._appendix ?? new Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.SimplifiedSolutionsResourcePropertiesAppendix()); set { {_appendix = value;} } }

        /// <summary>Internal Acessors for Content</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesInternal.Content { get => this._content; set { {_content = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesInternal.Title { get => this._title; set { {_title = value;} } }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesParameters _parameter;

        /// <summary>Client input parameters to run Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesParameters Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.SimplifiedSolutionsResourcePropertiesParameters()); set => this._parameter = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Status of Simplified Solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SolutionId" /> property.</summary>
        private string _solutionId;

        /// <summary>Solution Id to identify single Simplified Solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string SolutionId { get => this._solutionId; set => this._solutionId = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>The title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string Title { get => this._title; }

        /// <summary>Creates an new <see cref="SimplifiedSolutionsResourceProperties" /> instance.</summary>
        public SimplifiedSolutionsResourceProperties()
        {

        }
    }
    /// Simplified Solutions result
    public partial interface ISimplifiedSolutionsResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IJsonSerializable
    {
        /// <summary>Additional parameter response for Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Additional parameter response for Simplified Solutions",
        SerializedName = @"appendix",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesAppendix) })]
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesAppendix Appendix { get;  }
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
        /// <summary>Client input parameters to run Simplified Solutions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Client input parameters to run Simplified Solutions",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Status of Simplified Solution provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of Simplified Solution provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Solution Id to identify single Simplified Solution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution Id to identify single Simplified Solution.",
        SerializedName = @"solutionId",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionId { get; set; }
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

    }
    /// Simplified Solutions result
    internal partial interface ISimplifiedSolutionsResourcePropertiesInternal

    {
        /// <summary>Additional parameter response for Simplified Solutions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesAppendix Appendix { get; set; }
        /// <summary>The HTML content that needs to be rendered and shown to customer.</summary>
        string Content { get; set; }
        /// <summary>Client input parameters to run Simplified Solutions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.ISimplifiedSolutionsResourcePropertiesParameters Parameter { get; set; }
        /// <summary>Status of Simplified Solution provisioning.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PSArgumentCompleterAttribute("Succeeded", "PartialComplete", "Failed", "Running", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Solution Id to identify single Simplified Solution.</summary>
        string SolutionId { get; set; }
        /// <summary>The title.</summary>
        string Title { get; set; }

    }
}