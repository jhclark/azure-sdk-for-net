// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics account object, containing all information
    /// associated with the named Data Lake Analytics account.
    /// </summary>
    [JsonTransformation]
    public partial class DataLakeAnalyticsAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        public DataLakeAnalyticsAccount() { }

        /// <summary>
        /// Initializes a new instance of the DataLakeAnalyticsAccount class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="defaultDataLakeStoreAccount">the default data lake
        /// storage account associated with this Data Lake Analytics
        /// account.</param>
        /// <param name="dataLakeStoreAccounts">the list of Data Lake storage
        /// accounts associated with this account.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">the provisioning status of the
        /// Data Lake Analytics account. Possible values include: 'Failed',
        /// 'Creating', 'Running', 'Succeeded', 'Patching', 'Suspending',
        /// 'Resuming', 'Deleting', 'Deleted'</param>
        /// <param name="state">the state of the Data Lake Analytics account.
        /// Possible values include: 'Active', 'Suspended'</param>
        /// <param name="maxDegreeOfParallelism">the maximum supported degree
        /// of parallelism for this account.</param>
        /// <param name="queryStoreRetention">the number of days that job
        /// metadata is retained.</param>
        /// <param name="maxJobCount">the maximum supported jobs running under
        /// the account at the same time.</param>
        /// <param name="systemMaxDegreeOfParallelism">the system defined
        /// maximum supported degree of parallelism for this account, which
        /// restricts the maximum value of parallelism the user can set for
        /// the account..</param>
        /// <param name="systemMaxJobCount">the system defined maximum
        /// supported jobs running under the account at the same time, which
        /// restricts the maximum number of running jobs the user can set for
        /// the account.</param>
        /// <param name="storageAccounts">the list of Azure Blob storage
        /// accounts associated with this account.</param>
        /// <param name="creationTime">the account creation time.</param>
        /// <param name="lastModifiedTime">the account last modified
        /// time.</param>
        /// <param name="endpoint">the full CName endpoint for this
        /// account.</param>
        public DataLakeAnalyticsAccount(string location, string defaultDataLakeStoreAccount, IList<DataLakeStoreAccountInfo> dataLakeStoreAccounts, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), DataLakeAnalyticsAccountStatus? provisioningState = default(DataLakeAnalyticsAccountStatus?), DataLakeAnalyticsAccountState? state = default(DataLakeAnalyticsAccountState?), int? maxDegreeOfParallelism = default(int?), int? queryStoreRetention = default(int?), int? maxJobCount = default(int?), int? systemMaxDegreeOfParallelism = default(int?), int? systemMaxJobCount = default(int?), IList<StorageAccountInfo> storageAccounts = default(IList<StorageAccountInfo>), DateTime? creationTime = default(DateTime?), DateTime? lastModifiedTime = default(DateTime?), string endpoint = default(string))
            : base(location, id, name, type, tags)
        {
            ProvisioningState = provisioningState;
            State = state;
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            QueryStoreRetention = queryStoreRetention;
            MaxJobCount = maxJobCount;
            SystemMaxDegreeOfParallelism = systemMaxDegreeOfParallelism;
            SystemMaxJobCount = systemMaxJobCount;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            StorageAccounts = storageAccounts;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Endpoint = endpoint;
        }

        /// <summary>
        /// Gets the provisioning status of the Data Lake Analytics account.
        /// Possible values include: 'Failed', 'Creating', 'Running',
        /// 'Succeeded', 'Patching', 'Suspending', 'Resuming', 'Deleting',
        /// 'Deleted'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public DataLakeAnalyticsAccountStatus? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the state of the Data Lake Analytics account. Possible values
        /// include: 'Active', 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public DataLakeAnalyticsAccountState? State { get; private set; }

        /// <summary>
        /// Gets or sets the default data lake storage account associated with
        /// this Data Lake Analytics account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDataLakeStoreAccount")]
        public string DefaultDataLakeStoreAccount { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelism")]
        public int? MaxDegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the number of days that job metadata is retained.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStoreRetention")]
        public int? QueryStoreRetention { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported jobs running under the account
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets the system defined maximum supported degree of parallelism
        /// for this account, which restricts the maximum value of
        /// parallelism the user can set for the account..
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemMaxDegreeOfParallelism")]
        public int? SystemMaxDegreeOfParallelism { get; private set; }

        /// <summary>
        /// Gets the system defined maximum supported jobs running under the
        /// account at the same time, which restricts the maximum number of
        /// running jobs the user can set for the account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.systemMaxJobCount")]
        public int? SystemMaxJobCount { get; private set; }

        /// <summary>
        /// Gets or sets the list of Data Lake storage accounts associated
        /// with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataLakeStoreAccounts")]
        public IList<DataLakeStoreAccountInfo> DataLakeStoreAccounts { get; set; }

        /// <summary>
        /// Gets or sets the list of Azure Blob storage accounts associated
        /// with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<StorageAccountInfo> StorageAccounts { get; set; }

        /// <summary>
        /// Gets the account creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the account last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the full CName endpoint for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DefaultDataLakeStoreAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DefaultDataLakeStoreAccount");
            }
            if (DataLakeStoreAccounts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataLakeStoreAccounts");
            }
            if (this.MaxDegreeOfParallelism < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelism", 1);
            }
            if (this.QueryStoreRetention > 180)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "QueryStoreRetention", 180);
            }
            if (this.QueryStoreRetention < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "QueryStoreRetention", 1);
            }
            if (this.MaxJobCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxJobCount", 1);
            }
            if (this.DataLakeStoreAccounts != null)
            {
                foreach (var element in this.DataLakeStoreAccounts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.StorageAccounts != null)
            {
                foreach (var element1 in this.StorageAccounts)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
