using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;
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
            queueRef.CreateIfNotExist();

            while (true)
            {
                // Get the message...
                var message = queueRef.GetMessage();

                if (message == null)
                    Console.WriteLine("No Message Available.");
                else
                {
                    Console.WriteLine("Received Message [{0}].", message.AsString);

                    // Delete the message...
                    queueRef.DeleteMessage(message);

                    Console.WriteLine("Deleted Message [{0}].", message.AsString);
                }

                Thread.Sleep(100);
            }
        }
    }
}
