using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTNet.viewmodel;

namespace KTNet.Model.sevice
{
    public class sinhviensevice
    {
        public static List<sinhvien> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Sinhviens.Select(e => new sinhvien
            {
                ID = e.ID,
                Tengoi = e.Tengoi,
                Email = e.Email,
                Diachi = e.Diachi,
                Sodienthoai = e.Sodienthoai,
                IDNhom = e.IDNhom
            }).ToList();
            return rs;
        }
        public static List<nhomhoc> getNhom()
        {
            var db = new AppDBContext();
            var rs = db.Nhomhocs.Select(e => new nhomhoc
            {
                ID = e.ID,
                Tennhom = e.Tennhom,    
            }).ToList();
            return rs;
        }
        public static List<sinhvien> getByNhom(int IDnhomhoc)
        {
            var list = GetList();
            var rs = list.Where(t => t.IDNhom == IDnhomhoc).ToList();
            return rs;
        }
        public static KetQua AddSinhvien(Sinhvien sv)
        {

            var db = new AppDBContext();
            int count = db.Sinhviens.Where(e => e.Tengoi == sv.Tengoi).Count();
            if (count > 0)
            {
                return KetQua.TrungTen;
            }
            else
            {
                db.Sinhviens.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
            db.Sinhviens.Add(sv);
            db.SaveChanges();
        }
        public static KetQua AddNhomhoc(nhomhoc nh)
        {

            var db = new AppDBContext();
            int count = db.Nhomhocs.Where(e => e.Tennhom == nh.Tennhom).Count();
            if (count > 0)
            {
                return KetQua.TrungTennhom;
            }
            else
            {
                // db.Nhomhocs.Add(nh);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
            // db.Nhomhocs.Add(nh);
            db.SaveChanges();
        }

        public static KetQua UpDateSinhvien(sinhvien sv)
        {
            var db = new AppDBContext();
            var sinhvien = db.Sinhviens.Where(e => e.ID == sv.ID).FirstOrDefault();
            sinhvien.Tengoi = sv.Tengoi;
            sinhvien.Email = sv.Email;
            sinhvien.IDNhom = sv.IDNhom;
            sinhvien.Diachi = sv.Diachi;
            sinhvien.Sodienthoai = sv.Sodienthoai;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
        public static KetQua ReMoveSinhvien(sinhvien sv)
        {
            var db = new AppDBContext();
            var sinhvien = db.Sinhviens.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.Sinhviens.Remove(sinhvien);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
        public static KetQua ReMoveNhom(nhomhoc nh)
        {
            var db = new AppDBContext();
            var nhomhoc = db.Nhomhocs.Where(e => e.ID == nh.ID).FirstOrDefault();
            //db.Sinhviens.Remove(nh);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
        
    }
}
