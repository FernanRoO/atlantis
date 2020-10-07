using System;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace atlantis.Jobs
{
    public static class MessagesQueueTrigger
    {
        [FunctionName("MessagesQueueTrigger")]
        public static void Run([QueueTrigger("messages", Connection = "AzureWebJobsStorage")]CloudQueueMessage myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem.AsString}, dequeued {myQueueItem.DequeueCount} times...");
        }
    }
}
