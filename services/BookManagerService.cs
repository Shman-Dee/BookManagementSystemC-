namespace BookManagementSystem.Services

{
    using BookManagementSystem.Models;
    public class BookManagerService
    {
        private List<Book> books;

        /// <summary>
        /// Initializes the book list with some default books.
        /// </summary>
        public BookManagerService()
        {
            books = new List<Book>
            {
                new Book(1, "The Stand", "Stephen King", "Fantasy"),
                new Book(2, "The Great Gatsby", "F. Scott Fitzgerald", "Fiction"),
                new Book(3, "Do Androids Dream of Electric Sheep?", "Philip K. Dick", "Sci-fi"),
                new Book(4, "Bad Monkey", "Carl Heissen", "Comedy")
            };
        }


        /// <summary>
        /// Displays the menu for the book management system
        /// </summary>
        public void DisplayMenu()
        {
            {
                Console.WriteLine($"Welcome to the book management system. You currently have {books.Count} books in your system.\n");
                Console.WriteLine("What would you like to do?\n");
                Console.WriteLine("1. Display Books");
                Console.WriteLine("2. Display Book by Book ID");
                Console.WriteLine("3. Add New Book");
                Console.WriteLine("4. Remove Book by Book ID");
                Console.WriteLine("5. Exit\n");
            }
        }

        /// <summary>
        /// Displays all the books in the system
        /// </summary>
        public void DisplayBooks()
        {
            Console.WriteLine("\nBooks in List:");

            if (books.Count == 0)
            {
                Console.WriteLine("No books in the system.");
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine(books[i].ToString());
                }
            }
        }

        /// <summary>
        /// Displays a book by its ID
        /// </summary>
        public void DisplayBookById()
        {
            Console.WriteLine("Enter the ID of the book you want to display: ");
            string input = Console.ReadLine();
            int id;

            // Try to convert input to an integer
            if (!int.TryParse(input, out id))
            {
                Console.WriteLine("Invalid input. Please enter a numerical book ID.\n\n");
                // Exit the method early if input is not a number
                return;
            }

            if (id < 1 || id > books.Count)
            {
                Console.WriteLine("Invalid ID. Please try again.");
            }
            else
            {
                Console.WriteLine($"\n\nBook {id}: {books[id - 1]}");
            }
        }

        /// <summary>
        /// Adds a new book to the system
        /// </summary>
        public void AddNewBook()
        {
            int newId = GenerateNewBookId(); // Automatically generate the next ID

            // Validate book title
            string title;
            while (true)
            {
                Console.Write("Enter Book Title: ");
                title = Console.ReadLine();
                if (!string.IsNullOrEmpty(title))
                {
                    break;
                }
                Console.WriteLine("Title cannot be empty. Please enter a valid book title.");
            }

            // Validate book author
            string author;
            while (true)
            {
                Console.Write("Enter Book Author: ");
                author = Console.ReadLine();
                if (!string.IsNullOrEmpty(author))
                {
                    break;
                }
                Console.WriteLine("Author cannot be empty. Please enter a valid book author.");
            }

            // Validate book genre
            string genre;
            while (true)
            {
                Console.Write("Enter Book Genre: ");
                genre = Console.ReadLine();
                if (!string.IsNullOrEmpty(genre))
                {
                    break;
                }
                Console.WriteLine("Genre cannot be empty. Please enter a valid book genre.");
            }

            // Add the book to the list
            books.Add(new Book(newId, title, author, genre));
            Console.WriteLine("\n\nBook added successfully with ID: " + newId + "\n\n");
        }

        /// <summary>
        /// Removes a book from the system by its ID
        /// </summary>
        public void RemoveBookById()
        {
            Console.WriteLine("Enter the ID of the book you want to remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (id < 1 || id > books.Count)
            {
                Console.WriteLine("Invalid ID. Please try again.");
            }
            else
            {
                books.RemoveAt(id - 1);
                Console.WriteLine("Book removed successfully.");
            }
        }

        /// <summary>
        /// Finds the highest existing book ID and returns the next available ID.
        /// </summary>
        private int GenerateNewBookId()
        {
            if (books.Count == 0)
            {
                return 1; // Start from ID 1 if the list is empty
            }

            int highestId = books[0].Id;

            for (int i = 1; i < books.Count; i++)
            {
                if (books[i].Id > highestId)
                {
                    highestId = books[i].Id;
                }
            }

            return highestId + 1;
        }
    }
}
