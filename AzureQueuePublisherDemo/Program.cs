using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;

namespace AzureQueuePublisherDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int processId = Process.GetCurrentProcess().Id;

            Console.WriteLine("Azure Queue Publisher");
            Console.WriteLine("Process ID: [{0}]", processId);
            Console.WriteLine();

            // Create storage account...
            CloudStorageAccount storageAccount =
                CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create queue client...
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Create queue reference...
            CloudQueue queueRef = queueClient.GetQueueReference("demo");

            // Make sure the queue exists...
            queueRef.CreateIfNotExist();

            int messageId = 0;

            while (true)
            {
                string message = String.Format("{0}:{1}", processId, messageId++);

                Console.WriteLine("Sending Message [{0}]...", message);

                // Send a new message to the queue...
                queueRef.AddMessage(new CloudQueueMessage(message));

                Thread.Sleep(100);
            }
        }
    }
}