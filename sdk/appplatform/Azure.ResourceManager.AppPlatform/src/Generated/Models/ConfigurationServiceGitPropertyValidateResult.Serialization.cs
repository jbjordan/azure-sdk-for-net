// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ConfigurationServiceGitPropertyValidateResult
    {
        internal static ConfigurationServiceGitPropertyValidateResult DeserializeConfigurationServiceGitPropertyValidateResult(JsonElement element)
        {
            Optional<bool> isValid = default;
            Optional<IReadOnlyList<ValidationMessages>> gitReposValidationResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isValid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isValid = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gitReposValidationResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ValidationMessages> array = new List<ValidationMessages>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ValidationMessages.DeserializeValidationMessages(item));
                    }
                    gitReposValidationResult = array;
                    continue;
                }
            }
            return new ConfigurationServiceGitPropertyValidateResult(Optional.ToNullable(isValid), Optional.ToList(gitReposValidationResult));
        }
    }
}
