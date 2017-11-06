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
    public class BorrowBooksController : ApiController
    {
        private LibraryContext db = new LibraryContext();

        // GET: api/BorrowBooks
        public IEnumerable<Object> GetBorrowBooks(String group)
        {
            //return db.BorrowBooks.Where(b =>b.Type).Select(b =>
            //new {
            //    Id=b.Id,
            //    UserName=b.User.UserName,
            //    BookName=b.Book.Name,
            //    Date=b.Time,
            //}).OrderByDescending(b=>b.Date);
            var borrowBooks = db.BorrowBooks.Where(b => b.Type).Select(b =>
            new
            {
                Id = b.Id,
                UserName = b.User.UserName,
                BookName = b.Book.Name,
                Date = b.Time,
            }).OrderByDescending(b => b.Date);

            var groupTime = from bb in borrowBooks
                              group bb by bb.Date.Year + "年" + bb.Date.Month + "月"
                              into bbs
                              select new { Time = bbs.Key, Count = bbs.Count(), Items = bbs.Select(b => b.BookName) };
            var groupUser = from bb in borrowBooks
                            group bb by bb.UserName
                              into bbs
                            select new { UserName = bbs.Key, Count = bbs.Count(), Items = bbs.Select(b => b.BookName) };
 
            var groupBook=from bb in borrowBooks
                          group bb by bb.BookName
                          into bbs
                          select new { BookName = bbs.Key, Count = bbs.Count(), Items = bbs.Select(b => b.UserName) };

            if (group == "data")
            {
                return groupTime.ToList();
            }
            else if (group == "book")
            {
                return groupBook.ToList();
            }
            else
            {
                return groupUser.ToList();
            }
        }
    }
}