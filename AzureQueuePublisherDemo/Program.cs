using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

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

            // Create queue client...

            // Create queue reference...

            // Make sure the queue exists...

            int messageId = 0;

            while (true)
            {
                string message = String.Format("{0}:{1}", processId, messageId++);

                Console.WriteLine("Sending Message [{0}]...", message);

                // Send a new message to the queue...

                Thread.Sleep(100);
            }
        }
    }
}