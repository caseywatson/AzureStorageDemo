using Microsoft.WindowsAzure.StorageClient;
using System.Windows.Forms;

namespace AzureBlobDemo
{
    public class BlobTreeNode : TreeNode
    {
        public BlobTreeNode(CloudBlob blob)
        {
            Blob = blob;

            ImageKey = "Blob";
            SelectedImageKey = "Blob";
            Text = blob.Name;
        }

        public CloudBlob Blob { get; set; }
    }
}
