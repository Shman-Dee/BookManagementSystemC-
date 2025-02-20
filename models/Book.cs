namespace BookManagementSystem.Models

{
    /// <summary>
    /// Represents a book with an ID, title, author, and genre.
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(int id, string title, string author, string genre)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
        }

        /// <summary>
        /// Returns a formatted string representation of the book.
        /// </summary>
        public override string ToString()
        {
            return $"ID: {Id}\nTitle: {Title}\nAuthor: {Author}\nGenre: {Genre}\n---------------------------";
        }
    }
}
