// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Class containing a list of the resources that need to be moved and the
    /// resource group they should be moved to
    /// </summary>
    public partial class CsmMoveResourceEnvelope
    {
        /// <summary>
        /// Initializes a new instance of the CsmMoveResourceEnvelope class.
        /// </summary>
        public CsmMoveResourceEnvelope() { }

        /// <summary>
        /// Initializes a new instance of the CsmMoveResourceEnvelope class.
        /// </summary>
        public CsmMoveResourceEnvelope(string targetResourceGroup = default(string), IList<string> resources = default(IList<string>))
        {
            TargetResourceGroup = targetResourceGroup;
            Resources = resources;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroup")]
        public string TargetResourceGroup { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

    }
}