// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> P2S Vpn connection detailed health written to sas url. </summary>
    public partial class P2sVpnConnectionHealth
    {
        /// <summary> Initializes a new instance of P2sVpnConnectionHealth. </summary>
        internal P2sVpnConnectionHealth()
        {
        }

        /// <summary> Initializes a new instance of P2sVpnConnectionHealth. </summary>
        /// <param name="sasUri"> Returned sas url of the blob to which the p2s vpn connection detailed health will be written. </param>
        internal P2sVpnConnectionHealth(Uri sasUri)
        {
            SasUri = sasUri;
        }

        /// <summary> Returned sas url of the blob to which the p2s vpn connection detailed health will be written. </summary>
        public Uri SasUri { get; }
    }
}
