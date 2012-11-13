using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage.Blob;

namespace AzureBlobDemo
{
    public class BlobTreeNode : TreeNode
    {
        public BlobTreeNode(ICloudBlob blob)
        {
            Blob = blob;

            ImageKey = "Blob";
            SelectedImageKey = "Blob";
            Text = blob.Name;
        }

        public ICloudBlob Blob { get; set; }
    }
}
