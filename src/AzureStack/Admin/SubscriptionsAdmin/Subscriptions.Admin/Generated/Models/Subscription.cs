// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Subscriptions.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// List of supported operations.
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        public Subscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        /// <param name="delegatedProviderSubscriptionId">Parent
        /// DelegatedProvider subscription identifier.</param>
        /// <param name="displayName">Subscription name.</param>
        /// <param name="id">Fully qualified identifier.</param>
        /// <param name="externalReferenceId">External reference
        /// identifier.</param>
        /// <param name="offerId">Identifier of the offer under the scope of a
        /// delegated provider.</param>
        /// <param name="owner">Subscription owner.</param>
        /// <param name="routingResourceManagerType">Routing resource manager
        /// type. Possible values include: 'Default', 'Admin'</param>
        /// <param name="state">Subscription state. Possible values include:
        /// 'NotDefined', 'Enabled', 'Warned', 'PastDue', 'Disabled',
        /// 'Deleted', 'Deleting', 'PartiallyDeleted'</param>
        /// <param name="subscriptionId">Subscription identifier.</param>
        /// <param name="tenantId">Directory tenant identifier.</param>
        public Subscription(string delegatedProviderSubscriptionId = default(string), string displayName = default(string), string id = default(string), string externalReferenceId = default(string), string offerId = default(string), string owner = default(string), string routingResourceManagerType = default(string), string state = default(string), string subscriptionId = default(string), string tenantId = default(string))
        {
            DelegatedProviderSubscriptionId = delegatedProviderSubscriptionId;
            DisplayName = displayName;
            Id = id;
            ExternalReferenceId = externalReferenceId;
            OfferId = offerId;
            Owner = owner;
            RoutingResourceManagerType = routingResourceManagerType;
            State = state;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parent DelegatedProvider subscription identifier.
        /// </summary>
        [JsonProperty(PropertyName = "delegatedProviderSubscriptionId")]
        public string DelegatedProviderSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets subscription name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets fully qualified identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets external reference identifier.
        /// </summary>
        [JsonProperty(PropertyName = "externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        /// <summary>
        /// Gets or sets identifier of the offer under the scope of a delegated
        /// provider.
        /// </summary>
        [JsonProperty(PropertyName = "offerId")]
        public string OfferId { get; set; }

        /// <summary>
        /// Gets or sets subscription owner.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets routing resource manager type. Possible values
        /// include: 'Default', 'Admin'
        /// </summary>
        [JsonProperty(PropertyName = "routingResourceManagerType")]
        public string RoutingResourceManagerType { get; set; }

        /// <summary>
        /// Gets or sets subscription state. Possible values include:
        /// 'NotDefined', 'Enabled', 'Warned', 'PastDue', 'Disabled',
        /// 'Deleted', 'Deleting', 'PartiallyDeleted'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets subscription identifier.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets directory tenant identifier.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

    }
}
