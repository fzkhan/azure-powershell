// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ReplicationProtectionContainerMappingsOperations
    /// </summary>
    public static partial class ReplicationProtectionContainerMappingsOperationsExtensions
    {
        /// <summary>
        /// Lists the protection container mappings for a protection container.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ProtectionContainerMapping> ListByReplicationProtectionContainers(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName)
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).ListByReplicationProtectionContainersAsync(resourceGroupName, resourceName, fabricName, protectionContainerName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the protection container mappings for a protection container.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ProtectionContainerMapping>> ListByReplicationProtectionContainersAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByReplicationProtectionContainersWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets the details of a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection Container mapping name.
        /// </param>
        public static ProtectionContainerMapping Get(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName)
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).GetAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the details of a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection Container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ProtectionContainerMapping> GetAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// The operation to create a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static ProtectionContainerMapping Create(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, CreateProtectionContainerMappingInputProperties properties = default(CreateProtectionContainerMappingInputProperties))
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).CreateAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to create a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ProtectionContainerMapping> CreateAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, CreateProtectionContainerMappingInputProperties properties = default(CreateProtectionContainerMappingInputProperties), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// The operation to purge(force delete) a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static void Purge(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName)
        {
                ((IReplicationProtectionContainerMappingsOperations)operations).PurgeAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to purge(force delete) a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task PurgeAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.PurgeWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// The operation to update protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static ProtectionContainerMapping Update(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, UpdateProtectionContainerMappingInputProperties properties = default(UpdateProtectionContainerMappingInputProperties))
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).UpdateAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to update protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ProtectionContainerMapping> UpdateAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, UpdateProtectionContainerMappingInputProperties properties = default(UpdateProtectionContainerMappingInputProperties), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// The operation to delete or remove a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static void Delete(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, RemoveProtectionContainerMappingInputProperties properties = default(RemoveProtectionContainerMappingInputProperties))
        {
                ((IReplicationProtectionContainerMappingsOperations)operations).DeleteAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to delete or remove a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, RemoveProtectionContainerMappingInputProperties properties = default(RemoveProtectionContainerMappingInputProperties), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists the protection container mappings in the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ProtectionContainerMapping> List(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName)
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).ListAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the protection container mappings in the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ProtectionContainerMapping>> ListAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// The operation to create a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static ProtectionContainerMapping BeginCreate(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, CreateProtectionContainerMappingInputProperties properties = default(CreateProtectionContainerMappingInputProperties))
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).BeginCreateAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to create a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ProtectionContainerMapping> BeginCreateAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, CreateProtectionContainerMappingInputProperties properties = default(CreateProtectionContainerMappingInputProperties), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// The operation to purge(force delete) a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static void BeginPurge(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName)
        {
                ((IReplicationProtectionContainerMappingsOperations)operations).BeginPurgeAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to purge(force delete) a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginPurgeAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginPurgeWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// The operation to update protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static ProtectionContainerMapping BeginUpdate(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, UpdateProtectionContainerMappingInputProperties properties = default(UpdateProtectionContainerMappingInputProperties))
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).BeginUpdateAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to update protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ProtectionContainerMapping> BeginUpdateAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, UpdateProtectionContainerMappingInputProperties properties = default(UpdateProtectionContainerMappingInputProperties), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// The operation to delete or remove a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        public static void BeginDelete(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, RemoveProtectionContainerMappingInputProperties properties = default(RemoveProtectionContainerMappingInputProperties))
        {
                ((IReplicationProtectionContainerMappingsOperations)operations).BeginDeleteAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The operation to delete or remove a protection container mapping.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this IReplicationProtectionContainerMappingsOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string mappingName, RemoveProtectionContainerMappingInputProperties properties = default(RemoveProtectionContainerMappingInputProperties), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, mappingName, properties, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists the protection container mappings for a protection container.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ProtectionContainerMapping> ListByReplicationProtectionContainersNext(this IReplicationProtectionContainerMappingsOperations operations, string nextPageLink)
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).ListByReplicationProtectionContainersNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the protection container mappings for a protection container.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ProtectionContainerMapping>> ListByReplicationProtectionContainersNextAsync(this IReplicationProtectionContainerMappingsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByReplicationProtectionContainersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists the protection container mappings in the vault.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<ProtectionContainerMapping> ListNext(this IReplicationProtectionContainerMappingsOperations operations, string nextPageLink)
        {
                return ((IReplicationProtectionContainerMappingsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the protection container mappings in the vault.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<ProtectionContainerMapping>> ListNextAsync(this IReplicationProtectionContainerMappingsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
