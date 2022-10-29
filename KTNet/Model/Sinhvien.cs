namespace KTNet.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sinhvien")]
    public partial class Sinhvien
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Tengoi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string Sodienthoai { get; set; }

        public int? IDNhom { get; set; }

        public virtual Nhomhoc Nhomhoc { get; set; }
    }
}
