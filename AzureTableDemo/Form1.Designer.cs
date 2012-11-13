namespace AzureTableDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.bookAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bookTree = new System.Windows.Forms.TreeView();
            this.treeImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.findAllBooksThatStartWithTheLetterCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllBooksInTheCCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(15, 53);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(299, 22);
            this.bookTitle.TabIndex = 1;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Location = new System.Drawing.Point(15, 96);
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(299, 22);
            this.bookAuthor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Author";
            // 
            // bookCategory
            // 
            this.bookCategory.Location = new System.Drawing.Point(15, 139);
            this.bookCategory.Name = "bookCategory";
            this.bookCategory.Size = new System.Drawing.Size(299, 22);
            this.bookCategory.TabIndex = 5;
            this.bookCategory.Leave += new System.EventHandler(this.BookCategoryLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Category";
            // 
            // bookTree
            // 
            this.bookTree.ImageIndex = 0;
            this.bookTree.ImageList = this.treeImageList;
            this.bookTree.Location = new System.Drawing.Point(15, 187);
            this.bookTree.Name = "bookTree";
            this.bookTree.SelectedImageIndex = 0;
            this.bookTree.Size = new System.Drawing.Size(299, 166);
            this.bookTree.TabIndex = 12;
            this.bookTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BookTreeAfterSelect);
            this.bookTree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BookTreeKeyUp);
            // 
            // treeImageList
            // 
            this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
            this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.treeImageList.Images.SetKeyName(0, "Books");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(329, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Add Book";
            this.toolStripButton1.Click += new System.EventHandler(this.CreateNewBookClicked);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Delete Book";
            this.toolStripButton4.Click += new System.EventHandler(this.DeleteBookClicked);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Save Book";
            this.toolStripButton2.Click += new System.EventHandler(this.SaveBookClicked);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Refresh";
            this.toolStripButton3.Click += new System.EventHandler(this.RefreshClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findAllBooksThatStartWithTheLetterCToolStripMenuItem,
            this.findAllBooksInTheCCategoryToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "Find Books";
            // 
            // findAllBooksThatStartWithTheLetterCToolStripMenuItem
            // 
            this.findAllBooksThatStartWithTheLetterCToolStripMenuItem.Name = "findAllBooksThatStartWithTheLetterCToolStripMenuItem";
            this.findAllBooksThatStartWithTheLetterCToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.findAllBooksThatStartWithTheLetterCToolStripMenuItem.Text = "Find all books that start with the letter \'C\'.";
            this.findAllBooksThatStartWithTheLetterCToolStripMenuItem.Click += new System.EventHandler(this.FindAllBooksThatStartWithTheLetterCToolStripMenuItemClick);
            // 
            // findAllBooksInTheCCategoryToolStripMenuItem
            // 
            this.findAllBooksInTheCCategoryToolStripMenuItem.Name = "findAllBooksInTheCCategoryToolStripMenuItem";
            this.findAllBooksInTheCCategoryToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.findAllBooksInTheCCategoryToolStripMenuItem.Text = "Find all books in the Biography category.";
            this.findAllBooksInTheCCategoryToolStripMenuItem.Click += new System.EventHandler(this.FindAllBooksInTheBiograpyCategoryToolStripMenuItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 368);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bookTree);
            this.Controls.Add(this.bookCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Azure Tables - Books";
            this.Load += new System.EventHandler(this.LoadForm);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitle;
        private System.Windows.Forms.TextBox bookAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bookCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView bookTree;
        private System.Windows.Forms.ImageList treeImageList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem findAllBooksThatStartWithTheLetterCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAllBooksInTheCCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

