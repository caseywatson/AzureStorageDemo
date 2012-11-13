using Microsoft.WindowsAzure.Storage.Table;

namespace AzureTableDemo
{
    public class Book : TableEntity
    {
        public Book() { }

        public Book(string bookTitle, string bookAuthor, string bookCategory)
        {
            RowKey = bookTitle;
            Author = bookAuthor;
            PartitionKey = bookCategory;
        }

        public string Author { get; set; }
    }
}
