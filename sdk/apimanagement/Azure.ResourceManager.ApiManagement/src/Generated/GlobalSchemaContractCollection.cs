// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="GlobalSchemaContractResource" /> and their operations.
    /// Each <see cref="GlobalSchemaContractResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get a <see cref="GlobalSchemaContractCollection" /> instance call the GetGlobalSchemaContracts method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class GlobalSchemaContractCollection : ArmCollection, IEnumerable<GlobalSchemaContractResource>, IAsyncEnumerable<GlobalSchemaContractResource>
    {
        private readonly ClientDiagnostics _globalSchemaContractGlobalSchemaClientDiagnostics;
        private readonly GlobalSchemaRestOperations _globalSchemaContractGlobalSchemaRestClient;

        /// <summary> Initializes a new instance of the <see cref="GlobalSchemaContractCollection"/> class for mocking. </summary>
        protected GlobalSchemaContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GlobalSchemaContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GlobalSchemaContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _globalSchemaContractGlobalSchemaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", GlobalSchemaContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GlobalSchemaContractResource.ResourceType, out string globalSchemaContractGlobalSchemaApiVersion);
            _globalSchemaContractGlobalSchemaRestClient = new GlobalSchemaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, globalSchemaContractGlobalSchemaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates new or updates existing specified Schema of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}
        /// Operation Id: GlobalSchema_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GlobalSchemaContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string schemaId, GlobalSchemaContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _globalSchemaContractGlobalSchemaRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<GlobalSchemaContractResource>(new GlobalSchemaContractOperationSource(Client), _globalSchemaContractGlobalSchemaClientDiagnostics, Pipeline, _globalSchemaContractGlobalSchemaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates new or updates existing specified Schema of the API Management service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}
        /// Operation Id: GlobalSchema_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="data"> Create or update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GlobalSchemaContractResource> CreateOrUpdate(WaitUntil waitUntil, string schemaId, GlobalSchemaContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _globalSchemaContractGlobalSchemaRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<GlobalSchemaContractResource>(new GlobalSchemaContractOperationSource(Client), _globalSchemaContractGlobalSchemaClientDiagnostics, Pipeline, _globalSchemaContractGlobalSchemaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, data, ifMatch).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Schema specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}
        /// Operation Id: GlobalSchema_Get
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<Response<GlobalSchemaContractResource>> GetAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _globalSchemaContractGlobalSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalSchemaContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Schema specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}
        /// Operation Id: GlobalSchema_Get
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual Response<GlobalSchemaContractResource> Get(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.Get");
            scope.Start();
            try
            {
                var response = _globalSchemaContractGlobalSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GlobalSchemaContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of schemas registered with service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas
        /// Operation Id: GlobalSchema_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GlobalSchemaContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GlobalSchemaContractResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<GlobalSchemaContractResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _globalSchemaContractGlobalSchemaRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GlobalSchemaContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GlobalSchemaContractResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _globalSchemaContractGlobalSchemaRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GlobalSchemaContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists a collection of schemas registered with service instance.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas
        /// Operation Id: GlobalSchema_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GlobalSchemaContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GlobalSchemaContractResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<GlobalSchemaContractResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _globalSchemaContractGlobalSchemaRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GlobalSchemaContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GlobalSchemaContractResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _globalSchemaContractGlobalSchemaRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GlobalSchemaContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}
        /// Operation Id: GlobalSchema_Get
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _globalSchemaContractGlobalSchemaRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/schemas/{schemaId}
        /// Operation Id: GlobalSchema_Get
        /// </summary>
        /// <param name="schemaId"> Schema id identifier. Must be unique in the current API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="schemaId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="schemaId"/> is null. </exception>
        public virtual Response<bool> Exists(string schemaId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(schemaId, nameof(schemaId));

            using var scope = _globalSchemaContractGlobalSchemaClientDiagnostics.CreateScope("GlobalSchemaContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _globalSchemaContractGlobalSchemaRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, schemaId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GlobalSchemaContractResource> IEnumerable<GlobalSchemaContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GlobalSchemaContractResource> IAsyncEnumerable<GlobalSchemaContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
