using KTNet.Model;
using KTNet.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTNet.viewmodel
{
    public class nhomhoc
    {
        public int ID { get; set; }
        public string Tennhom { get; set; }
        public List<nhomhoc> DataSource { get; internal set; }
        public string DisplayMember { get; internal set; }
        public nhomhoc SelectedItem { get; internal set; }

        public static List<nhomhoc> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhomhocs.Select(e => new nhomhoc
            {
                ID = e.ID,
                Tennhom = e.Tennhom
            }).ToList();
            return rs;
        }
    }
}
