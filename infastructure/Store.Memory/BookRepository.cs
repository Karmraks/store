using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] book = new[]
        {
            new Book(1, "Art of Programming"),
            new Book(1, "Refactoring"),
            new Book(1, "C Programming Language")
        };

        public Book[] GetAllByTitle(string titlePart)
        {
            return book.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
