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

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataLake.AnalyticsJob;
using Microsoft.Azure.Management.DataLake.AnalyticsJob.Models;

namespace Microsoft.Azure.Management.DataLake.AnalyticsJob
{
    /// <summary>
    /// Creates an Azure Data Lake Analytics job management client.
    /// </summary>
    public partial class DataLakeAnalyticsJobManagementClient : ServiceClient<DataLakeAnalyticsJobManagementClient>, IDataLakeAnalyticsJobManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private string _jobServiceUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public string JobServiceUri
        {
            get { return this._jobServiceUri; }
            set { this._jobServiceUri = value; }
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
        
        private string _userAgentSuffix;
        
        /// <summary>
        /// Gets or sets the additional UserAgent text to be added to the user
        /// agent header. This is used to further differentiate where requests
        /// are coming from internally.
        /// </summary>
        public string UserAgentSuffix
        {
            get { return this._userAgentSuffix; }
            set { this._userAgentSuffix = value; }
        }
        
        private IJobOperations _jobs;
        
        /// <summary>
        /// Operations for submitting and cancelling Data Lake Analytics jobs
        /// and retrieving their status and history
        /// </summary>
        public virtual IJobOperations Jobs
        {
            get { return this._jobs; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsJobManagementClient class.
        /// </summary>
        public DataLakeAnalyticsJobManagementClient()
            : base()
        {
            this._jobs = new JobOperations(this);
            this._userAgentSuffix = "";
            this._apiVersion = "2015-10-01-preview";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsJobManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='jobServiceUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public DataLakeAnalyticsJobManagementClient(SubscriptionCloudCredentials credentials, string jobServiceUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (jobServiceUri == null)
            {
                throw new ArgumentNullException("jobServiceUri");
            }
            this._credentials = credentials;
            this._jobServiceUri = jobServiceUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsJobManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public DataLakeAnalyticsJobManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._jobServiceUri = "azuredatalakeanalytics.net";
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsJobManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsJobManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._jobs = new JobOperations(this);
            this._userAgentSuffix = "";
            this._apiVersion = "2015-10-01-preview";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsJobManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='jobServiceUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsJobManagementClient(SubscriptionCloudCredentials credentials, string jobServiceUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (jobServiceUri == null)
            {
                throw new ArgumentNullException("jobServiceUri");
            }
            this._credentials = credentials;
            this._jobServiceUri = jobServiceUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsJobManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public DataLakeAnalyticsJobManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._jobServiceUri = "azuredatalakeanalytics.net";
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// DataLakeAnalyticsJobManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of DataLakeAnalyticsJobManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<DataLakeAnalyticsJobManagementClient> client)
        {
            base.Clone(client);
            
            if (client is DataLakeAnalyticsJobManagementClient)
            {
                DataLakeAnalyticsJobManagementClient clonedClient = ((DataLakeAnalyticsJobManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._userAgentSuffix = this._userAgentSuffix;
                clonedClient._jobServiceUri = this._jobServiceUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
        
        /// <summary>
        /// Parse enum values for type JobResult.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobResult ParseJobResult(string value)
        {
            if ("None".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobResult.None;
            }
            if ("Succeeded".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobResult.Succeeded;
            }
            if ("Cancelled".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobResult.Cancelled;
            }
            if ("Failed".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobResult.Failed;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobResult to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobResultToString(JobResult value)
        {
            if (value == JobResult.None)
            {
                return "None";
            }
            if (value == JobResult.Succeeded)
            {
                return "Succeeded";
            }
            if (value == JobResult.Cancelled)
            {
                return "Cancelled";
            }
            if (value == JobResult.Failed)
            {
                return "Failed";
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Parse enum values for type JobState.
        /// </summary>
        /// <param name='value'>
        /// The value to parse.
        /// </param>
        /// <returns>
        /// The enum value.
        /// </returns>
        internal static JobState ParseJobState(string value)
        {
            if ("Accepted".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Accepted;
            }
            if ("Compiling".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Compiling;
            }
            if ("Ended".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Ended;
            }
            if ("New".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.New;
            }
            if ("Queued".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Queued;
            }
            if ("Running".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Running;
            }
            if ("Scheduling".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Scheduling;
            }
            if ("Starting".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Starting;
            }
            if ("Paused".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.Paused;
            }
            if ("WaitingForCapacity".Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                return JobState.WaitingForCapacity;
            }
            throw new ArgumentOutOfRangeException("value");
        }
        
        /// <summary>
        /// Convert an enum of type JobState to a string.
        /// </summary>
        /// <param name='value'>
        /// The value to convert to a string.
        /// </param>
        /// <returns>
        /// The enum value as a string.
        /// </returns>
        internal static string JobStateToString(JobState value)
        {
            if (value == JobState.Accepted)
            {
                return "Accepted";
            }
            if (value == JobState.Compiling)
            {
                return "Compiling";
            }
            if (value == JobState.Ended)
            {
                return "Ended";
            }
            if (value == JobState.New)
            {
                return "New";
            }
            if (value == JobState.Queued)
            {
                return "Queued";
            }
            if (value == JobState.Running)
            {
                return "Running";
            }
            if (value == JobState.Scheduling)
            {
                return "Scheduling";
            }
            if (value == JobState.Starting)
            {
                return "Starting";
            }
            if (value == JobState.Paused)
            {
                return "Paused";
            }
            if (value == JobState.WaitingForCapacity)
            {
                return "WaitingForCapacity";
            }
            throw new ArgumentOutOfRangeException("value");
        }
    }
}
