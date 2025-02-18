// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiTagResourceContractProperties
    {
        internal static ApiTagResourceContractProperties DeserializeApiTagResourceContractProperties(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<Uri> serviceUrl = default;
            Optional<string> path = default;
            Optional<IReadOnlyList<Protocol>> protocols = default;
            Optional<string> description = default;
            Optional<AuthenticationSettingsContract> authenticationSettings = default;
            Optional<SubscriptionKeyParameterNamesContract> subscriptionKeyParameterNames = default;
            Optional<ApiType> type = default;
            Optional<string> apiRevision = default;
            Optional<string> apiVersion = default;
            Optional<bool> isCurrent = default;
            Optional<bool> isOnline = default;
            Optional<string> apiRevisionDescription = default;
            Optional<string> apiVersionDescription = default;
            Optional<string> apiVersionSetId = default;
            Optional<bool> subscriptionRequired = default;
            Optional<Uri> termsOfServiceUrl = default;
            Optional<ApiContactInformation> contact = default;
            Optional<ApiLicenseInformation> license = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        serviceUrl = null;
                        continue;
                    }
                    serviceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocols"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Protocol> array = new List<Protocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new Protocol(item.GetString()));
                    }
                    protocols = array;
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property.Value);
                    continue;
                }
                if (property.NameEquals("subscriptionKeyParameterNames"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ApiType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiRevision"))
                {
                    apiRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCurrent"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOnline"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOnline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("apiRevisionDescription"))
                {
                    apiRevisionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionDescription"))
                {
                    apiVersionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionSetId"))
                {
                    apiVersionSetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("termsOfServiceUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        termsOfServiceUrl = null;
                        continue;
                    }
                    termsOfServiceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contact"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    contact = ApiContactInformation.DeserializeApiContactInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("license"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    license = ApiLicenseInformation.DeserializeApiLicenseInformation(property.Value);
                    continue;
                }
            }
            return new ApiTagResourceContractProperties(description.Value, authenticationSettings.Value, subscriptionKeyParameterNames.Value, Optional.ToNullable(type), apiRevision.Value, apiVersion.Value, Optional.ToNullable(isCurrent), Optional.ToNullable(isOnline), apiRevisionDescription.Value, apiVersionDescription.Value, apiVersionSetId.Value, Optional.ToNullable(subscriptionRequired), termsOfServiceUrl.Value, contact.Value, license.Value, id.Value, name.Value, serviceUrl.Value, path.Value, Optional.ToList(protocols));
        }
    }
}
