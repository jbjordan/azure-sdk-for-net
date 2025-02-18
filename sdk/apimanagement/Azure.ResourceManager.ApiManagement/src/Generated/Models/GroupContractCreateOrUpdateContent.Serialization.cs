// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GroupContractCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(GroupType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(GroupType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ExternalId))
            {
                writer.WritePropertyName("externalId");
                writer.WriteStringValue(ExternalId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
