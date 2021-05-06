using DAO;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class ChiTietController : Controller
    {
        // GET: ChiTiet
        public ActionResult Index(int id)
        {
            MyDB db = new MyDB();
            ThongTin tt = db.chitiet(id);
            IEnumerable<ThongTin> list = db.list();
            ViewBag.list = list;
            return View(tt);
        }
    }
}