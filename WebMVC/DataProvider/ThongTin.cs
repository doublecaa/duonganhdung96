namespace DataProvider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTin")]
    public partial class ThongTin
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string Hang { get; set; }

        public double? Gia { get; set; }

        [Column(TypeName = "ntext")]
        public string Mota { get; set; }

        [Column("_url")]
        [StringLength(100)]
        public string C_url { get; set; }

        public static implicit operator ThongTin(Cart v)
        {
            throw new NotImplementedException();
        }
    }
}
