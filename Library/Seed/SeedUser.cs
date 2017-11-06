using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Seed
{
    internal class SeedUser
    {
        public void seed(LibraryContext context)
        {
            context.Users.Add(new User
            {
                Id=1,
                UserName = "user",
                Sex = "男",
                Age = 20,
                CulturalLevel = "大学",
                Email = "user@123.com",
                PassWord = "user",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 2,
                UserName = "Cdmin",
                Sex = "女",
                Age = 16,
                CulturalLevel = "大学",
                Email = "123@456.com",
                PassWord = "1234",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 3,
                UserName = "Ddmin",
                Sex = "女",
                Age = 18,
                CulturalLevel = "大学",
                Email = "admin@gmail.com",
                PassWord = "Ddmin",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 4,
                UserName = "user1",
                Sex = "女",
                Age = 18,
                CulturalLevel = "高中",
                Email = "admin@gmail.com",
                PassWord = "user1",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 5,
                UserName = "user2",
                Sex = "女",
                Age = 18,
                CulturalLevel = "高中",
                Email = "admin@gmail.com",
                PassWord = "user2",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 6,
                UserName = "user3",
                Sex = "男",
                Age = 18,
                CulturalLevel = "高中",
                Email = "user3@gmail.com",
                PassWord = "user3",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 7,
                UserName = "realUser4",
                Sex = "女",
                Age = 27,
                CulturalLevel = "高中",
                Email = "realUser4@gmail.com",
                PassWord = "realUser4",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 8,
                UserName = "user5",
                Sex = "男",
                Age = 45,
                CulturalLevel = "大学",
                Email = "user5@123.com",
                PassWord = "user5",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 9,
                UserName = "user7",
                Sex = "女",
                Age = 65,
                CulturalLevel = "初中",
                Email = "user7@456.com",
                PassWord = "user7",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 10,
                UserName = "user8",
                Sex = "女",
                Age = 54,
                CulturalLevel = "高中",
                Email = "user8@gmail.com",
                PassWord = "user8",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 11,
                UserName = "useer9",
                Sex = "女",
                Age = 39,
                CulturalLevel = "高中",
                Email = "useer9@gmail.com",
                PassWord = "useer9",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 12,
                UserName = "real3",
                Sex = "女",
                Age = 43,
                CulturalLevel = "高中",
                Email = "real3@gmail.com",
                PassWord = "real3",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 13,
                UserName = "real4",
                Sex = "男",
                Age = 14,
                CulturalLevel = "初中",
                Email = "real4@gmail.com",
                PassWord = "real4",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 14,
                UserName = "tyloo1",
                Sex = "女",
                Age = 15,
                CulturalLevel = "初中",
                Email = "tyloo1@gmail.com",
                PassWord = "tyloo1",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 15,
                UserName = "tyloo2",
                Sex = "男",
                Age = 21,
                CulturalLevel = "大学",
                Email = "tyloo2@123.com",
                PassWord = "tyloo2",
                RoleId = 2
            });
            context.Users.Add(new User
            {
                Id = 16,
                UserName = "fdsghfd",
                Sex = "男",
                Age = 21,
                CulturalLevel = "大学",
                Email = "tyloo2@123.com",
                PassWord = "tyloo2",
                RoleId = 2
            });



        }
    }
}