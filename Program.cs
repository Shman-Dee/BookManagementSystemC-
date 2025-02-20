namespace BookManagementSystem.Services

{
    class Program
    {
        static void Main()
        {

            BookManagerService bookManager = new BookManagerService();

            bookManager.DisplayMenu();
            Console.WriteLine("Enter your choice: ");
            string input = Console.ReadLine();

            while (input != "5")
            {
                switch (input)
                {
                    case "1":
                        bookManager.DisplayBooks();
                        break;
                    case "2":
                        bookManager.DisplayBookById();
                        break;
                    case "3":
                        bookManager.AddNewBook();
                        break;
                    case "4":
                        bookManager.RemoveBookById();
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n\n\n");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n\n");
                        break;
                }

                bookManager.DisplayMenu();
                Console.WriteLine("Enter your choice: ");
                input = Console.ReadLine();
            }

            if (input == "5")
            {
                Console.WriteLine("Exiting the system. Goodbye!");
            }
        }
    }
}