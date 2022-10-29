using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTNet.Model;
using KTNet.Model.sevice;
using KTNet.viewmodel;

namespace KTNet
{
    public partial class frmsinhvien : Form
    {
        private sinhvien sinhvien;

        public frmsinhvien(sinhvien sinhvien = null)
        {
            InitializeComponent();
            NapDSNhom();
            this.sinhvien = sinhvien;
            if (sinhvien != null)
            {
                cbbnhom.SelectedValue = sinhvien.IDNhom;
                txttengoi.Text = sinhvien.Tengoi;
                txtemail.Text = sinhvien.Email;
                txtdiachi.Text = sinhvien.Diachi;
                txtsodienthoai.Text = sinhvien.Sodienthoai;

            }
        }
        void NapDSNhom()
        {
            var ls = nhomhoc.GetList();
            cbbnhom.DataSource = ls;
            cbbnhom.ValueMember = "ID";
            cbbnhom.DisplayMember = "Tennhom";
        }
        public nhomhoc seletednhomhoc
        {
            get
            {
                return cbbnhom.SelectedItem as nhomhoc;
            }
        }
        private void frmsinhvien_Load(object sender, EventArgs e)
        {

        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            if (this.sinhvien == null)
            {
                var sv = new Sinhvien
                {
                    Tengoi = txttengoi.Text,
                    Diachi = txtdiachi.Text,
                    Email = txtemail.Text,
                    Sodienthoai = txtsodienthoai.Text,
                    IDNhom = seletednhomhoc.ID,
                };
                if (sinhviensevice.AddSinhvien(sv) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show
                        ("Ten Sinh Vien Trung", "Thong bao");
                    txttengoi.Focus();
                }
            }
            else
            {
                sinhvien.Tengoi = txttengoi.Text;
                sinhvien.Diachi = txtdiachi.Text;
                sinhvien.Email = txtemail.Text;
                sinhvien.Sodienthoai = txtsodienthoai.Text;
                sinhvien.IDNhom = seletednhomhoc.ID;
            }
            DialogResult = DialogResult.OK;
        }
    }

}
