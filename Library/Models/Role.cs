using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Role
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Name"), Required]
        public string Name { get; set; }

        [DisplayName("Users")]
        public virtual List<User> Users { get; set; }
    }
}