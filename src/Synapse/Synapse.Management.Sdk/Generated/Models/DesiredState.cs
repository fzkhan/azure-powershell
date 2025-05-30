// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{

    /// <summary>
    /// Defines values for DesiredState.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DesiredState
    {
        [System.Runtime.Serialization.EnumMember(Value = "Enabled")]
        Enabled,
        [System.Runtime.Serialization.EnumMember(Value = "Disabled")]
        Disabled
    }
    internal static class DesiredStateEnumExtension
    {
        internal static string ToSerializedValue(this DesiredState? value)
        {
            return value == null ? null : ((DesiredState)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this DesiredState value)
        {
            switch( value )
            {
                case DesiredState.Enabled:
                    return "Enabled";
                case DesiredState.Disabled:
                    return "Disabled";
            }
            return null;
        }
        internal static DesiredState? ParseDesiredState(this string value)
        {
            switch( value )
            {
                case "Enabled":
                    return DesiredState.Enabled;
                case "Disabled":
                    return DesiredState.Disabled;
            }
            return null;
        }
    }
}