

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        // внутренняя переменная books, инициализируется 1 раз (readonly)
        private readonly Book[] books = new[]
        {
            new Book(1, "Art Of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Language"),
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return books.Where(book => book.Title.Contains(titlePart))
                        .ToArray();
        }
    }
}