using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository = null)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index(int Id)
        {
            Book book = _bookRepository.GetById(Id);

            return View(book);
        }
    }
}
