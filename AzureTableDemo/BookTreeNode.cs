using System.Windows.Forms;

namespace AzureTableDemo
{
    public class BookTreeNode : TreeNode
    {
        public BookTreeNode(Book book)
        {
            Book = book;

            ImageKey = "Book";
            SelectedImageKey = "Book";
            Text = book.RowKey;
        }

        public Book Book { get; private set; }
    }
}
