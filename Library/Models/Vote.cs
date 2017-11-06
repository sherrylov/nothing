using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Vote
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [ForeignKey("User")]
        [DisplayName("用户")]
        public int UserId { get; set; }

        [DisplayName("用户")]
        public virtual User User { get; set; }

        [ForeignKey("Option")]
        [DisplayName("选项")]
        public int OptionId { get; set; }

        [DisplayName("选项")]
        public virtual Option Option { get; set; }
    }
}