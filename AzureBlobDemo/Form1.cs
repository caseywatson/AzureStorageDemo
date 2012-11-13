using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Linq;
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
        }

        private new void Refresh()
        {
            blobTree.Nodes.Clear();

            // Load all blobs...
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
        }

        private void UploadBlobToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Upload blob...
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
        }

        private void DeleteBlobToolStripMenuItemClick(object sender, EventArgs e)
        {
            var blobNode = currentNode as BlobTreeNode;

            if (blobNode == null)
                return;

            // Delete blob...
        }

        private void PublicContainerToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Make container public...
        }

        private void PublicBlobsToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Make blobs public...
        }

        private void PrivateToolStripMenuItemClick(object sender, EventArgs e)
        {
            var containerNode = currentNode as ContainerTreeNode;

            if (containerNode == null)
                return;

            // Make container private...
        }
    }
}