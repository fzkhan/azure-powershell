// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Open AI Integration details.</summary>
    public partial class OpenAiIntegrationProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json ? new OpenAiIntegrationProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject into a new instance of <see cref="OpenAiIntegrationProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OpenAiIntegrationProperties(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_openAiResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("openAIResourceId"), out var __jsonOpenAiResourceId) ? (string)__jsonOpenAiResourceId : (string)_openAiResourceId;}
            {_openAiResourceEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("openAIResourceEndpoint"), out var __jsonOpenAiResourceEndpoint) ? (string)__jsonOpenAiResourceEndpoint : (string)_openAiResourceEndpoint;}
            {_key = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("key"), out var __jsonKey) ? (string)__jsonKey : (string)_key;}
            {_lastRefreshAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("lastRefreshAt"), out var __jsonLastRefreshAt) ? global::System.DateTime.TryParse((string)__jsonLastRefreshAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastRefreshAtValue) ? __jsonLastRefreshAtValue : _lastRefreshAt : _lastRefreshAt;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OpenAiIntegrationProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OpenAiIntegrationProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._openAiResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._openAiResourceId.ToString()) : null, "openAIResourceId" ,container.Add );
            AddIf( null != (((object)this._openAiResourceEndpoint)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._openAiResourceEndpoint.ToString()) : null, "openAIResourceEndpoint" ,container.Add );
            AddIf( null != (((object)this._key)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._key.ToString()) : null, "key" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._lastRefreshAt ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._lastRefreshAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastRefreshAt" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}