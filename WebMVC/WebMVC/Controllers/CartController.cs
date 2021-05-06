using DAO;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class CartController : Controller
    {    MyDB db = new MyDB();
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
        public Carttt GetCart()
        {

            Carttt cart = Session["cart"] as Carttt;
            if (cart == null|| Session["cart"]==null)
            {
                cart = new Carttt();
                Session["cart"] = cart;
            }
            return cart;
        }
        public ActionResult  Addsp(int IDsp, int sl)
        {
            Carttt cart = Session["cart"] as Carttt;
            ThongTin sanpham = new ThongTin();
            sanpham = db.ThongTins.FirstOrDefault(q => q.ID == IDsp);
            if(cart!=null)
            {
                cart.Add(sanpham, sl);
                Session["cart"] = cart;
            }
            else
            {
                cart = new Carttt();
                cart.Add(sanpham, sl);
                Session["cart"] = cart;
            }
            return RedirectToAction("ViewCart");
        }
        public ActionResult ViewCart()
        {
            if(Session["cart"]==null)
            {
                Session["cart"] = GetCart();
                return RedirectToAction("ViewCart", "Cart");
            }
            Carttt cart = Session["cart"] as Carttt;
            return View(cart);
        }
        public ActionResult Update(FormCollection form)
        {
            Carttt cart = Session["cart"] as Carttt;
            int IDsp = int.Parse(form["ID_SanPham"]);
            int sl = int.Parse(form["Soluong"]);
            cart.UpdateSL(IDsp, sl);
            return RedirectToAction("ViewCart", "Cart");
        }
    }
}