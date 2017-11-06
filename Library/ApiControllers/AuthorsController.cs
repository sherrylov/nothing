using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Library.Models;

namespace Library.ApiControllers
{
    public class AuthorsController : ApiController
    {
        private LibraryContext db = new LibraryContext();

        // GET: api/Authors
        public IQueryable<Object> GetAuthors()
        {
            return db.Authors.Select(c => new {
                Name = c.Name,
                Id = c.Id,
                Count = c.Books.Count
            });
        }
    }
}