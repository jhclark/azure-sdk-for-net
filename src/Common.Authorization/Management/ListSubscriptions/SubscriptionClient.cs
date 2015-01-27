// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Hyak.Common;
using System;
using System.Net.Http;

namespace Microsoft.WindowsAzure.Subscriptions
{
    public partial class SubscriptionClient : ServiceClient<SubscriptionClient>, ISubscriptionClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private CloudCredentials _credentials;
        
        /// <summary>
        /// Credentials used to authenticate requests.
        /// </summary>
        public CloudCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private ISubscriptionOperations _subscriptions;
        
        public virtual ISubscriptionOperations Subscriptions
        {
            get { return this._subscriptions; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionClient class.
        /// </summary>
        public SubscriptionClient()
            : base()
        {
            this._subscriptions = new SubscriptionOperations(this);
            this._apiVersion = "2013-08-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials used to authenticate requests.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public SubscriptionClient(CloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials used to authenticate requests.
        /// </param>
        public SubscriptionClient(CloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SubscriptionClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._subscriptions = new SubscriptionOperations(this);
            this._apiVersion = "2013-08-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials used to authenticate requests.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SubscriptionClient(CloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SubscriptionClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials used to authenticate requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SubscriptionClient(CloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// SubscriptionClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of SubscriptionClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<SubscriptionClient> client)
        {
            base.Clone(client);
            
            if (client is SubscriptionClient)
            {
                SubscriptionClient clonedClient = ((SubscriptionClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}