// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WebhookOperations.
    /// </summary>
    public static partial class WebhookOperationsExtensions
    {
            /// <summary>
            /// Generates a Uri for use in creating a webhook.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            public static string GenerateUri(this IWebhookOperations operations, string automationAccountName)
            {
                return operations.GenerateUriAsync(automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a Uri for use in creating a webhook.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GenerateUriAsync(this IWebhookOperations operations, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerateUriWithHttpMessagesAsync(automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the webhook by name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            public static void Delete(this IWebhookOperations operations, string automationAccountName, string webhookName)
            {
                operations.DeleteAsync(automationAccountName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the webhook by name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IWebhookOperations operations, string automationAccountName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(automationAccountName, webhookName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve the webhook identified by webhook name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            public static Webhook Get(this IWebhookOperations operations, string automationAccountName, string webhookName)
            {
                return operations.GetAsync(automationAccountName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the webhook identified by webhook name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Webhook> GetAsync(this IWebhookOperations operations, string automationAccountName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(automationAccountName, webhookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create the webhook identified by webhook name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            /// <param name='parameters'>
            /// The create or update parameters for webhook.
            /// </param>
            public static Webhook CreateOrUpdate(this IWebhookOperations operations, string automationAccountName, string webhookName, WebhookCreateOrUpdateParameters parameters)
            {
                return operations.CreateOrUpdateAsync(automationAccountName, webhookName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create the webhook identified by webhook name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            /// <param name='parameters'>
            /// The create or update parameters for webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Webhook> CreateOrUpdateAsync(this IWebhookOperations operations, string automationAccountName, string webhookName, WebhookCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(automationAccountName, webhookName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the webhook identified by webhook name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            /// <param name='parameters'>
            /// The update parameters for webhook.
            /// </param>
            public static Webhook Update(this IWebhookOperations operations, string automationAccountName, string webhookName, WebhookUpdateParameters parameters)
            {
                return operations.UpdateAsync(automationAccountName, webhookName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the webhook identified by webhook name.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='webhookName'>
            /// The webhook name.
            /// </param>
            /// <param name='parameters'>
            /// The update parameters for webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Webhook> UpdateAsync(this IWebhookOperations operations, string automationAccountName, string webhookName, WebhookUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(automationAccountName, webhookName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of webhooks.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<Webhook> ListByAutomationAccount(this IWebhookOperations operations, string automationAccountName, string filter = default(string))
            {
                return operations.ListByAutomationAccountAsync(automationAccountName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of webhooks.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Webhook>> ListByAutomationAccountAsync(this IWebhookOperations operations, string automationAccountName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(automationAccountName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of webhooks.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Webhook> ListByAutomationAccountNext(this IWebhookOperations operations, string nextPageLink)
            {
                return operations.ListByAutomationAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of webhooks.
            /// <see href="http://aka.ms/azureautomationsdk/webhookoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Webhook>> ListByAutomationAccountNextAsync(this IWebhookOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
