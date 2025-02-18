// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The RP custom operation error info. </summary>
    public partial class AffectedMoveResource
    {
        /// <summary> Initializes a new instance of AffectedMoveResource. </summary>
        internal AffectedMoveResource()
        {
            MoveResources = new ChangeTrackingList<AffectedMoveResource>();
        }

        /// <summary> Initializes a new instance of AffectedMoveResource. </summary>
        /// <param name="id"> The affected move resource id. </param>
        /// <param name="sourceId"> The affected move resource source id. </param>
        /// <param name="moveResources"> The affected move resources. </param>
        internal AffectedMoveResource(string id, string sourceId, IReadOnlyList<AffectedMoveResource> moveResources)
        {
            Id = id;
            SourceId = sourceId;
            MoveResources = moveResources;
        }

        /// <summary> The affected move resource id. </summary>
        public string Id { get; }
        /// <summary> The affected move resource source id. </summary>
        public string SourceId { get; }
        /// <summary> The affected move resources. </summary>
        public IReadOnlyList<AffectedMoveResource> MoveResources { get; }
    }
}
