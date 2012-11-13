using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using System;
using System.Threading;

namespace AzureQueueSubscriberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Azure Queue Subscriber");
            Console.WriteLine();

             // Create storage account...
            var storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create queue client...
            var queueClient = storageAccount.CreateCloudQueueClient();

            // Create queue reference...
            var queueRef = queueClient.GetQueueReference("demo");

            // Make sure the queue exists...
            queueRef.CreateIfNotExists();

            while (true)
            {
                // Get the message...

                if (message == null)
                    Console.WriteLine("No Message Available.");
                else
                {
                    Console.WriteLine("Received Message [{0}].", message.AsString);

                    // Delete the message...

                    Console.WriteLine("Deleted Message [{0}].", message.AsString);
                }

                Thread.Sleep(100);
            }
        }
    }
}
