// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Nat Gateway properties.
    /// </summary>
    public partial class NatGatewayPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the NatGatewayPropertiesFormat class.
        /// </summary>
        public NatGatewayPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NatGatewayPropertiesFormat class.
        /// </summary>

        /// <param name="idleTimeoutInMinutes">The idle timeout of the nat gateway.
        /// </param>

        /// <param name="publicIPAddresses">An array of public ip addresses V4 associated with the nat gateway
        /// resource.
        /// </param>

        /// <param name="publicIPAddressesV6">An array of public ip addresses V6 associated with the nat gateway
        /// resource.
        /// </param>

        /// <param name="publicIPPrefixes">An array of public ip prefixes V4 associated with the nat gateway resource.
        /// </param>

        /// <param name="publicIPPrefixesV6">An array of public ip prefixes V6 associated with the nat gateway resource.
        /// </param>

        /// <param name="subnets">An array of references to the subnets using this nat gateway resource.
        /// </param>

        /// <param name="sourceVirtualNetwork">A reference to the source virtual network using this nat gateway resource.
        /// </param>

        /// <param name="resourceGuid">The resource GUID property of the NAT gateway resource.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the NAT gateway resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>
        public NatGatewayPropertiesFormat(int? idleTimeoutInMinutes = default(int?), System.Collections.Generic.IList<SubResource> publicIPAddresses = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> publicIPAddressesV6 = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> publicIPPrefixes = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> publicIPPrefixesV6 = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> subnets = default(System.Collections.Generic.IList<SubResource>), SubResource sourceVirtualNetwork = default(SubResource), string resourceGuid = default(string), string provisioningState = default(string))

        {
            this.IdleTimeoutInMinutes = idleTimeoutInMinutes;
            this.PublicIPAddresses = publicIPAddresses;
            this.PublicIPAddressesV6 = publicIPAddressesV6;
            this.PublicIPPrefixes = publicIPPrefixes;
            this.PublicIPPrefixesV6 = publicIPPrefixesV6;
            this.Subnets = subnets;
            this.SourceVirtualNetwork = sourceVirtualNetwork;
            this.ResourceGuid = resourceGuid;
            this.ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the idle timeout of the nat gateway.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes {get; set; }

        /// <summary>
        /// Gets or sets an array of public ip addresses V4 associated with the nat
        /// gateway resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIpAddresses")]
        public System.Collections.Generic.IList<SubResource> PublicIPAddresses {get; set; }

        /// <summary>
        /// Gets or sets an array of public ip addresses V6 associated with the nat
        /// gateway resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIpAddressesV6")]
        public System.Collections.Generic.IList<SubResource> PublicIPAddressesV6 {get; set; }

        /// <summary>
        /// Gets or sets an array of public ip prefixes V4 associated with the nat
        /// gateway resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIpPrefixes")]
        public System.Collections.Generic.IList<SubResource> PublicIPPrefixes {get; set; }

        /// <summary>
        /// Gets or sets an array of public ip prefixes V6 associated with the nat
        /// gateway resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicIpPrefixesV6")]
        public System.Collections.Generic.IList<SubResource> PublicIPPrefixesV6 {get; set; }

        /// <summary>
        /// Gets an array of references to the subnets using this nat gateway resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subnets")]
        public System.Collections.Generic.IList<SubResource> Subnets {get; private set; }

        /// <summary>
        /// Gets or sets a reference to the source virtual network using this nat
        /// gateway resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceVirtualNetwork")]
        public SubResource SourceVirtualNetwork {get; set; }

        /// <summary>
        /// Gets the resource GUID property of the NAT gateway resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceGuid")]
        public string ResourceGuid {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the NAT gateway resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }
    }
}