using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] book = new[]
        {
            new Book(1, "ISBN 12345-67890", "D.Knuth", "Art of Programming", "Smth", 0m),
            new Book(2, "ISBN 12345-67891", "M.Fowler", "Refactoring", "Smth", 0m),
            new Book(3, "ISBN 12345-67892", "B.Kernighan, D.Ritchie", "C Programming Language", "Smth", 0m)
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

        public Book GetById(int id)
        {
            return book.Single(book => book.Id == id);
        }
    }
}
