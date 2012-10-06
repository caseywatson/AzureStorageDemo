using Microsoft.WindowsAzure.StorageClient;

namespace AzureTableDemo
{
    public class Book : TableServiceEntity
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
