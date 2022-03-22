using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController: Controller
    {
        private readonly IRepositorieBook repositorieBook;
        public BookController(IRepositorieBook repositoriebook)
        {
            this.repositorieBook = repositoriebook;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            book.Author = "Garcia Marquez";
            book.Price = 200;
            repositorieBook.Create(book);
            return View();
        }
    }
}
