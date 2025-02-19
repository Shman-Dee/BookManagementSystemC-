namespace BookManagementSystem.Services
{
    public class BookManagerService
    {
        private List<string> books;

        /// <summary>
        /// Constructor for the BookManagerService class
        /// </summary>

        public BookManagerService()
        {
            books = new List<string> { "Book 1", "Book 2", "Book 3" };
        }


        /// <summary>
        /// Displays the menu for the book management system
        /// </summary>
        public void DisplayMenu()
        {
            {
                Console.WriteLine($"Welcome to the book management system. You currently have {books.Count} books in your system.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Display Books");
                Console.WriteLine("2. Display Book by Book ID");
                Console.WriteLine("3. Add New Book");
                Console.WriteLine("4. Remove Book by Book ID");
                Console.WriteLine("5. Exit");
            }
        }
    }
}
