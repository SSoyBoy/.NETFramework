using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTNet.Model.sevice;
using KTNet.Model;
using KTNet.viewmodel;

namespace KTNet
{
    public partial class frmnhom : Form
    {
        private nhomhoc nhomhoc;
        private Sinhvien sv;

        public frmnhom(nhomhoc nhomhoc = null)
        {
            InitializeComponent();
            NapDSSV();
            this.nhomhoc = nhomhoc;
            if (nhomhoc != null)
            {
                
                int txtID = nhomhoc.ID;
                txtTennhom.Text = nhomhoc.Tennhom;
                

            }
        }
        void NapDSSV()
        {
            var ls = sinhvien.GetSV();
            //txtTennhom.DataSource = ls;
            //cbbnhom.ValueMember = "ID";
            //cbbnhom.DisplayMember = "Tennhom";
        }
        //public sinhvien seletedsinhvien
        //{
        //    get
        //    {
        //        return txtTennhom. as nhomhoc;
        //    }
        //}
      
        private void frmnhom_Load(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (this.nhomhoc == null)
            {
                var nh = new Nhomhoc
                {
                    //ID = seletedsinhvien.ID,
                    Tennhom = txtTennhom.Text,

                };
                if (sinhviensevice.AddSinhvien(sv) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show
                        ("Ten nhom bi Trung", "Thong bao");
                    txtTennhom.Focus();
                }
            }
            else
            {
                nhomhoc.Tennhom = txtTennhom.Text;
                //nhomhoc.ID = se.ID;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
