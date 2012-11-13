using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Table.DataServices;

namespace AzureTableDemo
{
    public partial class Form1 : Form
    {
        private readonly CloudStorageAccount storageAccount;

        public Form1()
        {
            InitializeComponent();

            // Create storage account...
        }

        private void Refresh(IEnumerable<Book> books)
        {
            bookTree.Nodes.Clear();

            foreach (Book book in books.OrderBy(b => b.RowKey))
                bookTree.Nodes.Add(new BookTreeNode(book));
        }

        private void LoadAllBooks()
        {
            // Load all books...
        }

        private void LoadAllBooksThatStartWithTheLetterC()
        {
            // Load all books that start with the letter "C" using a partition scan...
        }

        private void LoadAllBooksInTheBiographyCategory()
        {
            // Load all books in the "Biography" category...
        }

        private void CreateNewBook()
        {
            bookTitle.Text = String.Empty;
            bookAuthor.Text = String.Empty;
            bookCategory.Text = String.Empty;

            bookTitle.Focus();

            LoadAllBooks();
        }

        private void SaveBook()
        {
            if (String.IsNullOrEmpty(bookTitle.Text))
            {
                MessageBox.Show("Please provide a book title before continuing.");
                bookTitle.Focus();
                return;
            }

            if (String.IsNullOrEmpty(bookAuthor.Text))
            {
                MessageBox.Show("Please provide a book author before continuing.");
                bookAuthor.Focus();
                return;
            }

            if (String.IsNullOrEmpty(bookCategory.Text))
            {
                MessageBox.Show("Please provide a book category before continuing.");
                bookCategory.Focus();
                return;
            }

            // Save the book...

            CreateNewBook();
        }

        private void DeleteBook()
        {
            if (bookTree.SelectedNode == null)
                return;

            var bookNode = bookTree.SelectedNode as BookTreeNode;

            // Delete the book...

            CreateNewBook();
            LoadAllBooks();
        }

        private void BookTreeAfterSelect(object sender, TreeViewEventArgs e)
        {
            var bookNode = e.Node as BookTreeNode;

            if (bookNode == null)
                return;

            bookTitle.Text = bookNode.Book.RowKey;
            bookAuthor.Text = bookNode.Book.Author;
            bookCategory.Text = bookNode.Book.PartitionKey;
        }

        private void BookTreeKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                DeleteBook();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            LoadAllBooks();
        }

        private void CreateNewBookClicked(object sender, EventArgs e)
        {
            CreateNewBook();
        }

        private void DeleteBookClicked(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void SaveBookClicked(object sender, EventArgs e)
        {
            SaveBook();
        }

        private void RefreshClicked(object sender, EventArgs e)
        {
            LoadAllBooks();
        }

        private void FindAllBooksThatStartWithTheLetterCToolStripMenuItemClick(object sender, EventArgs e)
        {
            LoadAllBooksThatStartWithTheLetterC();
        }

        private void FindAllBooksInTheBiograpyCategoryToolStripMenuItemClick(object sender, EventArgs e)
        {
            LoadAllBooksInTheBiographyCategory();
        }

        private void BookCategoryLeave(object sender, EventArgs e)
        {
            SaveBook();
        }
    }
}