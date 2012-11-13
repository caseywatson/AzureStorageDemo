using System.Windows.Forms;

namespace AzureTableDemo
{
    public class BookTreeNode : TreeNode
    {
        public BookTreeNode(Book book)
        {
            Book = book;

            ImageKey = "Books";
            SelectedImageKey = "Books";
            Text = book.RowKey;
        }

        public Book Book { get; private set; }
    }
}
