namespace KTNet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.xoanhom = new System.Windows.Forms.ToolStrip();
            this.btnthemnhom = new System.Windows.Forms.ToolStripButton();
            this.btnxoanhom = new System.Windows.Forms.ToolStripButton();
            this.btnthem = new System.Windows.Forms.ToolStripButton();
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tennhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tengoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceSinhvien = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceNhom = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.xoanhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceSinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.xoanhom);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 556);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceSinhvien, "Sodienthoai", true));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(591, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceSinhvien, "Email", true));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(591, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceSinhvien, "Diachi", true));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(590, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SourceSinhvien, "Tengoi", true));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(590, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = ".......................................................";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(436, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(436, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(436, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(431, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "[Tên gọi ]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập từ cần tìm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(970, 0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(245, 22);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // xoanhom
            // 
            this.xoanhom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.xoanhom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemnhom,
            this.btnxoanhom,
            this.btnthem,
            this.btnxoa});
            this.xoanhom.Location = new System.Drawing.Point(0, 0);
            this.xoanhom.Name = "xoanhom";
            this.xoanhom.Size = new System.Drawing.Size(1226, 27);
            this.xoanhom.TabIndex = 2;
            this.xoanhom.Text = "toolStrip1";
            // 
            // btnthemnhom
            // 
            this.btnthemnhom.Image = ((System.Drawing.Image)(resources.GetObject("btnthemnhom.Image")));
            this.btnthemnhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemnhom.Name = "btnthemnhom";
            this.btnthemnhom.Size = new System.Drawing.Size(112, 24);
            this.btnthemnhom.Text = "Thêm nhóm";
            this.btnthemnhom.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoanhom
            // 
            this.btnxoanhom.Image = ((System.Drawing.Image)(resources.GetObject("btnxoanhom.Image")));
            this.btnxoanhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoanhom.Name = "btnxoanhom";
            this.btnxoanhom.Size = new System.Drawing.Size(101, 24);
            this.btnxoanhom.Text = "Xoá nhóm";
            this.btnxoanhom.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(121, 24);
            this.btnthem.Text = "Thêm liên lạc";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(110, 24);
            this.btnxoa.Text = "Xoá liên lạc";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tengoi,
            this.Email,
            this.Sodienthoai,
            this.iDDataGridViewTextBoxColumn,
            this.tengoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.sodienthoaiDataGridViewTextBoxColumn,
            this.iDNhomDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.SourceSinhvien;
            this.dataGridView2.Location = new System.Drawing.Point(404, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(811, 311);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chitietsv);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tennhom,
            this.iDDataGridViewTextBoxColumn1,
            this.tennhomDataGridViewTextBoxColumn,
            this.displayMemberDataGridViewTextBoxColumn,
            this.selectedItemDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.SourceNhom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(395, 511);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.click);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tennhom
            // 
            this.Tennhom.DataPropertyName = "Tennhom";
            this.Tennhom.HeaderText = "Tên nhóm";
            this.Tennhom.MinimumWidth = 6;
            this.Tennhom.Name = "Tennhom";
            this.Tennhom.ReadOnly = true;
            this.Tennhom.Width = 350;
            // 
            // Tengoi
            // 
            this.Tengoi.DataPropertyName = "Tengoi";
            this.Tengoi.HeaderText = "Tên gọi";
            this.Tengoi.MinimumWidth = 6;
            this.Tengoi.Name = "Tengoi";
            this.Tengoi.ReadOnly = true;
            this.Tengoi.Width = 150;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 300;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.DataPropertyName = "Sodienthoai";
            this.Sodienthoai.HeaderText = "Số điện thoại";
            this.Sodienthoai.MinimumWidth = 6;
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.ReadOnly = true;
            this.Sodienthoai.Width = 200;
            // 
            // SourceSinhvien
            // 
            this.SourceSinhvien.DataSource = typeof(KTNet.viewmodel.sinhvien);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tengoiDataGridViewTextBoxColumn
            // 
            this.tengoiDataGridViewTextBoxColumn.DataPropertyName = "Tengoi";
            this.tengoiDataGridViewTextBoxColumn.HeaderText = "Tengoi";
            this.tengoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tengoiDataGridViewTextBoxColumn.Name = "tengoiDataGridViewTextBoxColumn";
            this.tengoiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tengoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sodienthoaiDataGridViewTextBoxColumn
            // 
            this.sodienthoaiDataGridViewTextBoxColumn.DataPropertyName = "Sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.HeaderText = "Sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sodienthoaiDataGridViewTextBoxColumn.Name = "sodienthoaiDataGridViewTextBoxColumn";
            this.sodienthoaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sodienthoaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDNhomDataGridViewTextBoxColumn
            // 
            this.iDNhomDataGridViewTextBoxColumn.DataPropertyName = "IDNhom";
            this.iDNhomDataGridViewTextBoxColumn.HeaderText = "IDNhom";
            this.iDNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDNhomDataGridViewTextBoxColumn.Name = "iDNhomDataGridViewTextBoxColumn";
            this.iDNhomDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDNhomDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tennhomDataGridViewTextBoxColumn
            // 
            this.tennhomDataGridViewTextBoxColumn.DataPropertyName = "Tennhom";
            this.tennhomDataGridViewTextBoxColumn.HeaderText = "Tennhom";
            this.tennhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tennhomDataGridViewTextBoxColumn.Name = "tennhomDataGridViewTextBoxColumn";
            this.tennhomDataGridViewTextBoxColumn.ReadOnly = true;
            this.tennhomDataGridViewTextBoxColumn.Width = 125;
            // 
            // displayMemberDataGridViewTextBoxColumn
            // 
            this.displayMemberDataGridViewTextBoxColumn.DataPropertyName = "DisplayMember";
            this.displayMemberDataGridViewTextBoxColumn.HeaderText = "DisplayMember";
            this.displayMemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.displayMemberDataGridViewTextBoxColumn.Name = "displayMemberDataGridViewTextBoxColumn";
            this.displayMemberDataGridViewTextBoxColumn.ReadOnly = true;
            this.displayMemberDataGridViewTextBoxColumn.Width = 125;
            // 
            // selectedItemDataGridViewTextBoxColumn
            // 
            this.selectedItemDataGridViewTextBoxColumn.DataPropertyName = "SelectedItem";
            this.selectedItemDataGridViewTextBoxColumn.HeaderText = "SelectedItem";
            this.selectedItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.selectedItemDataGridViewTextBoxColumn.Name = "selectedItemDataGridViewTextBoxColumn";
            this.selectedItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.selectedItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // SourceNhom
            // 
            this.SourceNhom.DataSource = typeof(KTNet.viewmodel.nhomhoc);
            this.SourceNhom.CurrentChanged += new System.EventHandler(this.sinhVienViewModelBindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 586);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xoanhom.ResumeLayout(false);
            this.xoanhom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceSinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip xoanhom;
        private System.Windows.Forms.ToolStripButton btnthemnhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnxoanhom;
        private System.Windows.Forms.ToolStripButton btnthem;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource SourceNhom;
        private System.Windows.Forms.BindingSource SourceSinhvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tengoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedItemDataGridViewTextBoxColumn;
    }
}

