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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute
{
    /// <summary>
    /// The Service Management API includes operations for managing the hosted
    /// services beneath your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460812.aspx for
    /// more information)
    /// </summary>
    public partial interface IHostedServiceOperations
    {
        /// <summary>
        /// The Add Extension operation adds an available extension to your
        /// cloud service. In Azure, a process can run as an extension of a
        /// cloud service. For example, Remote Desktop Access or the Azure
        /// Diagnostics Agent can run as extensions to the cloud service. You
        /// can find the available extension by using the List Available
        /// Extensions operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169558.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Add Extension operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> AddExtensionAsync(string serviceName, HostedServiceAddExtensionParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Adding Extension operation adds an available extension to
        /// your cloud service. In Azure, a process can run as an extension of
        /// a cloud service. For example, Remote Desktop Access or the Azure
        /// Diagnostics Agent can run as extensions to the cloud service. You
        /// can find the available extension by using the List Available
        /// Extensions operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169558.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Adding Extension operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> BeginAddingExtensionAsync(string serviceName, HostedServiceAddExtensionParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete All Hosted Service operation deletes the specified cloud
        /// service and its disks from Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg441305.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> BeginDeletingAllAsync(string serviceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Deleting Extension operation deletes the specified
        /// extension from a cloud service.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169560.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='extensionId'>
        /// The identifier that was assigned to the extension when it was added
        /// to the cloud service
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> BeginDeletingExtensionAsync(string serviceName, string extensionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Check Hosted Service Name Availability operation checks for the
        /// availability of the specified cloud service name.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj154116.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The cloud service name that you would like to use.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Check Hosted Service Name Availability operation response.
        /// </returns>
        Task<HostedServiceCheckNameAvailabilityResponse> CheckNameAvailabilityAsync(string serviceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Create Hosted Service operation creates a new cloud service in
        /// Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg441304.aspx
        /// for more information)
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Hosted Service operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CreateAsync(HostedServiceCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Hosted Service operation deletes the specified cloud
        /// service from Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg441305.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string serviceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete All Hosted Service operation deletes the specified cloud
        /// service and its disks from Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg441305.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteAllAsync(string serviceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Extension operation deletes the specified extension from
        /// a cloud service.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169560.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='extensionId'>
        /// The identifier that was assigned to the extension when it was added
        /// to the cloud service
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteExtensionAsync(string serviceName, string extensionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Hosted Service Properties operation retrieves system
        /// properties for the specified cloud service. These properties
        /// include the service name and service type; and the name of the
        /// affinity group to which the service belongs, or its location if it
        /// is not part of an affinity group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460806.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Hosted Service operation response.
        /// </returns>
        Task<HostedServiceGetResponse> GetAsync(string serviceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Detailed Hosted Service Properties operation retrieves
        /// system properties for the specified cloud service. These
        /// properties include the service name and service type; the name of
        /// the affinity group to which the service belongs, or its location
        /// if it is not part of an affinity group; and information on the
        /// deployments of the service.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460806.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The detailed Get Hosted Service operation response.
        /// </returns>
        Task<HostedServiceGetDetailedResponse> GetDetailedAsync(string serviceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Extension operation retrieves information about a specified
        /// extension that was added to a cloud service.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169557.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='extensionId'>
        /// The identifier that was assigned to the extension when it was added
        /// to the cloud service
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Extension operation response.
        /// </returns>
        Task<HostedServiceGetExtensionResponse> GetExtensionAsync(string serviceName, string extensionId, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Hosted Services operation lists the cloud services
        /// available under the current subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460781.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Hosted Service operation response.
        /// </returns>
        Task<HostedServiceListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Available Extensions operation lists the extensions that
        /// are available to add to your cloud service. In Windows Azure, a
        /// process can run as an extension of a cloud service. For example,
        /// Remote Desktop Access or the Azure Diagnostics Agent can run as
        /// extensions to the cloud service.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169559.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Available Extensions operation response.
        /// </returns>
        Task<HostedServiceListAvailableExtensionsResponse> ListAvailableExtensionsAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Extensions operation lists all of the extensions that were
        /// added to a cloud service.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn169561.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Extensions operation response.
        /// </returns>
        Task<HostedServiceListExtensionsResponse> ListExtensionsAsync(string serviceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Extension Versions operation lists the versions of an
        /// extension that are available to add to a cloud service. In Azure,
        /// a process can run as an extension of a cloud service. For example,
        /// Remote Desktop Access or the Azure Diagnostics Agent can run as
        /// extensions to the cloud service.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn495437.aspx
        /// for more information)
        /// </summary>
        /// <param name='providerNamespace'>
        /// The provider namespace.
        /// </param>
        /// <param name='extensionType'>
        /// The extension type name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Available Extensions operation response.
        /// </returns>
        Task<HostedServiceListAvailableExtensionsResponse> ListExtensionVersionsAsync(string providerNamespace, string extensionType, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Update Hosted Service operation can update the label or
        /// description of a cloud service in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg441303.aspx
        /// for more information)
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the cloud service.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Hosted Service operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateAsync(string serviceName, HostedServiceUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
