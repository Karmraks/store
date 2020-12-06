using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] book = new[]
        {
            new Book(1, "ISBN 12345-67890", "D.Knuth", "Art of Programming"),
            new Book(2, "ISBN 12345-67891", "M.Fowler", "Refactoring"),
            new Book(3, "ISBN 12345-67892", "B.Kernighan, D.Ritchie", "C Programming Language")
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return book.Where(book => book.Isbn == isbn).ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return book.Where(book => book.Title.Contains(titleOrAuthor) 
            || book.Author.Contains(titleOrAuthor)).ToArray();
        }
    }
}
