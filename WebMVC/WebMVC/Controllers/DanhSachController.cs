using DAO;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class DanhSachController : Controller
    {
         MyDB db = new MyDB();

        // GET: DanhSach
        public ActionResult Index(string hang)
        {

            IEnumerable<ThongTin> dssp = db.dssp(hang);
            IEnumerable<ThongTin> list = db.list();
            ViewBag.list = list;
            return View(dssp);

        }



    }
}