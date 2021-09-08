namespace GenericsTest
{
    public class Book
    {
        private string bookIsbn;
        private string bookTitle;

        public string BookIsbn
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