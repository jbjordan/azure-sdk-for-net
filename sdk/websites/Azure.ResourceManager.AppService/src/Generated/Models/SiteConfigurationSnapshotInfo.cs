// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A snapshot of a web app configuration. </summary>
    public partial class SiteConfigurationSnapshotInfo : ResourceData
    {
        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfo. </summary>
        public SiteConfigurationSnapshotInfo()
        {
        }

        /// <summary> Initializes a new instance of SiteConfigurationSnapshotInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="time"> The time the snapshot was taken. </param>
        /// <param name="snapshotId"> The id of the snapshot. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal SiteConfigurationSnapshotInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? time, int? snapshotId, string kind) : base(id, name, resourceType, systemData)
        {
            Time = time;
            SnapshotId = snapshotId;
            Kind = kind;
        }

        /// <summary> The time the snapshot was taken. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> The id of the snapshot. </summary>
        public int? SnapshotId { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
