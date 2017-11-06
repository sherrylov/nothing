using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookIO
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Time"), DataType(DataType.Date)]
        public DateTime Time { get; set; }

        [Required]
        [Range(0, 10000)]
        [Display(Name = "Number")]
        public string Number { get; set; }

        //public int UId { get; set; }

        //public int BId { get; set; }

        //[ForeignKey("UId")]
        //[DisplayName("采购用户")]
        //[InverseProperty("IOBooks")]
        //public virtual User U { get; set; }

        //[ForeignKey("BId")]
        //[DisplayName("采购图书")]
        //[InverseProperty("IOBooks")]
        //public virtual Book B { get; set; }
        public int UserId { get; set; }

        public int BookId { get; set; }

        [ForeignKey("UserId")]
        [DisplayName("User")]
        [InverseProperty("BookIOs")]
        public virtual User User { get; set; }

        [ForeignKey("BookId")]
        [DisplayName("图书")]
        [InverseProperty("BookIOs")]
        public virtual Book Book { get; set; }
    }
}