// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Batch.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch
{
    /// <summary> A class representing the Certificate data model. </summary>
    public partial class CertificateData : ResourceData
    {
        /// <summary> Initializes a new instance of CertificateData. </summary>
        public CertificateData()
        {
        }

        /// <summary> Initializes a new instance of CertificateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="thumbprintAlgorithm"> This must match the first portion of the certificate name. Currently required to be &apos;SHA1&apos;. </param>
        /// <param name="thumbprint"> This must match the thumbprint from the name. </param>
        /// <param name="format"> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </param>
        /// <param name="provisioningState"></param>
        /// <param name="provisioningStateTransitionOn"> The time at which the certificate entered its current state. </param>
        /// <param name="previousProvisioningState"> The previous provisioned state of the resource. </param>
        /// <param name="previousProvisioningStateTransitionOn"> The time at which the certificate entered its previous state. </param>
        /// <param name="publicData"> The public key of the certificate. </param>
        /// <param name="deleteCertificateError"> This is only returned when the certificate provisioningState is &apos;Failed&apos;. </param>
        /// <param name="eTag"> The ETag of the resource, used for concurrency statements. </param>
        internal CertificateData(ResourceIdentifier id, string name, Core.ResourceType resourceType, SystemData systemData, string thumbprintAlgorithm, string thumbprint, CertificateFormat? format, CertificateProvisioningState? provisioningState, DateTimeOffset? provisioningStateTransitionOn, CertificateProvisioningState? previousProvisioningState, DateTimeOffset? previousProvisioningStateTransitionOn, string publicData, ResponseError deleteCertificateError, ETag? eTag) : base(id, name, resourceType, systemData)
        {
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Thumbprint = thumbprint;
            Format = format;
            ProvisioningState = provisioningState;
            ProvisioningStateTransitionOn = provisioningStateTransitionOn;
            PreviousProvisioningState = previousProvisioningState;
            PreviousProvisioningStateTransitionOn = previousProvisioningStateTransitionOn;
            PublicData = publicData;
            DeleteCertificateError = deleteCertificateError;
            ETag = eTag;
        }

        /// <summary> This must match the first portion of the certificate name. Currently required to be &apos;SHA1&apos;. </summary>
        public string ThumbprintAlgorithm { get; set; }
        /// <summary> This must match the thumbprint from the name. </summary>
        public string Thumbprint { get; set; }
        /// <summary> The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx. </summary>
        public CertificateFormat? Format { get; set; }
        /// <summary> Gets the provisioning state. </summary>
        public CertificateProvisioningState? ProvisioningState { get; }
        /// <summary> The time at which the certificate entered its current state. </summary>
        public DateTimeOffset? ProvisioningStateTransitionOn { get; }
        /// <summary> The previous provisioned state of the resource. </summary>
        public CertificateProvisioningState? PreviousProvisioningState { get; }
        /// <summary> The time at which the certificate entered its previous state. </summary>
        public DateTimeOffset? PreviousProvisioningStateTransitionOn { get; }
        /// <summary> The public key of the certificate. </summary>
        public string PublicData { get; }
        /// <summary> This is only returned when the certificate provisioningState is &apos;Failed&apos;. </summary>
        public ResponseError DeleteCertificateError { get; }
        /// <summary> The ETag of the resource, used for concurrency statements. </summary>
        public ETag? ETag { get; }
    }
}
