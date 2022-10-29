using KTNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTNet.viewmodel
{
    public enum KetQua
    {
        TrungTen,
        TrungTennhom,
        ThanhCong
    }
    public class sinhvien
    {
        public int ID { get; set; }
        public string Tengoi { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }
        public string Sodienthoai { get; set; }
        public int? IDNhom { get; set; }

        public static List<sinhvien> GetSV()
        {
            var db = new AppDBContext();
            var rs = db.Sinhviens.Select(e => new sinhvien
            {
                IDNhom = e.IDNhom,
                Tengoi = e.Tengoi,
                Email = e.Email,
                Diachi = e.Diachi,
                Sodienthoai = e.Sodienthoai

            }).ToList();
            return rs;
        }

    }
}
