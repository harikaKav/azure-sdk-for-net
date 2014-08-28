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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// Contains the operation to create restore requests for Azure SQL
    /// Databases.
    /// </summary>
    internal partial class RestoreDatabaseOperations : IServiceOperations<SqlManagementClient>, Microsoft.WindowsAzure.Management.Sql.IRestoreDatabaseOperations
    {
        /// <summary>
        /// Initializes a new instance of the RestoreDatabaseOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal RestoreDatabaseOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Issues a restore request for an Azure SQL Database.
        /// </summary>
        /// <param name='sourceServerName'>
        /// Required. The name of the Azure SQL Database Server where the
        /// source database is, or was, hosted.
        /// </param>
        /// <param name='parameters'>
        /// Required. Additional parameters for the Create Restore Database
        /// Operation request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Contains the response to the Create Restore Database Operation
        /// request.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Sql.Models.RestoreDatabaseOperationCreateResponse> CreateAsync(string sourceServerName, RestoreDatabaseOperationCreateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (sourceServerName == null)
            {
                throw new ArgumentNullException("sourceServerName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.SourceDatabaseName == null)
            {
                throw new ArgumentNullException("parameters.SourceDatabaseName");
            }
            if (parameters.TargetDatabaseName == null)
            {
                throw new ArgumentNullException("parameters.TargetDatabaseName");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("sourceServerName", sourceServerName);
                tracingParameters.Add("parameters", parameters);
                Tracing.Enter(invocationId, this, "CreateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId != null ? this.Client.Credentials.SubscriptionId.Trim() : "") + "/services/sqlservers/servers/" + sourceServerName.Trim() + "/restoredatabaseoperations";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                XDocument requestDoc = new XDocument();
                
                XElement serviceResourceElement = new XElement(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure"));
                requestDoc.Add(serviceResourceElement);
                
                XElement sourceDatabaseNameElement = new XElement(XName.Get("SourceDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                sourceDatabaseNameElement.Value = parameters.SourceDatabaseName;
                serviceResourceElement.Add(sourceDatabaseNameElement);
                
                if (parameters.SourceDatabaseDeletionDate != null)
                {
                    XElement sourceDatabaseDeletionDateElement = new XElement(XName.Get("SourceDatabaseDeletionDate", "http://schemas.microsoft.com/windowsazure"));
                    sourceDatabaseDeletionDateElement.Value = string.Format(CultureInfo.InvariantCulture, "{0:O}", parameters.SourceDatabaseDeletionDate.Value.ToUniversalTime());
                    serviceResourceElement.Add(sourceDatabaseDeletionDateElement);
                }
                
                if (parameters.TargetServerName != null)
                {
                    XElement targetServerNameElement = new XElement(XName.Get("TargetServerName", "http://schemas.microsoft.com/windowsazure"));
                    targetServerNameElement.Value = parameters.TargetServerName;
                    serviceResourceElement.Add(targetServerNameElement);
                }
                
                XElement targetDatabaseNameElement = new XElement(XName.Get("TargetDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                targetDatabaseNameElement.Value = parameters.TargetDatabaseName;
                serviceResourceElement.Add(targetDatabaseNameElement);
                
                if (parameters.PointInTime != null)
                {
                    XElement targetUtcPointInTimeElement = new XElement(XName.Get("TargetUtcPointInTime", "http://schemas.microsoft.com/windowsazure"));
                    targetUtcPointInTimeElement.Value = string.Format(CultureInfo.InvariantCulture, "{0:O}", parameters.PointInTime.Value.ToUniversalTime());
                    serviceResourceElement.Add(targetUtcPointInTimeElement);
                }
                
                requestContent = requestDoc.ToString();
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/xml");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Created)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RestoreDatabaseOperationCreateResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new RestoreDatabaseOperationCreateResponse();
                    XDocument responseDoc = XDocument.Parse(responseContent);
                    
                    XElement serviceResourceElement2 = responseDoc.Element(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure"));
                    if (serviceResourceElement2 != null)
                    {
                        RestoreDatabaseOperation serviceResourceInstance = new RestoreDatabaseOperation();
                        result.Operation = serviceResourceInstance;
                        
                        XElement requestIDElement = serviceResourceElement2.Element(XName.Get("RequestID", "http://schemas.microsoft.com/windowsazure"));
                        if (requestIDElement != null)
                        {
                            string requestIDInstance = requestIDElement.Value;
                            serviceResourceInstance.Id = requestIDInstance;
                        }
                        
                        XElement sourceDatabaseNameElement2 = serviceResourceElement2.Element(XName.Get("SourceDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                        if (sourceDatabaseNameElement2 != null)
                        {
                            string sourceDatabaseNameInstance = sourceDatabaseNameElement2.Value;
                            serviceResourceInstance.SourceDatabaseName = sourceDatabaseNameInstance;
                        }
                        
                        XElement sourceDatabaseDeletionDateElement2 = serviceResourceElement2.Element(XName.Get("SourceDatabaseDeletionDate", "http://schemas.microsoft.com/windowsazure"));
                        if (sourceDatabaseDeletionDateElement2 != null && string.IsNullOrEmpty(sourceDatabaseDeletionDateElement2.Value) == false)
                        {
                            DateTime sourceDatabaseDeletionDateInstance = DateTime.Parse(sourceDatabaseDeletionDateElement2.Value, CultureInfo.InvariantCulture);
                            serviceResourceInstance.SourceDatabaseDeletionDate = sourceDatabaseDeletionDateInstance;
                        }
                        
                        XElement targetServerNameElement2 = serviceResourceElement2.Element(XName.Get("TargetServerName", "http://schemas.microsoft.com/windowsazure"));
                        if (targetServerNameElement2 != null)
                        {
                            string targetServerNameInstance = targetServerNameElement2.Value;
                            serviceResourceInstance.TargetServerName = targetServerNameInstance;
                        }
                        
                        XElement targetDatabaseNameElement2 = serviceResourceElement2.Element(XName.Get("TargetDatabaseName", "http://schemas.microsoft.com/windowsazure"));
                        if (targetDatabaseNameElement2 != null)
                        {
                            string targetDatabaseNameInstance = targetDatabaseNameElement2.Value;
                            serviceResourceInstance.TargetDatabaseName = targetDatabaseNameInstance;
                        }
                        
                        XElement targetUtcPointInTimeElement2 = serviceResourceElement2.Element(XName.Get("TargetUtcPointInTime", "http://schemas.microsoft.com/windowsazure"));
                        if (targetUtcPointInTimeElement2 != null)
                        {
                            DateTime targetUtcPointInTimeInstance = DateTime.Parse(targetUtcPointInTimeElement2.Value, CultureInfo.InvariantCulture);
                            serviceResourceInstance.PointInTime = targetUtcPointInTimeInstance;
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
