using KTNet.Model.sevice;
using KTNet.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTNet.viewmodel;

namespace KTNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            napdsnhomhoc();
        }
        void napdsnhomhoc()
        {
            var ls = sinhviensevice.getNhom();
            SourceNhom.DataSource = ls;
            //bdsSinhVien.DataSource = list;
            dataGridView1.DataSource = SourceNhom;
        }
        public nhomhoc selectedNhom
        {
            get
            {
                return SourceNhom.Current as nhomhoc;
            }
        }
        public sinhvien selectedSinhvien
        {
            get
            {
                return SourceSinhvien.Current as sinhvien;
                //return DataGridView.Selected
            }
        }
        void NapDSSinhvien()
        {
            if (selectedNhom != null)
            {
                var list = sinhviensevice.getByNhom(selectedNhom.ID);
                SourceSinhvien.DataSource = list;
                //bdsSinhVien.DataSource = list;
                dataGridView2.DataSource = SourceSinhvien;
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var f = new frmnhom();
            var r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                napdsnhomhoc();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa liên lạc này?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    sinhviensevice.ReMoveNhom(selectedNhom);
                    napdsnhomhoc();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sinhVienViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDSSinhvien();
        }

        private void click(object sender, DataGridViewCellEventArgs e)
        {
            NapDSSinhvien();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chitietsv(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            var f = new frmsinhvien();
            var r = f.ShowDialog();
            if (r == DialogResult.OK)
            {
                NapDSSinhvien();
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (selectedSinhvien != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa liên lạc này?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    sinhviensevice.ReMoveSinhvien(selectedSinhvien);
                    NapDSSinhvien();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            {
                var db = new AppDBContext();
                var text = txtTimKiem.Text;
                if (selectedNhom != null)
                {
                    foreach (var item in db.Nhomhocs)
                    {
                        if (item.ID == selectedNhom.ID)
                        {
                            var results = db.Sinhviens.Where(x => x.Tengoi.ToLower().Contains(text)).ToList();
                            dataGridView2.DataSource = results;
                        }
                    }
                }
            }
        }
    }
}
