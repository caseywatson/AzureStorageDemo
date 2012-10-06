namespace AzureBlobDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.blobTree = new System.Windows.Forms.TreeView();
            this.addContainerButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
            this.blobContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadBlobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.permissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicBlobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadDialog = new System.Windows.Forms.OpenFileDialog();
            this.downloadDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.blobContextMenu.SuspendLayout();
            this.containerContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContainerButton,
            this.refreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // blobTree
            // 
            this.blobTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blobTree.ImageIndex = 0;
            this.blobTree.ImageList = this.treeImageList;
            this.blobTree.LabelEdit = true;
            this.blobTree.Location = new System.Drawing.Point(0, 25);
            this.blobTree.Name = "blobTree";
            this.blobTree.SelectedImageIndex = 0;
            this.blobTree.Size = new System.Drawing.Size(284, 236);
            this.blobTree.TabIndex = 2;
            this.blobTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.BlobTreeAfterLabelEdit);
            this.blobTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BlobTreeMouseUp);
            // 
            // addContainerButton
            // 
            this.addContainerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addContainerButton.Image = ((System.Drawing.Image)(resources.GetObject("addContainerButton.Image")));
            this.addContainerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addContainerButton.Name = "addContainerButton";
            this.addContainerButton.Size = new System.Drawing.Size(23, 22);
            this.addContainerButton.Text = "toolStripButton1";
            this.addContainerButton.ToolTipText = "Add Container...";
            this.addContainerButton.Click += new System.EventHandler(this.AddContainerButtonClick);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "toolStripButton1";
            this.refreshButton.ToolTipText = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
            // 
            // treeImageList
            // 
            this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImageList.Images.SetKeyName(0, "Container");
            this.treeImageList.Images.SetKeyName(1, "Blob");
            // 
            // blobContextMenu
            // 
            this.blobContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadBlobToolStripMenuItem,
            this.deleteBlobToolStripMenuItem});
            this.blobContextMenu.Name = "blobContextMenu";
            this.blobContextMenu.Size = new System.Drawing.Size(165, 48);
            // 
            // downloadBlobToolStripMenuItem
            // 
            this.downloadBlobToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadBlobToolStripMenuItem.Image")));
            this.downloadBlobToolStripMenuItem.Name = "downloadBlobToolStripMenuItem";
            this.downloadBlobToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.downloadBlobToolStripMenuItem.Text = "Download Blob...";
            this.downloadBlobToolStripMenuItem.Click += new System.EventHandler(this.DownloadBlobToolStripMenuItemClick);
            // 
            // deleteBlobToolStripMenuItem
            // 
            this.deleteBlobToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteBlobToolStripMenuItem.Image")));
            this.deleteBlobToolStripMenuItem.Name = "deleteBlobToolStripMenuItem";
            this.deleteBlobToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteBlobToolStripMenuItem.Text = "Delete Blob";
            this.deleteBlobToolStripMenuItem.Click += new System.EventHandler(this.DeleteBlobToolStripMenuItemClick);
            // 
            // containerContextMenu
            // 
            this.containerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadBlobToolStripMenuItem,
            this.deleteContainerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.permissionsToolStripMenuItem});
            this.containerContextMenu.Name = "containerContextMenu";
            this.containerContextMenu.Size = new System.Drawing.Size(163, 76);
            // 
            // uploadBlobToolStripMenuItem
            // 
            this.uploadBlobToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uploadBlobToolStripMenuItem.Image")));
            this.uploadBlobToolStripMenuItem.Name = "uploadBlobToolStripMenuItem";
            this.uploadBlobToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.uploadBlobToolStripMenuItem.Text = "Upload Blob...";
            this.uploadBlobToolStripMenuItem.Click += new System.EventHandler(this.UploadBlobToolStripMenuItemClick);
            // 
            // deleteContainerToolStripMenuItem
            // 
            this.deleteContainerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteContainerToolStripMenuItem.Image")));
            this.deleteContainerToolStripMenuItem.Name = "deleteContainerToolStripMenuItem";
            this.deleteContainerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteContainerToolStripMenuItem.Text = "Delete Container";
            this.deleteContainerToolStripMenuItem.Click += new System.EventHandler(this.DeleteContainerToolStripMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // permissionsToolStripMenuItem
            // 
            this.permissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.publicContainerToolStripMenuItem,
            this.publicBlobsToolStripMenuItem,
            this.privateToolStripMenuItem});
            this.permissionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("permissionsToolStripMenuItem.Image")));
            this.permissionsToolStripMenuItem.Name = "permissionsToolStripMenuItem";
            this.permissionsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.permissionsToolStripMenuItem.Text = "Permissions";
            // 
            // publicContainerToolStripMenuItem
            // 
            this.publicContainerToolStripMenuItem.Name = "publicContainerToolStripMenuItem";
            this.publicContainerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.publicContainerToolStripMenuItem.Text = "Public (Container)";
            this.publicContainerToolStripMenuItem.Click += new System.EventHandler(this.PublicContainerToolStripMenuItemClick);
            // 
            // publicBlobsToolStripMenuItem
            // 
            this.publicBlobsToolStripMenuItem.Name = "publicBlobsToolStripMenuItem";
            this.publicBlobsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.publicBlobsToolStripMenuItem.Text = "Public (Blobs)";
            this.publicBlobsToolStripMenuItem.Click += new System.EventHandler(this.PublicBlobsToolStripMenuItemClick);
            // 
            // privateToolStripMenuItem
            // 
            this.privateToolStripMenuItem.Name = "privateToolStripMenuItem";
            this.privateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.privateToolStripMenuItem.Text = "Private";
            this.privateToolStripMenuItem.Click += new System.EventHandler(this.PrivateToolStripMenuItemClick);
            // 
            // uploadDialog
            // 
            this.uploadDialog.FileName = "openFileDialog1";
            this.uploadDialog.Title = "Upload Blob...";
            // 
            // downloadDialog
            // 
            this.downloadDialog.Title = "Download Blob...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.blobTree);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Azure Blob Explorer";
            this.Load += new System.EventHandler(this.LoadForm);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.blobContextMenu.ResumeLayout(false);
            this.containerContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addContainerButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.TreeView blobTree;
        private System.Windows.Forms.ImageList treeImageList;
        private System.Windows.Forms.ContextMenuStrip blobContextMenu;
        private System.Windows.Forms.ToolStripMenuItem downloadBlobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBlobToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip containerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem uploadBlobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem permissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicBlobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog uploadDialog;
        private System.Windows.Forms.SaveFileDialog downloadDialog;
    }
}

