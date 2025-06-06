// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using System.Linq;

    /// <summary>
    /// Periodic timer event source.
    /// </summary>
    public partial class PeriodicTimerSourceInfo
    {
        /// <summary>
        /// Initializes a new instance of the PeriodicTimerSourceInfo class.
        /// </summary>
        public PeriodicTimerSourceInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeriodicTimerSourceInfo class.
        /// </summary>

        /// <param name="startTime">The time of the day that results in a valid trigger. Schedule is computed
        /// with reference to the time specified upto seconds. If timezone is not
        /// specified the time will considered to be in device timezone. The value will
        /// always be returned as UTC time.
        /// </param>

        /// <param name="schedule">Periodic frequency at which timer event needs to be raised. Supports daily,
        /// hourly, minutes, and seconds.
        /// </param>

        /// <param name="topic">Topic where periodic events are published to IoT device.
        /// </param>
        public PeriodicTimerSourceInfo(System.DateTime startTime, string schedule, string topic = default(string))

        {
            this.StartTime = startTime;
            this.Schedule = schedule;
            this.Topic = topic;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the time of the day that results in a valid trigger. Schedule
        /// is computed with reference to the time specified upto seconds. If timezone
        /// is not specified the time will considered to be in device timezone. The
        /// value will always be returned as UTC time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime {get; set; }

        /// <summary>
        /// Gets or sets periodic frequency at which timer event needs to be raised.
        /// Supports daily, hourly, minutes, and seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedule")]
        public string Schedule {get; set; }

        /// <summary>
        /// Gets or sets topic where periodic events are published to IoT device.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "topic")]
        public string Topic {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Schedule == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Schedule");
            }


        }
    }
}