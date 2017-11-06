using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Library.Models;

namespace Library.ApiControllers
{
    public class BooksController : ApiController
    {
        private LibraryContext db = new LibraryContext();

        // GET: api/Books
        public IEnumerable<Object> GetBooks()
        {
            var books = db.Books.Select(b => new
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                Number = b.Number,
                PubDate = b.PubDate,
                Author = b.Author.Name,
                Press = b.Press.Name,
                Category = b.Category.Name,
            });
            var booksQuery = from book in books.ToList()
                             orderby book.PubDate
                             group book by book.PubDate.Year
                             into booksGroup
                             select new { Time = booksGroup.Key, Count = booksGroup.Count(),Items= booksGroup.Select(b=>b.Name) };
            return booksQuery.ToList();
        }
    }
}