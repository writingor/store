﻿using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        // внутренняя переменная books, инициализируется 1 раз (readonly)
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programming Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }
    }
}