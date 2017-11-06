using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Library.Models
{
    [DataContract]
    public class Category
    {
        [DataMember]
        [DisplayName("Id")]
        public int Id { get; set; }

        [DataMember]
        [DisplayName("目录名称"), Required]
        public string Name { get; set; }
        
        [DisplayName("Books")]
        public virtual List<Book> Books { get; set; }
    }
}