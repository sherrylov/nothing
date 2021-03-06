﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Press
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("出版社名称"), Required]
        public string Name { get; set; }

        [DisplayName("Books")]
        public virtual List<Book> Books { get; set; }
    }
}