using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class User
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("用户"), Required]
        public string UserName { get; set; }

        [DisplayName("性别")]
        public string Sex { get; set; }

        [DisplayName("年龄")]
        public int Age { get; set; }

        [DisplayName("文化程度")]
        public string CulturalLevel { get; set; }

        [DisplayName("邮箱"), Required, EmailAddress]
        public string Email { get; set; }

        [DisplayName("密码"), Required, DataType(DataType.Password)]
        public string PassWord { get; set; }

        [ForeignKey("Role")]
        [DisplayName("角色")]
        public int RoleId { get; set; }

        [DisplayName("Role")]
        public virtual Role Role { get; set; }

  
        [DisplayName("该用户借的书")]
        [InverseProperty("User")]
        public virtual ICollection<BorrowBook> UserBooks { get; set; }
        public virtual ICollection<BookIO> BookIOs { get; set; }

        public bool is_admin()
        {
            return this.Role.Name == "管理员" ? true : false;
        }
    }
}