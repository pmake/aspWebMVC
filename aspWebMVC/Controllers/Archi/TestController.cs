using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspWebMVC.Controllers.Archi
{
    public class TestController : Controller
    {
        // GET: TestModel
        public ActionResult Index()
        {
            TestIndexModel tim = new TestIndexModel();
            Random ran = new Random();
            tim.ItemsCards = new List<ItemCard>
            {
                new ItemCard {Path=string.Format("{0}{1}", @"http://lorempixel.com/220/225/people/", RandomGenerator(ran)), Title="名稱標題",Content="物品介紹"},
                new ItemCard {Path=string.Format("{0}{1}", @"http://lorempixel.com/220/225/people/", RandomGenerator(ran)), Title="名稱標題",Content="物品介紹"},
                new ItemCard {Path=string.Format("{0}{1}", @"http://lorempixel.com/220/225/people/", RandomGenerator(ran)), Title="名稱標題",Content="物品介紹"},
                new ItemCard {Path=string.Format("{0}{1}", @"http://lorempixel.com/220/225/people/", RandomGenerator(ran)), Title="名稱標題",Content="物品介紹"},
                new ItemCard {Path=string.Format("{0}{1}", @"http://lorempixel.com/220/225/people/", RandomGenerator(ran)), Title="名稱標題",Content="物品介紹"},
                new ItemCard {Path=string.Format("{0}{1}", @"http://lorempixel.com/220/225/people/", RandomGenerator(ran)), Title="名稱標題",Content="物品介紹"},
            };
            return View(tim);
        }
        private int RandomGenerator(Random random)
        {
            return random.Next(10) + 1;
        }
    }
    public class TestIndexModel
    {
        public List<ItemCard> ItemsCards { set; get; }
    }

    public class ItemCard
    {
        public string Path;
        public string Title;
        public string Content;
    }

}