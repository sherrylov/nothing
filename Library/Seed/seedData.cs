using Library.Seed;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class seedData : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            
            context.Users.Add(new User
            {
                UserName = "admin",
                PassWord = "admin",
                Age = 21,
                Role = new Role() { Name = "管理员" },
                Email = "admin@gmail.com",
            });
            context.Roles.Add(new Role { Name = "普通用户" });
            context.Authors.Add(new Author
            {
                Id = 1,
                Name = "林奕含",
            });
            context.Authors.Add(new Author
            {
                Id = 2,
                Name = "肯·福莱特",
            });
            context.Authors.Add(new Author
            {
                Id = 3,
                Name = "东野圭吾",
            });
            context.Authors.Add(new Author
            {
                Id = 4,
                Name = "埃莱娜·费兰特",
            });
            context.Authors.Add(new Author
            {
                Id = 5,
                Name = "加西亚·马尔克斯",
            });
            context.Authors.Add(new Author
            {
                Id = 6,
                Name = "余华",
            });
            context.Authors.Add(new Author
            {
                Id = 9,
                Name = "乔治·奥威尔",
            });
            context.Authors.Add(new Author
            {
                Id = 10,
                Name = "涂子沛",
            });
            context.Authors.Add(new Author
            {
                Id = 11,
                Name = "[美] 伍绮诗",
            });
            context.Authors.Add(new Author
            {
                Id = 12,
                Name = "格雷厄姆·格林",
            });
            context.Authors.Add(new Author
            {
                Id = 13,
                Name = "菲利普•休斯顿 迈克尔•弗洛伊德 苏珊•卡尼瑟洛",
            });
            context.Authors.Add(new Author
            {
                Id = 14,
                Name = "三谷宏治",
            });
            context.Authors.Add(new Author
            {
                Id = 15,
                Name = "铃木敏文",
            });
            context.Authors.Add(new Author
            {
                Id = 16,
                Name = "帕特里克·塔克尔",
            });
            context.Authors.Add(new Author
            {
                Id = 17,
                Name = "IT经理世界",
            });
            context.Authors.Add(new Author
            {
                Id = 18,
                Name = "二混子",
            });
            context.Authors.Add(new Author
            {
                Id = 19,
                Name = "方兴东、刘伟",
            });
            context.Authors.Add(new Author
            {
                Id = 20,
                Name = "羿飞",
            });
            context.Authors.Add(new Author
            {
                Id = 21,
                Name = "汉斯·马格努斯·恩岑斯贝格尔",
            });
            context.Authors.Add(new Author
            {
                Id = 22,
                Name = "[美] 罗伯特·杰伊·利夫顿",
            });
            context.Authors.Add(new Author
            {
                Id = 23,
                Name = " [美] 丹尼尔·席尔瓦",
            });
            context.Authors.Add(new Author
            {
                Id = 24,
                Name = "[英] 肯·福莱特 ",
            });
            context.Authors.Add(new Author
            {
                Id = 25,
                Name = "[美] 加·泽文 ",
            });
            context.Authors.Add(new Author
            {
                Id = 26,
                Name = "北京大陆桥文化传媒",
            });
            context.Authors.Add(new Author
            {
                Id = 27,
                Name = "波利亚",
            });
            context.Authors.Add(new Author
            {
                Id = 28,
                Name = "[英] 安迪·莱利",
            });
            context.Authors.Add(new Author
            {
                Id = 29,
                Name = "顾森",
            });
            context.Authors.Add(new Author
            {
                Id = 30,
                Name = "[韩］ 姜锡基",
            });
            context.Authors.Add(new Author
            {
                Id = 31,
                Name = "[美] 史蒂夫·洛尔",
            });
            context.Authors.Add(new Author
            {
                Id = 32,
                Name = "[美] Sarah Lacy",
            });
            context.Authors.Add(new Author
            {
                Id = 33,
                Name = "加斯特",
            });
            context.Authors.Add(new Author
            {
                Id = 34,
                Name = "陈一佳",
            });
            context.Authors.Add(new Author
            {
                Id = 35,
                Name = "[英]查尔斯·亚瑟",
            });
            context.Authors.Add(new Author
            {
                Id = 36,
                Name = "[美] 杰伊•哈曼",
            });
            context.Authors.Add(new Author
            {
                Id = 37,
                Name = "（比）普里戈金，（法）斯唐热",
            });
            context.Authors.Add(new Author
            {
                Id = 38,
                Name = "村上春树",
            });
            context.Authors.Add(new Author
            {
                Id = 39,
                Name = "[美]弗雷德蒙德·马利克",
            });
            context.Authors.Add(new Author
            {
                Id = 40,
                Name = "梁成",
            });
            context.Authors.Add(new Author
            {
                Id = 41,
                Name = "稻盛和夫",
            });
            context.Authors.Add(new Author
            {
                Id = 42,
                Name = "陈杰",
            });
            context.Authors.Add(new Author
            {
                Id = 43,
                Name = "[美] 唐纳德·基奥 （Donald R.Keough)）",
            });
            context.Authors.Add(new Author
            {
                Id = 44,
                Name = "胜间和代",
            });
            context.Authors.Add(new Author
            {
                Id = 46,
                Name = "严歌苓",
            });
            context.Authors.Add(new Author
            {
                Id = 47,
                Name = "周梅森",
            });
            context.Authors.Add(new Author
            {
                Id = 48,
                Name = "菲茨杰拉德",
            });
            context.Authors.Add(new Author
            {
                Id = 49,
                Name = "[奥] 斯台芬·茨威格",
            });
            context.Authors.Add(new Author
            {
                Id = 50,
                Name = "霍达",
            });





            context.Categories.Add(new Category
            {
                Id = 1,
                Name = "小说",
            });
            context.Categories.Add(new Category
            {
                Id = 2,
                Name = "历史",
            });
            context.Categories.Add(new Category
            {
                Id = 3,
                Name = "互联网",
            });
            context.Categories.Add(new Category
            {
                Id = 4,
                Name = "漫画",
            });
            context.Categories.Add(new Category
            {
                Id = 5,
                Name = "科技",
            });
            context.Categories.Add(new Category
            {
                Id = 6,
                Name = "编程",
            });
            context.Categories.Add(new Category
            {
                Id = 7,
                Name = "商业",
            });
            context.Presses.Add(new Press
            {
                Id = 1,
                Name = "江苏凤凰文艺出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 2,
                Name = "南海出版公司",
            });
            context.Presses.Add(new Press
            {
                Id = 3,
                Name = "人民文学出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 4,
                Name = "上海人民出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 5,
                Name = "天津人民出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 6,
                Name = "上海译文出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 7,
                Name = "中信出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 8,
                Name = "北京十月文艺出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 14,
                Name = "世界图书出版公司",
            });
            context.Presses.Add(new Press
            {
                Id = 16,
                Name = "游擊文化",
            });
            context.Presses.Add(new Press
            {
                Id = 11,
                Name = "人民邮电出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 17,
                Name = "上海科技教育出版社",
            });
            context.Presses.Add(new Press
            {
                Id = 18,
                Name = "东南大学出版社",
            });




            context.Books.Add(new Book
            {
                Name = "巨人的陨落",
                PubDate = Convert.ToDateTime("2016/5/1 "),
                Price = 89.6f,
                Number = 10,
                AuthorId = 2,
                CategoryId = 1,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "世界的凛冬",
                PubDate = Convert.ToDateTime("2017/3/1 "),
                Price = 94.9f,
                Number = 20,
                AuthorId = 2,
                CategoryId = 1,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "无声告白",
                PubDate = Convert.ToDateTime("2015/7/1 "),
                Price = 23.9f,
                Number = 15,
                AuthorId = 11,
                CategoryId = 1,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "恋情的终结",
                PubDate = Convert.ToDateTime("2017/4/15  "),
                Price = 41.7f,
                Number = 25,
                AuthorId = 12,
                CategoryId = 1,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "掌控力——让所有人对你讲真话",
                PubDate = Convert.ToDateTime("2017/2/1 "),
                Price = 24.1f,
                Number = 10,
                AuthorId = 13,
                CategoryId = 7,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "经营战略全史",
                PubDate = Convert.ToDateTime("2016/1/1"),
                Price = 28.7f,
                Number = 50,
                AuthorId = 14,
                CategoryId = 7,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "房思琪的初戀樂園",
                PubDate = Convert.ToDateTime("2017-2-7"),
                Price = 86,
                Number = 100,
                AuthorId = 1,
                CategoryId = 1,
                PressId = 16,
            });
            context.Books.Add(new Book
            {
                Name = "零售心理战",
                PubDate = Convert.ToDateTime("2015-6-1"),
                Price = 39,
                Number = 78,
                AuthorId = 15,
                CategoryId = 7,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "商业模式全史",
                PubDate = Convert.ToDateTime("2016-1-1"),
                Price = 28.6f,
                Number = 65,
                AuthorId = 14,
                CategoryId = 7,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "赤裸裸的未来",
                PubDate = Convert.ToDateTime("2014-10-1"),
                Price = 35.4f,
                Number = 36,
                AuthorId = 16,
                CategoryId = 5,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "大产品—— 超级世界市场：窃意、创意与生意",
                PubDate = Convert.ToDateTime("2014-11-1"),
                Price = 26.2f,
                Number = 55,
                AuthorId = 17,
                CategoryId = 5,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "半小时漫画中国史",
                PubDate = Convert.ToDateTime("2017-4-10"),
                Price = 25.6f,
                Number = 45,
                AuthorId = 18,
                CategoryId = 4,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "阿里巴巴正传：我们与马云的“一步之遥",
                PubDate = Convert.ToDateTime("2015-1-10"),
                Price = 31.7f,
                Number = 65,
                AuthorId = 19,
                CategoryId = 3,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "我的钱：互联网金融，如何理财？",
                PubDate = Convert.ToDateTime("2015-1-9"),
                Price = 58,
                Number = 75,
                AuthorId = 20,
                CategoryId = 3,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "动荡",
                PubDate = Convert.ToDateTime("2016-12-9"),
                Price = 58,
                Number = 75,
                AuthorId = 21,
                CategoryId = 2,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "纳粹医生",
                PubDate = Convert.ToDateTime("2016-10-15"),
                Price = 77.5f,
                Number = 56,
                AuthorId = 22,
                CategoryId = 2,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "暗杀大师：寻找伦勃朗",
                PubDate = Convert.ToDateTime("2016-7-29 "),
                Price = 30.2f,
                Number = 45,
                AuthorId = 23,
                CategoryId = 1,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "永恒的边缘",
                PubDate = Convert.ToDateTime("2017-5-7 "),
                Price = 79,
                Number = 80,
                AuthorId = 24,
                CategoryId = 2,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "玛格丽特小镇",
                PubDate = Convert.ToDateTime("2016-6-1"),
                Price = 24.9f,
                Number = 51,
                AuthorId = 25,
                CategoryId = 1,
                PressId = 1,
            });
            context.Books.Add(new Book
            {
                Name = "解忧杂货店",
                PubDate = Convert.ToDateTime("2014/5/15  "),
                Price = 29.4f,
                Number = 128,
                AuthorId = 3,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "白夜行",
                PubDate = Convert.ToDateTime("2008-9-15 "),
                Price = 29.4f,
                Number = 160,
                AuthorId = 3,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "嫌疑人X的献身",
                PubDate = Convert.ToDateTime("2008/9/1"),
                Price = 26,
                Number = 240,
                AuthorId = 3,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "新名字的故事",
                PubDate = Convert.ToDateTime("2017-4-7"),
                Price = 36,
                Number = 150,
                AuthorId = 4,
                CategoryId = 1,
                PressId = 3,
            });
            context.Books.Add(new Book
            {
                Name = "我的天才女友",
                PubDate = Convert.ToDateTime("2017-1-14"),
                Price = 32.3f,
                Number = 178,
                AuthorId = 4,
                CategoryId = 1,
                PressId = 3,
            });
            context.Books.Add(new Book
            {
                Name = "霍乱时期的爱情",
                PubDate = Convert.ToDateTime("2012-9-1"),
                Price = 45,
                Number = 165,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "百年孤独",
                PubDate = Convert.ToDateTime("2011-6-18"),
                Price = 29.4f,
                Number = 326,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "族长的秋天",
                PubDate = Convert.ToDateTime("2014-6-13"),
                Price = 29.6f,
                Number = 153,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "梦中的欢快葬礼和十二个异乡故事",
                PubDate = Convert.ToDateTime("2015-5-1"),
                Price = 26,
                Number = 415,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "一个遇难者的故事",
                PubDate = Convert.ToDateTime("1995-7-3"),
                Price = 85,
                Number = 265,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "迷宫中的将军",
                PubDate = Convert.ToDateTime("2014-11-9"),
                Price = 29.6f,
                Number = 147,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "世上最美的溺水者",
                PubDate = Convert.ToDateTime("2015-11-1"),
                Price = 58,
                Number = 75,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "没有人给他写信的上校",
                PubDate = Convert.ToDateTime("2013-5-15"),
                Price = 14.5f,
                Number = 274,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "一桩事先张扬的凶杀案",
                PubDate = Convert.ToDateTime("2013-6-9"),
                Price = 18.6f,
                Number = 455,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "爱情和其他魔鬼",
                PubDate = Convert.ToDateTime("2016-1-23"),
                Price = 26,
                Number = 358,
                AuthorId = 5,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "许三观卖血记",
                PubDate = Convert.ToDateTime("1998-9-11"),
                Price = 17.9f,
                Number = 556,
                AuthorId = 6,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "活着",
                PubDate = Convert.ToDateTime("1998-5-20 "),
                Price = 13.6f,
                Number = 600,
                AuthorId = 6,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "兄弟（上）",
                PubDate = Convert.ToDateTime("2005-8-17 "),
                Price = 29.3f,
                Number = 600,
                AuthorId = 6,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "在细雨中呼喊",
                PubDate = Convert.ToDateTime("1999-1-12"),
                Price = 18.6f,
                Number = 401,
                AuthorId = 6,
                CategoryId = 1,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "数据之巅",
                PubDate = Convert.ToDateTime("2014-5-1"),
                Price = 48.4f,
                Number = 308,
                AuthorId = 10,
                CategoryId = 3,
                PressId = 7,
            });
            context.Books.Add(new Book
            {
                Name = "罪证现场",
                PubDate = Convert.ToDateTime("2006-1-18 "),
                Price = 10,
                Number = 100,
                AuthorId = 3,
                CategoryId = 5,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "怎样解题",
                PubDate = Convert.ToDateTime("2011-11-1"),
                Price = 22.7f,
                Number = 200,
                AuthorId = 27,
                CategoryId = 5,
                PressId = 17,
            });
            context.Books.Add(new Book
            {
                Name = "作死的发明",
                PubDate = Convert.ToDateTime("2014-9- 7"),
                Price = 24,
                Number = 350,
                AuthorId = 28,
                CategoryId = 5,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "思考的乐趣",
                PubDate = Convert.ToDateTime("2012-6-14"),
                Price = 37.7f,
                Number = 178,
                AuthorId = 29,
                CategoryId = 5,
                PressId = 11,
            });
            context.Books.Add(new Book
            {
                Name = "煮酒论科学",
                PubDate = Convert.ToDateTime("2015-5-13"),
                Price = 34,
                Number = 185,
                AuthorId = 30,
                CategoryId = 5,
                PressId = 11,
            });
            context.Books.Add(new Book
            {
                Name = "软件故事",
                PubDate = Convert.ToDateTime("2014-7-18"),
                Price = 40,
                Number = 320,
                AuthorId = 31,
                CategoryId = 5,
                PressId = 11,
            });
            context.Books.Add(new Book
            {
                Name = "硅谷合伙人",
                PubDate = Convert.ToDateTime("2014-1-13"),
                Price = 42,
                Number = 190,
                AuthorId = 32,
                CategoryId = 5,
                PressId = 11,
            });
            context.Books.Add(new Book
            {
                Name = "802.11无线网络权威指南",
                PubDate = Convert.ToDateTime("2007-12-13"),
                Price = 66,
                Number = 200,
                AuthorId = 33,
                CategoryId = 5,
                PressId = 18,
            });
            context.Books.Add(new Book
            {
                Name = "创客法则",
                PubDate = Convert.ToDateTime("2015-7-3"),
                Price = 36.9f,
                Number = 260,
                AuthorId = 34,
                CategoryId = 5,
                PressId = 7,
            });
            context.Books.Add(new Book
            {
                Name = "数字战争",
                PubDate = Convert.ToDateTime("2013-6-1"),
                Price = 49,
                Number = 150,
                AuthorId = 35,
                CategoryId = 5,
                PressId = 7,
            });
            context.Books.Add(new Book
            {
                Name = "创新启示",
                PubDate = Convert.ToDateTime("2015-12-1"),
                Price = 32.4f,
                Number = 275,
                AuthorId = 36,
                CategoryId = 5,
                PressId = 7,
            });
            context.Books.Add(new Book
            {
                Name = "从混沌到有序",
                PubDate = Convert.ToDateTime("2005-05-16"),
                Price = 23.3f,
                Number = 190,
                AuthorId = 37,
                CategoryId = 5,
                PressId = 6,
            });
            context.Books.Add(new Book
            {
                Name = "海边的卡夫卡",
                PubDate = Convert.ToDateTime("2003-4-16"),
                Price = 32.5f,
                Number = 0,
                AuthorId = 38,
                CategoryId = 1,
                PressId = 18,
            });
            context.Books.Add(new Book
            {
                Name = "管理成就生活",
                PubDate = Convert.ToDateTime("2009-1-14"),
                Price = 26.5f,
                Number = 0,
                AuthorId = 39,
                CategoryId = 5,
                PressId = 17,
            });
            context.Books.Add(new Book
            {
                Name = "金融街",
                PubDate = Convert.ToDateTime("2017-2-24"),
                Price = 30.8f,
                Number = 0,
                AuthorId = 40,
                CategoryId = 4,
                PressId = 11,
            });
            context.Books.Add(new Book
            {
                Name = "稻盛和夫的实学：经营和会计",
                PubDate = Convert.ToDateTime("2005-12-24"),
                Price = 23.5f,
                Number = 0,
                AuthorId = 41,
                CategoryId = 5,
                PressId = 11,
            });
            context.Books.Add(new Book
            {
                Name = "大染坊",
                PubDate = Convert.ToDateTime("2003-7-14"),
                Price = 43.5f,
                Number = 0,
                AuthorId = 42,
                CategoryId = 6,
                PressId = 11,
            });
            context.Books.Add(new Book
            {
                Name = "管理十诫",
                PubDate = Convert.ToDateTime("2010-1-24"),
                Price = 32.8f,
                Number = 0,
                AuthorId = 43,
                CategoryId = 4,
                PressId = 17,
            });
            context.Books.Add(new Book
            {
                Name = "创造商业头脑的7种框架力",
                PubDate = Convert.ToDateTime("2014-5-22"),
                Price = 24.5f,
                Number = 0,
                AuthorId = 44,
                CategoryId = 3,
                PressId = 7,
            });
            context.Books.Add(new Book
            {
                Name = "管理的未来",
                PubDate = Convert.ToDateTime("2013-6-4"),
                Price = 30.6f,
                Number = 0,
                AuthorId = 45,
                CategoryId = 3,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "芳华",
                PubDate = Convert.ToDateTime("2017-5-1"),
                Price = 20.4f,
                Number = 0,
                AuthorId = 46,
                CategoryId = 7,
                PressId = 3,
            });
            context.Books.Add(new Book
            {
                Name = "人民的名义",
                PubDate = Convert.ToDateTime("2017-1-1"),
                Price = 36.1f,
                Number = 0,
                AuthorId = 47,
                CategoryId = 4,
                PressId = 2,
            });
            context.Books.Add(new Book
            {
                Name = "了不起的盖茨比",
                PubDate = Convert.ToDateTime("2004-06-7"),
                Price = 24.3f,
                Number = 0,
                AuthorId = 48,
                CategoryId = 4,
                PressId = 3,
            });
            context.Books.Add(new Book
            {
                Name = "一个陌生女人的来信",
                PubDate = Convert.ToDateTime("2007-7-7"),
                Price = 27.4f,
                Number = 0,
                AuthorId = 49,
                CategoryId = 5,
                PressId = 17,
            });
            context.Books.Add(new Book
            {
                Name = "穆斯林的葬礼",
                PubDate = Convert.ToDateTime("1988-12-1"),
                Price = 35.6f,
                Number = 0,
                AuthorId = 50,
                CategoryId = 4,
                PressId = 11,
            });


            SeedUser su = new SeedUser();
            su.seed(context);

            SeedBook bs = new SeedBook();
            bs.seed(context);

            base.Seed(context);
        }

    }
}