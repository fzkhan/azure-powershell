// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.PowerShell;

    /// <summary>Diagnostic resource properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(DiagnosticResourcePropertiesTypeConverter))]
    public partial class DiagnosticResourceProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DiagnosticResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DiagnosticResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DiagnosticResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlobalParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).GlobalParameter = (Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesGlobalParameters) content.GetValueForProperty("GlobalParameter",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).GlobalParameter, Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticResourcePropertiesGlobalParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Insight"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Insight = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocation>) content.GetValueForProperty("Insight",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Insight, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocation>(__y, Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticInvocationTypeConverter.ConvertFrom));
            }
            if (content.Contains("AcceptedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).AcceptedAt = (string) content.GetValueForProperty("AcceptedAt",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).AcceptedAt, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Diagnostic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Diagnostic = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnostic>) content.GetValueForProperty("Diagnostic",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Diagnostic, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnostic>(__y, Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DiagnosticResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlobalParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).GlobalParameter = (Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesGlobalParameters) content.GetValueForProperty("GlobalParameter",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).GlobalParameter, Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticResourcePropertiesGlobalParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Insight"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Insight = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocation>) content.GetValueForProperty("Insight",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Insight, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocation>(__y, Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticInvocationTypeConverter.ConvertFrom));
            }
            if (content.Contains("AcceptedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).AcceptedAt = (string) content.GetValueForProperty("AcceptedAt",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).AcceptedAt, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Diagnostic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Diagnostic = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnostic>) content.GetValueForProperty("Diagnostic",((Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourcePropertiesInternal)this).Diagnostic, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnostic>(__y, Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DiagnosticResourceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DiagnosticResourceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Diagnostic resource properties.
    [System.ComponentModel.TypeConverter(typeof(DiagnosticResourcePropertiesTypeConverter))]
    public partial interface IDiagnosticResourceProperties

    {

    }
}