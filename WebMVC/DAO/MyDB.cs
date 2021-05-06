using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DAO
{
    public class MyDB
    {
        SQL sql = new SQL();
        public IEnumerable<ThongTin> list()
        {
            return sql.ThongTins.ToList();
            
        }
        public ThongTin tt(string hang)
        {
            return sql.ThongTins.Where(t => t.Hang == hang).FirstOrDefault();
        }
        public ThongTin chitiet(int id)
        {
            return sql.ThongTins.FirstOrDefault(t => t.ID == id);
        }
        public List<ThongTin> Search(string search)
        {
            return sql.ThongTins.Where(t => t.Ten.Contains(search)).ToList();
        }
        public List<ThongTin> dssp(string hang)
        {
            return sql.ThongTins.Where(t => t.Hang == hang).ToList();
        }
        public IEnumerable<string> danhmuc()
        {


             return sql.ThongTins.Select(q=>q.Hang).Distinct().ToList();

        }
        public virtual DbSet<ThongTin> ThongTins { get;set; }

    }
}
