using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class LeaveMessage
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("内容"), Required]
        public string Body { get; set; }

        [ForeignKey("Author")]
        [DisplayName("留言者")]
        public int AuthorId { get; set; }

        [DisplayName("Author")]
        public virtual User Author { get; set; }

        [DisplayName("留言时间"), DataType(DataType.Date)]
        public DateTime Time { get; set; }
    }
}