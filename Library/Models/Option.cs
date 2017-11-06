using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Option
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("选项名称"), Required]
        public string Name { get; set; }


        [ForeignKey("Question")]
        [DisplayName("问题")]
        public int QuestionId { get; set; }


        [DisplayName("Question")]
        public virtual Question Question { get; set; }

        [DisplayName("Votes")]
        public virtual List<Vote> Votes { get; set; }
    }
}