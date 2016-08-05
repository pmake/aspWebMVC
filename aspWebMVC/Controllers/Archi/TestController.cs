using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspWebMVC.App_Start;
using aspWebMVC.Models;


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

        //DBManiplating使用
        public ActionResult Test()
        {
            DBManipulator dbManipulator = new DBManipulator();
            dbManipulator.Entity = new AdventureWorksDW2012Entities();
            //dbManipulator.TheWhere();
            //dbManipulator.TheSelect();
            dbManipulator.TheSelectMany();
            //dbManipulator.TheGroupBy();
            //dbManipulator.TheToLookup();

            //dbManipulator.TheJoin();
            //dbManipulator.TheGroupJoin();
            //dbManipulator.TheOrderByAndTheThenBy();

            //dbManipulator.SkipOrTake();

            //dbManipulator.FirstOrlast();
            //dbManipulator.TheContains();
            //dbManipulator.CountAndAny();
            dbManipulator.MaxAndMinAndSum();

            return View();
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