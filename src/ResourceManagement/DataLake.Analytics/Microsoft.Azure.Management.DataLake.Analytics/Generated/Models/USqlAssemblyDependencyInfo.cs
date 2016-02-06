// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL dependency information item.
    /// </summary>
    public partial class USqlAssemblyDependencyInfo
    {
        /// <summary>
        /// Initializes a new instance of the USqlAssemblyDependencyInfo class.
        /// </summary>
        public USqlAssemblyDependencyInfo() { }

        /// <summary>
        /// Initializes a new instance of the USqlAssemblyDependencyInfo class.
        /// </summary>
        public USqlAssemblyDependencyInfo(EntityId entityId = default(EntityId))
        {
            EntityId = entityId;
        }

        /// <summary>
        /// Gets or sets the EntityId of the dependency.
        /// </summary>
        [JsonProperty(PropertyName = "entityId")]
        public EntityId EntityId { get; set; }

    }
}