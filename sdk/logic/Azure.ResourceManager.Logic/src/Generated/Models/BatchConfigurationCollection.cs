// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> A collection of batch configurations. </summary>
    internal partial class BatchConfigurationCollection
    {
        /// <summary> Initializes a new instance of BatchConfigurationCollection. </summary>
        internal BatchConfigurationCollection()
        {
            Value = new ChangeTrackingList<BatchConfigurationData>();
        }

        /// <summary> Initializes a new instance of BatchConfigurationCollection. </summary>
        /// <param name="value"></param>
        internal BatchConfigurationCollection(IReadOnlyList<BatchConfigurationData> value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<BatchConfigurationData> Value { get; }
    }
}
