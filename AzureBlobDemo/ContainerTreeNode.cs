﻿using Microsoft.WindowsAzure.StorageClient;
using System.Linq;
using System.Windows.Forms;

namespace AzureBlobDemo
{
    public class ContainerTreeNode : TreeNode
    {
        public ContainerTreeNode()
        {
            ImageKey = "Container";
            SelectedImageKey = "Container";
            Text = "New Container";
        }

        public ContainerTreeNode(CloudBlobContainer container)
            : this()
        {
            Container = container;

            foreach (var blob in container.ListBlobs().OfType<CloudBlob>())
                Nodes.Add(new BlobTreeNode(blob));

            Text = container.Name;
        }

        public CloudBlobContainer Container { get; set; }
    }
}
