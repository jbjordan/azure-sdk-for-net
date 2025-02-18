// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GroupContractProperties
    {
        internal static GroupContractProperties DeserializeGroupContractProperties(JsonElement element)
        {
            string displayName = default;
            Optional<string> description = default;
            Optional<bool> builtIn = default;
            Optional<GroupType> type = default;
            Optional<string> externalId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("builtIn"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    builtIn = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToGroupType();
                    continue;
                }
                if (property.NameEquals("externalId"))
                {
                    externalId = property.Value.GetString();
                    continue;
                }
            }
            return new GroupContractProperties(displayName, description.Value, Optional.ToNullable(builtIn), Optional.ToNullable(type), externalId.Value);
        }
    }
}
