using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspWebMVC.Controllers
{
    public class FirstController : Controller
    {
        // GET: Archi
        public ActionResult Index()
        {
            UserViewModel uvm = new UserViewModel();
            uvm.name = "Archi";
            uvm.address = "中壢市區";
            uvm.isShow = true;
            return View(uvm);
        }
        public ActionResult Products()
        {
            UserViewModel uvm1 = new UserViewModel();
            uvm1.name = "Archi";
            UserViewModel uvm2 = new UserViewModel();
            uvm2.name = "Wen";
            List<UserViewModel> list = new List<UserViewModel>();
            list.Add(uvm1);
            list.Add(uvm2);

            return View(list);
        }
    }
    public class UserViewModel
    {
        public string name { set; get; }
        public string phone { set; get; }
        public string address { set; get; }
        public bool isShow { set; get; }
    }
}