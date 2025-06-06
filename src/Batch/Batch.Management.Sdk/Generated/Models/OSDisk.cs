// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Settings for the operating system disk of the virtual machine.
    /// </summary>
    /// <remarks>
    /// Settings for the operating system disk of the virtual machine.
    /// </remarks>
    public partial class OSDisk
    {
        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>
        public OSDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OSDisk class.
        /// </summary>

        /// <param name="ephemeralOSDiskSettings">Specifies the ephemeral Disk Settings for the operating system disk used by
        /// the virtual machine.
        /// </param>
        public OSDisk(DiffDiskSettings ephemeralOSDiskSettings = default(DiffDiskSettings))

        {
            this.EphemeralOSDiskSettings = ephemeralOSDiskSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifies the ephemeral Disk Settings for the operating system
        /// disk used by the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ephemeralOSDiskSettings")]
        public DiffDiskSettings EphemeralOSDiskSettings {get; set; }
    }
}