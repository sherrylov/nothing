using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class BorrowBook
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("借阅时间"), DataType(DataType.Date)]
        public DateTime Time { get; set; }

        [Required]
        [Display(Name = "借阅类型")]
        public bool Type { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        [ForeignKey("UserId")]
        [DisplayName("User")]
        [InverseProperty("UserBooks")]
        public virtual User User { get; set; }

        [ForeignKey("BookId")]
        [DisplayName("图书")]
        [InverseProperty("UserBooks")]
        public virtual Book Book { get; set; }
    }
}