namespace GenericsTest
{
    public class Book
    {
        private int bookIsbn;
        private string bookTitle;

        public int BookIsbn
        {
            get { return bookIsbn; }
            set
            {
                bookIsbn = value ;
            }
        }

        public string BookTitle
        {
            get { return bookTitle; }
            set
            {
                bookTitle = value;
            }
        }
    }
}