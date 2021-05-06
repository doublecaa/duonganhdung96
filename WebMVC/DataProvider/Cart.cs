using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class Cart
    {

        public ThongTin sanpham { get; set; }

        public int soluong { get; set; }

    }
    public class Carttt
    {
        List<Cart> carts = new List<Cart>();
        public IEnumerable<Cart> Carts { get { return carts; } }
        public void Add(ThongTin sanpham, int sl)
        {
            var item = carts.FirstOrDefault(i => i.sanpham.ID == sanpham.ID);
            if (item == null)
            {
                carts.Add(new Cart() { sanpham = sanpham, soluong = sl });
            }
            else
            {
                item.soluong += sl;
            }
        }
        public void UpdateSL(int id,int slmoi)
        {
            var item = carts.Find(i => i.sanpham.ID == id);
            if(item !=null)
            {
                item.soluong = slmoi;
            }
        }
    }


}
