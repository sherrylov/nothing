using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("书名"), Required]
        public string Name { get; set; }

        [DisplayName("出版时间"), DataType(DataType.Date)]
        public DateTime PubDate { get; set; }

        [Required]
        [Range(0, 500)]
        [Display(Name = "价格")]
        public float Price { get; set; }

        [Required]
        [Range(0, 10000)]
        [Display(Name = "库存")]
        public int Number { get; set; }

        [ForeignKey("Author")]
        [Display(Name = "作者")]
        public int AuthorId { get; set; }

   
        [DisplayName("Author")]
        public virtual Author Author { get; set; }

        [ForeignKey("Category")]
        [DisplayName("目录")]
        public int CategoryId { get; set; }

 
        [DisplayName("Category")]
        public virtual Category Category { get; set; }

        [ForeignKey("Press")]
        [DisplayName("出版社")]
        public int PressId { get; set; }

 
        [DisplayName("Press")]
        public virtual Press Press { get; set; }

        //[DisplayName("借书用户")]
        ////public virtual List<BorrowBook> BorrowBooks { get; set; }
        //public virtual List<BorrowBook> BorrowBooks { get; set; }

        public int BookId { get; set; }
        [DisplayName("借了本书的用户")]
        [InverseProperty("Book")]
        public virtual ICollection<BorrowBook> UserBooks { get; set; }
        public virtual ICollection<BookIO> BookIOs { get; set; }

    }
}