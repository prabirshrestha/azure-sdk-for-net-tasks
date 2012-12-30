namespace AzureStorageClientTaskExtensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.WindowsAzure.StorageClient;

    internal static class StorageClientTaskExtensions
    {
        #region CloudQueue

        public static Task CreateAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginCreate, cloudQueue.EndCreate, null);
        }

        public static Task CreateAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.ClearAsync(null);
        }

        public static Task<bool> CreateIfNotExistAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync<bool>(cloudQueue.BeginCreateIfNotExist, cloudQueue.EndCreateIfNotExist, state);
        }

        public static Task<bool> CreateIfNotExistAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.CreateIfNotExistAsync(null);
        }

        public static Task DeleteAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginDelete, cloudQueue.EndDelete, state);
        }

        public static Task DeleteAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.DeleteAsync(null);
        }

        public static Task<bool> ExistsAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync<bool>(cloudQueue.BeginExists, cloudQueue.EndExists, state);
        }

        public static Task<bool> ExistsAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.ExistsAsync(null);
        }

        public static Task FetchAttributesAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginFetchAttributes, cloudQueue.EndFetchAttributes, state);
        }

        public static Task FetchAttributesAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.FetchAttributesAsync(null);
        }

        public static Task SetMetadataAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginSetMetadata, cloudQueue.EndSetMetadata, state);
        }

        public static Task SetMetadataAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.SetMetadataAsync(null);
        }

        public static Task AddMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginAddMessage, cloudQueue.EndAddMessage, message, state);
        }

        public static Task AddMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message)
        {
            return cloudQueue.AddMessageAsync(message, null);
        }

        public static Task AddMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message, TimeSpan timeToLive, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginAddMessage, cloudQueue.EndAddMessage, message, timeToLive, state);
        }

        public static Task AddMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message, TimeSpan timeToLive)
        {
            return cloudQueue.AddMessageAsync(message, timeToLive, null);
        }

        public static Task AddMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message, TimeSpan? timeToLive, TimeSpan? initialVisibilityDelay, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginAddMessage, cloudQueue.EndAddMessage, message, timeToLive, initialVisibilityDelay, state);
        }

        public static Task<CloudQueueMessage> PeekMessageAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync<CloudQueueMessage>(cloudQueue.BeginPeekMessage, cloudQueue.EndPeekMessage, state);
        }

        public static Task<CloudQueueMessage> PeekMessageAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.PeekMessageAsync(null);
        }

        public static Task<IEnumerable<CloudQueueMessage>> PeekMessagesAsync(this CloudQueue cloudQueue, int messageCount, object state)
        {
            return Task.Factory.FromAsync<int, IEnumerable<CloudQueueMessage>>(cloudQueue.BeginPeekMessages, cloudQueue.EndPeekMessages, messageCount, state);
        }

        public static Task<IEnumerable<CloudQueueMessage>> PeekMessagesAsync(this CloudQueue cloudQueue, int messageCount)
        {
            return cloudQueue.PeekMessagesAsync(messageCount, null);
        }

        public static Task ClearAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginClear, cloudQueue.EndClear, state);
        }

        public static Task ClearAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.ClearAsync(null);
        }

        public static Task<CloudQueueMessage> GetMessageAsync(this CloudQueue cloudQueue, object state)
        {
            return Task.Factory.FromAsync<CloudQueueMessage>(cloudQueue.BeginGetMessage, cloudQueue.EndGetMessage, state);
        }

        public static Task<CloudQueueMessage> GetMessageAsync(this CloudQueue cloudQueue)
        {
            return cloudQueue.GetMessageAsync(null);
        }

        public static Task<CloudQueueMessage> GetMessageAsync(this CloudQueue cloudQueue, TimeSpan visibilityTimeout, object state)
        {
            return Task.Factory.FromAsync<TimeSpan, CloudQueueMessage>(cloudQueue.BeginGetMessage, cloudQueue.EndGetMessage, visibilityTimeout, state);
        }

        public static Task<CloudQueueMessage> GetMessageAsync(this CloudQueue cloudQueue, TimeSpan visibilityTimeout)
        {
            return cloudQueue.GetMessageAsync(visibilityTimeout, null);
        }

        public static Task<IEnumerable<CloudQueueMessage>> GetMessagesAsync(this CloudQueue cloudQueue, int messageCount, object state)
        {
            return Task.Factory.FromAsync<int, IEnumerable<CloudQueueMessage>>(cloudQueue.BeginGetMessages, cloudQueue.EndGetMessages, messageCount, state);
        }

        public static Task<IEnumerable<CloudQueueMessage>> GetMessagesAsync(this CloudQueue cloudQueue, int messageCount)
        {
            return cloudQueue.GetMessagesAsync(messageCount, null);
        }

        public static Task<IEnumerable<CloudQueueMessage>> GetMessagesAsync(this CloudQueue cloudQueue, int messageCount, TimeSpan visibilityTimeout, object state)
        {
            return Task.Factory.FromAsync<int, TimeSpan, IEnumerable<CloudQueueMessage>>(cloudQueue.BeginGetMessages, cloudQueue.EndGetMessages, messageCount, visibilityTimeout, state);
        }

        public static Task<IEnumerable<CloudQueueMessage>> GetMessagesAsync(this CloudQueue cloudQueue, int messageCount, TimeSpan visibilityTimeout)
        {
            return cloudQueue.GetMessagesAsync(messageCount, visibilityTimeout, null);
        }

        public static Task UpdateMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message, TimeSpan visibilityTimeout, MessageUpdateFields updateFields, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginUpdateMessage, cloudQueue.EndUpdateMessage, message, visibilityTimeout, updateFields, state);
        }

        public static Task UpdateMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message, TimeSpan visibilityTimeout, MessageUpdateFields updateFields)
        {
            return cloudQueue.UpdateMessageAsync(message, visibilityTimeout, updateFields, null);
        }

        public static Task DeleteMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginDeleteMessage, cloudQueue.EndDeleteMessage, message, state);
        }

        public static Task DeleteMessageAsync(this CloudQueue cloudQueue, CloudQueueMessage message)
        {
            return cloudQueue.DeleteMessageAsync(message, null);
        }

        public static Task DeleteMessageAsync(this CloudQueue cloudQueue, string messageId, string popReceipt, object state)
        {
            return Task.Factory.FromAsync(cloudQueue.BeginDeleteMessage, cloudQueue.EndDeleteMessage, messageId, popReceipt, state);
        }

        public static Task DeleteMessageAsync(this CloudQueue cloudQueue, string messageId, string popReceipt)
        {
            return cloudQueue.DeleteMessageAsync(messageId, popReceipt, null);
        }

        #endregion

        #region CloudBlobContainer

        public static Task<bool> CreateIfNotExistAsync(this CloudBlobContainer cloudBlobContainer, object state)
        {
            return Task.Factory.FromAsync<bool>(cloudBlobContainer.BeginCreateIfNotExist, cloudBlobContainer.EndCreateIfNotExist, state);
        }

        public static Task<bool> CreateIfNotExistAsync(this CloudBlobContainer cloudBlobContainer)
        {
            return cloudBlobContainer.CreateIfNotExistAsync(null);
        }

        public static Task SetPermissionsAsync(this CloudBlobContainer cloudBlobContainer, BlobContainerPermissions permissions)
        {
            return Task.Factory.FromAsync(cloudBlobContainer.BeginSetPermissions, cloudBlobContainer.EndSetPermissions, permissions, null);
        }

        public static Task SetPermissionsAsync(this CloudBlobContainer cloudBlobContainer, BlobContainerPermissions permissions, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync(cloudBlobContainer.BeginSetPermissions, cloudBlobContainer.EndSetPermissions, permissions, options, state);
        }

        public static Task SetPermissionsAsync(this CloudBlobContainer cloudBlobContainer, BlobContainerPermissions permissions, BlobRequestOptions options)
        {
            return cloudBlobContainer.SetPermissionsAsync(permissions, options, null);
        }

        public static Task<ResultSegment<IListBlobItem>> ListBlobsSegmentedAsync(this CloudBlobContainer cloudBlobContainer, int maxResults, ResultContinuation continuationToken, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync<int, ResultContinuation, BlobRequestOptions, ResultSegment<IListBlobItem>>(cloudBlobContainer.BeginListBlobsSegmented, cloudBlobContainer.EndListBlobsSegmented, maxResults, continuationToken, options, state);
        }

        public static Task<ResultSegment<IListBlobItem>> ListBlobsSegmentedAsync(this CloudBlobContainer cloudBlobContainer, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync<BlobRequestOptions, ResultSegment<IListBlobItem>>(cloudBlobContainer.BeginListBlobsSegmented, cloudBlobContainer.EndListBlobsSegmented, options, state);
        }

        public static Task<ResultSegment<IListBlobItem>> ListBlobsSegmentedAsync(this CloudBlobContainer cloudBlobContainer, object state)
        {
            return Task.Factory.FromAsync<ResultSegment<IListBlobItem>>(cloudBlobContainer.BeginListBlobsSegmented, cloudBlobContainer.EndListBlobsSegmented, state);
        }

        public static Task DeleteAsync(this CloudBlobContainer cloudBlobContainer, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync(cloudBlobContainer.BeginDelete, cloudBlobContainer.EndDelete, options, state);
        }

        public static Task DeleteAsync(this CloudBlobContainer cloudBlobContainer, object state)
        {
            return Task.Factory.FromAsync(cloudBlobContainer.BeginDelete, cloudBlobContainer.EndDelete, state);
        }

        public static Task DeleteAsync(this CloudBlobContainer cloudBlobContainer)
        {
            return cloudBlobContainer.DeleteAsync(null);
        }

        #endregion

        #region CloudBlob

        public static Task UploadFromStreamAsync(this CloudBlob cloudBlob, Stream stream, object state)
        {
            return Task.Factory.FromAsync(cloudBlob.BeginUploadFromStream, cloudBlob.EndUploadFromStream, stream, state);
        }

        public static Task UploadFromStreamAsync(this CloudBlob cloudBlob, Stream stream)
        {
            return cloudBlob.UploadFromStreamAsync(stream, null);
        }

        public static Task UploadFromStreamAsync(this CloudBlob cloudBlob, Stream stream, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync(cloudBlob.BeginUploadFromStream, cloudBlob.EndUploadFromStream, stream, options, state);
        }

        public static Task DownloadToStreamAsync(this CloudBlob cloudBlob, Stream target, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync(cloudBlob.BeginDownloadToStream, cloudBlob.EndDownloadToStream, target, options, state);
        }

        public static Task DownloadToStreamAsync(this CloudBlob cloudBlob, Stream target, object state)
        {
            return Task.Factory.FromAsync(cloudBlob.BeginDownloadToStream, cloudBlob.EndDownloadToStream, target, state);
        }

        public static Task DownloadToStreamAsync(this CloudBlob cloudBlob, Stream target)
        {
            return cloudBlob.DownloadToStreamAsync(target, null);
        }

        public static Task DeleteAsync(this CloudBlob cloudBlob, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync(cloudBlob.BeginDelete, cloudBlob.EndDelete, options, state);
        }

        public static Task DeleteAsync(this CloudBlob cloudBlob, object state)
        {
            return Task.Factory.FromAsync(cloudBlob.BeginDelete, cloudBlob.EndDelete, state);
        }

        public static Task DeleteAsync(this CloudBlob cloudBlob)
        {
            return cloudBlob.DeleteAsync(null);
        }

        public static Task<bool> DeleteIfExistsAsync(this CloudBlob cloudBlob, BlobRequestOptions options, object state)
        {
            return Task.Factory.FromAsync<BlobRequestOptions, bool>(cloudBlob.BeginDeleteIfExists, cloudBlob.EndDeleteIfExists, options, state);
        }

        public static Task<bool> DeleteIfExistsAsync(this CloudBlob cloudBlob, object state)
        {
            return Task.Factory.FromAsync<bool>(cloudBlob.BeginDeleteIfExists, cloudBlob.EndDeleteIfExists, state);
        }

        public static Task<bool> DeleteIfExistsAsync(this CloudBlob cloudBlob)
        {
            return cloudBlob.DeleteIfExistsAsync(null);
        }

        #endregion

        #region ResultSegment<TElement>

        public static Task<ResultSegment<TElement>> GetNextAsync<TElement>(this ResultSegment<TElement> resultSegment, object state)
        {
            return Task.Factory.FromAsync<ResultSegment<TElement>>(resultSegment.BeginGetNext, resultSegment.EndGetNext, state);
        }

        public static Task<ResultSegment<TElement>> GetNextAsync<TElement>(this ResultSegment<TElement> resultSegment)
        {
            return resultSegment.GetNextAsync(null);
        }

        #endregion
    }
}