// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Partner server information for the failover group. </summary>
    public partial class PartnerInfo
    {
        /// <summary> Initializes a new instance of PartnerInfo. </summary>
        /// <param name="id"> Resource identifier of the partner server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public PartnerInfo(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of PartnerInfo. </summary>
        /// <param name="id"> Resource identifier of the partner server. </param>
        /// <param name="location"> Geo location of the partner server. </param>
        /// <param name="replicationRole"> Replication role of the partner server. </param>
        internal PartnerInfo(string id, AzureLocation? location, FailoverGroupReplicationRole? replicationRole)
        {
            Id = id;
            Location = location;
            ReplicationRole = replicationRole;
        }

        /// <summary> Resource identifier of the partner server. </summary>
        public string Id { get; set; }
        /// <summary> Geo location of the partner server. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Replication role of the partner server. </summary>
        public FailoverGroupReplicationRole? ReplicationRole { get; }
    }
}
