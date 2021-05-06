using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataProvider
{
    public partial class SQL : DbContext
    {
        public SQL()
            : base("name=SQL")
        {
        }

        public virtual DbSet<ThongTin> ThongTins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThongTin>()
                .Property(e => e.C_url)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
