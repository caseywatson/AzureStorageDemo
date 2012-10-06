using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.StorageClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace AzureBlobDemo
{
    public partial class Form1 : Form
    {
        private readonly CloudStorageAccount storageAccount;

        private TreeNode currentNode;

        public Form1()
        {
            InitializeComponent();
            
            // Create storage account...  
            storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
        }

        private new void Refresh()
        {
            blobTree.Nodes.Clear();
        }

        private void BlobTreeMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentNode = blobTree.GetNodeAt(e.X, e.Y);

                if (currentNode != null)
                {
                    if (currentNode is BlobTreeNode)
                        blobContextMenu.Show(blobTree, e.Location);
                    else if (currentNode is ContainerTreeNode)
                    {
                        CloudBlobContainer containerRef = (currentNode as ContainerTreeNode).Container;
                        BlobContainerPermissions containerPermissions = containerRef.GetPermissions();

                        privateToolStripMenuItem.Checked = (containerPermissions.PublicAccess ==
                                                            BlobContainerPublicAccessType.Off);
                        publicBlobsToolStripMenuItem.Checked = (containerPermissions.PublicAccess ==
                                                                BlobContainerPublicAccessType.Blob);
                        publicContainerToolStripMenuItem.Checked = (containerPermissions.PublicAccess ==
                                                                    BlobContainerPublicAccessType.Container);

                        containerContextMenu.Show(blobTree, e.Location);
                    }
                }
            }
        }

        private void AddContainerButtonClick(object sender, EventArgs e)
        {
            var newContainerNode = new ContainerTreeNode();

            blobTree.Nodes.Add(newContainerNode);
            newContainerNode.BeginEdit();
        }

        private void BlobTreeAfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            e.Node.EndEdit(false);
            
            // Create a new container...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(e.Label);

            containerRef.CreateIfNotExist();

            var containerNode = e.Node as ContainerTreeNode;

            if (containerNode == null)
                return;

           containerNode.Container = containerRef;
        }

        private void RefreshButtonClick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DownloadBlobToolStripMenuItemClick(object sender, EventArgs e)
        {
            var blobNode = currentNode as BlobTreeNode;

            if (blobNode == null)
                return;

            // Download blob...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(blobNode.Blob.Container.Name);
            CloudBlob blobRef = containerRef.GetBlobReference(blobNode.Text);

            downloadDialog.FileName = blobRef.Name;

            if (downloadDialog.ShowDialog() == DialogResult.OK)
                blobRef.DownloadToFile(downloadDialog.FileName);
        }

        private void UploadBlobToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Upload blob...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(containerNode.Container.Name);

            if (uploadDialog.ShowDialog() == DialogResult.OK)
            {
                CloudBlob blobRef = containerRef.GetBlobReference(Path.GetFileName(uploadDialog.FileName));

                blobRef.UploadFile(uploadDialog.FileName);

                currentNode.Nodes.Add(new BlobTreeNode(blobRef));
                currentNode.Expand();
            }
        }

        private void LoadForm(object sender, EventArgs e)
        {
            Refresh();
        }

        private void DeleteContainerToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Delete container...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(containerNode.Container.Name);

            containerRef.Delete();

            containerNode.Remove();
        }

        private void DeleteBlobToolStripMenuItemClick(object sender, EventArgs e)
        {
            var blobNode = currentNode as BlobTreeNode;

            if (blobNode == null)
                return;

            // Delete blob...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(blobNode.Blob.Container.Name);
            CloudBlob blobRef = containerRef.GetBlobReference(blobNode.Blob.Name);

            blobRef.Delete();
            blobNode.Remove();
        }

        private void PublicContainerToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Make container public...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(containerNode.Text);

            containerRef.SetPermissions(new BlobContainerPermissions
                                            {PublicAccess = BlobContainerPublicAccessType.Container});
        }

        private void PublicBlobsToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Make blobs public...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(containerNode.Text);

            containerRef.SetPermissions(new BlobContainerPermissions {PublicAccess = BlobContainerPublicAccessType.Blob});
        }

        private void PrivateToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Make container private...

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer containerRef = blobClient.GetContainerReference(containerNode.Text);

            containerRef.SetPermissions(new BlobContainerPermissions {PublicAccess = BlobContainerPublicAccessType.Off});
        }
    }
}