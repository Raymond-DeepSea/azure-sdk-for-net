// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a schedule for indexer execution.
    /// </summary>
    public partial class IndexingSchedule
    {
        /// <summary>
        /// Initializes a new instance of the IndexingSchedule class.
        /// </summary>
        public IndexingSchedule() { }

        /// <summary>
        /// Initializes a new instance of the IndexingSchedule class.
        /// </summary>
        /// <param name="interval">The interval of time between indexer
        /// executions.</param>
        /// <param name="startTime">The time when an indexer should start
        /// running.</param>
        public IndexingSchedule(System.TimeSpan interval, System.DateTimeOffset? startTime = default(System.DateTimeOffset?))
        {
            Interval = interval;
            StartTime = startTime;
        }

        /// <summary>
        /// Gets or sets the interval of time between indexer executions.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public System.TimeSpan Interval { get; set; }

        /// <summary>
        /// Gets or sets the time when an indexer should start running.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
