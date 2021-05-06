using DAO;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyDB mdb = new MyDB();
            
            IEnumerable<ThongTin> list = mdb.list();
            ViewBag.list = list;
            return View(list);
        }

        public ActionResult About()
        {
            MyDB mdb = new MyDB();
            IEnumerable<ThongTin> list = mdb.list();
            ViewBag.list = list;
            return View(list);
        }

        public ActionResult Contact()
        {
            MyDB mdb = new MyDB();
            IEnumerable<ThongTin> list = mdb.list();
            ViewBag.list = list;
            return View(list);
        }
        public ActionResult ds()
        {
            MyDB mdb = new MyDB();

            IEnumerable<ThongTin> list = mdb.list();
            String ds = String.Empty;
            
            return Content(ds);
        }
        public ActionResult search(string search)
        {
            MyDB db = new MyDB();
            IEnumerable<ThongTin> list = db.list();
            ViewBag.list = list;
            List<ThongTin> sch = db.Search(search);
            return View(sch);
        }
        public ActionResult Menu()
        {
            MyDB db = new MyDB();
            IEnumerable<string> menu = db.danhmuc();
            ViewBag.menu = menu;
            return View(menu);
        }
    }
}