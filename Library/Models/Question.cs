using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Question
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("问题"), Required]
        public string Name { get; set; }

        [DisplayName("选项")]
        public virtual List<Option> Options { get; set; }

        //[DisplayName("Votes")]
        //public virtual List<Vote> Votes { get; set; }
    }
}