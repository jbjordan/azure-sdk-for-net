// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class UsageListResult
    {
        internal static UsageListResult DeserializeUsageListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CognitiveServicesUsage>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CognitiveServicesUsage> array = new List<CognitiveServicesUsage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesUsage.DeserializeCognitiveServicesUsage(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new UsageListResult(Optional.ToList(value));
        }
    }
}
