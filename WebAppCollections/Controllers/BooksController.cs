using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCollections.Models;
using WebAppCollections.Services;
using WebAppCollections.ViewModels;

namespace WebAppCollections.Controllers
{
    public class BooksController : Controller
    {
        private IBooks _books;
        public BooksController(IBooks books)
        {
            _books = books;
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel();
            model.Book = _books.GetBooks();
            model.CurrentMessage = " Hello from ViewModel";

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _books.Get(id);

            if (model==null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Books moddel )    
        {

            if (ModelState.IsValid)
            {
                var newBook = new Books();
                newBook.Author = moddel.Author;
                newBook.Title = moddel.Title;
                newBook.Category = moddel.Category;
                newBook.Description = moddel.Description;

                newBook = _books.Add(newBook);

                return RedirectToAction(nameof(Details), new { id = newBook.Id }); 
            }
            else
            {
                return View();
            }
        }
    }
}
