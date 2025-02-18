// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Avro dataset. </summary>
    public partial class AvroDataset : Dataset
    {
        /// <summary> Initializes a new instance of AvroDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public AvroDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            DatasetType = "Avro";
        }

        /// <summary> Initializes a new instance of AvroDataset. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="location">
        /// The location of the avro storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleLocation"/>, <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/>, <see cref="OracleCloudStorageLocation"/> and <see cref="SftpLocation"/>.
        /// </param>
        /// <param name="avroCompressionCodec"> The data avroCompressionCodec. Type: string (or Expression with resultType string). </param>
        /// <param name="avroCompressionLevel"></param>
        internal AvroDataset(string datasetType, string description, BinaryData structure, BinaryData schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DatasetLocation location, BinaryData avroCompressionCodec, int? avroCompressionLevel) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Location = location;
            AvroCompressionCodec = avroCompressionCodec;
            AvroCompressionLevel = avroCompressionLevel;
            DatasetType = datasetType ?? "Avro";
        }

        /// <summary>
        /// The location of the avro storage.
        /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleLocation"/>, <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/>, <see cref="OracleCloudStorageLocation"/> and <see cref="SftpLocation"/>.
        /// </summary>
        public DatasetLocation Location { get; set; }
        /// <summary> The data avroCompressionCodec. Type: string (or Expression with resultType string). </summary>
        public BinaryData AvroCompressionCodec { get; set; }
        /// <summary> Gets or sets the avro compression level. </summary>
        public int? AvroCompressionLevel { get; set; }
    }
}
