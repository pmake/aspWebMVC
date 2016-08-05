using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using aspWebMVC.Models;

namespace aspWebMVC.App_Start
{
    /// <summary>
    /// 資料庫查詢常用語法，先有個概念即可，要用的時候再查看
    /// </summary>
    public class DBManipulator
    {
        public AdventureWorksDW2012Entities Entity { set; get; }

        public void TheWhere()
        {
            var aa = from a in Entity.DimCustomer
                     where a.BirthDate >= new DateTime(1970, 01, 01)
                     select a;
            List<DimCustomer> customers = aa.ToList();
        }

        public void TheSelect()
        {
            var aa = from a in Entity.DimCustomer
                     select a;
            var bb = Entity.DimCustomer.Select(a => a);
            List<DimCustomer> customers = bb.ToList();
        }

        /// <summary>
        /// Cross Join，使用debug模式去看語法運作方式即可理解
        /// </summary>
        public void TheSelectMany()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int> { 6, 4, 2, 7, 9, 0 };

            var query = list1.SelectMany(a => list2).ToList();

            //SelectMany的 LINQ程序式寫法
            var query1 = (from item1 in list1
                          from item2 in list2
                          select new { a = item1, b = item2 }).ToList();

            //F12看方法內容
            var query2 = (list1.SelectMany(a => list2, (a, b) => new { a, b })).ToList();

            string breakPoint = "";

            //public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector);
            //public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);

        }

        public void TheGroupBy()
        {
            //將資料表以指定的欄位分類傳回
            IQueryable<IGrouping<string, DimCustomer>> aa =
                Entity.DimCustomer.GroupBy(a => a.Gender);
            var bb = aa.ToList();

            //讀取時外層是類別
            foreach (var collection in bb)
            {
                //collection.Key
                //內層就是資料列
                foreach (var item in collection)
                {
                    //item.LastName;
                    //item.EmailAddress;
                }
            }
            string breakPoint = "";
        }

        public void TheToLookup()
        {
            //類似GroupBy，差異在Lookup直接取回查詢結果，GroupBy則是預查詢，使用ToList()才取回
            ILookup<string, DimCustomer> aa =
                Entity.DimCustomer.ToLookup(a => a.Gender);

            foreach (var group in aa)
            {
                //group.Key;
                foreach (var item1 in group)
                {
                    //item1.BirthDate;
                    //item1.FirstName;
                }
            }

            string breakPoint = "";
        }

        /// <summary>
        /// inner join
        /// </summary>
        public void TheJoin()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int> { 6, 4, 2, 7, 9, 0 };

            var aa = from a in list1
                     join b in list2 on a equals b
                     select b;

            var bb = list1.Join(list2, a => a, b => b, (a, b) => b);

            string breakPoint = "";
        }

        /// <summary>
        /// left outer join
        /// </summary>
        public void TheGroupJoin()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int> { 6, 4, 2, 7, 9, 0 };

            var aa = from a in list1
                     join b in list2 on a equals b into g
                     from item in g.DefaultIfEmpty()
                     select new { v = a, c = item };

            var bb = list1.GroupJoin(list2, a => a, b => b, (a, b) => new { v = a, c = b.DefaultIfEmpty() });
            var cc = list1.GroupJoin(list2, a => a, b => b, (a, b) => new { v = a, c = b.Count() });

            string breakPoint = "";
        }

        public void TheOrderByAndTheThenBy()
        {
            var aa = Entity.DimCustomer.OrderBy(a => a.BirthDate)
                .ThenBy(a => a.EmailAddress).ThenBy(a => a.TotalChildren);

            var bb = (from a in Entity.DimCustomer
                      select new
                      {
                          email = a.EmailAddress,
                          birth = a.BirthDate,
                          childs = a.TotalChildren
                      }).OrderBy(a => a.birth)
                .ThenBy(a => a.email).ThenBy(a => a.childs);

            string breakPoint = "";
        }

        public void SkipOrTake()
        {
            //var Skip = Entity.DimCustomer.Select(a => a.BirthDate).OrderBy(a => a);
            //var Skip1 = Entity.DimCustomer.Select(a => a.BirthDate).OrderBy(a => a).Skip(3);

            //var take = Entity.DimCustomer.Select(a => a.BirthDate).OrderBy(a => a);
            //var take1 = Entity.DimCustomer.Select(a => a.BirthDate).OrderBy(a => a).Take(10);

            //var skipAndTake = Entity.DimCustomer.Select(a => a.BirthDate).OrderBy(a => a);
            //var skipAndTake1 = Entity.DimCustomer.Select(a => a.BirthDate).OrderBy(a => a)
            //                  .Skip(5).Take(5);


            //LINQ to Entities 和 LINQ to SQL 都不支援
            //var SkipWhile = Entity.DimCustomer.Select(a => a.TotalChildren).ToList();
            //var SkipWhile1 = Entity.DimCustomer.Select(a => a.TotalChildren).ToList()
            //    .SkipWhile(a => a.Value < 3);
            //int[] val = { 33, 60, 222, 34, 999, 1 };
            //var aa = val.TakeWhile(n => n < 100);
            //int[] val1 = { 33, 60, 222, 34, 999, 1 };
            //var bb = val1.SkipWhile((n, idx) => n < 100);


            string breakPoint = "";
        }

        public void FirstOrlast()
        {
            //var first = Entity.DimCustomer.Where(a => a.TotalChildren > 10).First();
            var firstD = Entity.DimCustomer.Where(a => a.TotalChildren > 10).FirstOrDefault();

            //var last = Entity.DimCustomer.Where(a => a.TotalChildren > 10).Last();
            var lastD = Entity.DimCustomer.Where(a => a.TotalChildren > 10).LastOrDefault();


            string breakPoint = "";
        }

        public void TheContains()
        {
            var aa = Entity.DimCustomer.Select(a => a.LastName).Contains("James");

            string breakPoint = "";
        }

        public void CountAndAny()
        {
            //取集合內的數量
            int aa = Entity.DimCustomer.Select(a => a).Take(5).Count();
            //判斷集合內是否存在任一物件
            bool aa1 = Entity.DimCustomer.Select(a => a).Take(5).Any();

            string breakPoint = "";
        }

        public void MaxAndMinAndSum()
        {
            //int max = Entity.DimCustomer.Max(a => a.GeographyKey).Value;
            //int min = Entity.DimCustomer.Min(a => a.GeographyKey).Value;

            var val = Entity.DimCustomer.OrderBy(a => a.GeographyKey).Take(5);
            int sum = Entity.DimCustomer.OrderBy(a => a.GeographyKey).Take(5)
                                .Sum(a => a.GeographyKey).Value;
            double average1 = Entity.DimCustomer.Select(a => a.GeographyKey).Take(5)
                                .Average(a => a).Value;

            string breakPoint = "";
        }

    }
}