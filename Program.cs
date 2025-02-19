namespace BookManagementSystem.Services

{
    class Program
    {
        static void Main()
        {

            BookManagerService bookManager = new BookManagerService();

            bookManager.DisplayMenu();
        }
    }
}