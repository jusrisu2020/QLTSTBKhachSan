
namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgvQLNV = new System.Windows.Forms.DataGridView();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            this.btnRefeshChucVu = new System.Windows.Forms.Button();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.btnInsertChucVu = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbTenCongTy = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.gbSTK = new System.Windows.Forms.GroupBox();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbDiaChi = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.gbSDT = new System.Windows.Forms.GroupBox();
            this.gbTenNCC = new System.Windows.Forms.GroupBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.gbMaNCC = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbTenCongTy.SuspendLayout();
            this.gbSTK.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbDiaChi.SuspendLayout();
            this.gbSDT.SuspendLayout();
            this.gbTenNCC.SuspendLayout();
            this.gbMaNCC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(666, 58);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(56, 19);
            this.btnThemNhanVien.TabIndex = 1;
            this.btnThemNhanVien.Text = "Add...";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnUpdateNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Location = new System.Drawing.Point(738, 58);
            this.btnDeleteNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(50, 19);
            this.btnDeleteNV.TabIndex = 2;
            this.btnDeleteNV.Text = "Delete";
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Search...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dtgvQLNV
            // 
            this.dtgvQLNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLNV.Location = new System.Drawing.Point(14, 352);
            this.dtgvQLNV.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQLNV.Name = "dtgvQLNV";
            this.dtgvQLNV.ReadOnly = true;
            this.dtgvQLNV.RowHeadersVisible = false;
            this.dtgvQLNV.RowHeadersWidth = 51;
            this.dtgvQLNV.RowTemplate.Height = 24;
            this.dtgvQLNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLNV.Size = new System.Drawing.Size(836, 176);
            this.dtgvQLNV.TabIndex = 4;
            this.dtgvQLNV.Click += new System.EventHandler(this.dtgvQLNV_Click);
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(187, 12);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(113, 20);
            this.txtTimKiemNV.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChucVu);
            this.groupBox2.Controls.Add(this.btnRefeshChucVu);
            this.groupBox2.Controls.Add(this.txtMaCV);
            this.groupBox2.Controls.Add(this.txtTenCV);
            this.groupBox2.Controls.Add(this.btnInsertChucVu);
            this.groupBox2.Location = new System.Drawing.Point(542, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 257);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(16, 87);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.ReadOnly = true;
            this.dtgvChucVu.RowHeadersVisible = false;
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(211, 114);
            this.dtgvChucVu.TabIndex = 14;
            // 
            // btnRefeshChucVu
            // 
            this.btnRefeshChucVu.Location = new System.Drawing.Point(230, 12);
            this.btnRefeshChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefeshChucVu.Name = "btnRefeshChucVu";
            this.btnRefeshChucVu.Size = new System.Drawing.Size(88, 28);
            this.btnRefeshChucVu.TabIndex = 19;
            this.btnRefeshChucVu.Text = "Refesh";
            this.btnRefeshChucVu.UseVisualStyleBackColor = true;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(16, 27);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(67, 20);
            this.txtMaCV.TabIndex = 18;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(88, 27);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(128, 20);
            this.txtTenCV.TabIndex = 15;
            // 
            // btnInsertChucVu
            // 
            this.btnInsertChucVu.Location = new System.Drawing.Point(230, 43);
            this.btnInsertChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertChucVu.Name = "btnInsertChucVu";
            this.btnInsertChucVu.Size = new System.Drawing.Size(88, 28);
            this.btnInsertChucVu.TabIndex = 16;
            this.btnInsertChucVu.Text = "Thêm Bộ Phận";
            this.btnInsertChucVu.UseVisualStyleBackColor = true;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.groupBox5);
            this.gbInfo.Controls.Add(this.groupBox4);
            this.gbInfo.Controls.Add(this.groupBox3);
            this.gbInfo.Controls.Add(this.groupBox1);
            this.gbInfo.Controls.Add(this.gbTenCongTy);
            this.gbInfo.Controls.Add(this.gbSTK);
            this.gbInfo.Controls.Add(this.gbEmail);
            this.gbInfo.Controls.Add(this.gbDiaChi);
            this.gbInfo.Controls.Add(this.gbSDT);
            this.gbInfo.Controls.Add(this.gbTenNCC);
            this.gbInfo.Controls.Add(this.gbMaNCC);
            this.gbInfo.Location = new System.Drawing.Point(14, 58);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(508, 289);
            this.gbInfo.TabIndex = 23;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông Tin";
            // 
            // gbTenCongTy
            // 
            this.gbTenCongTy.Controls.Add(this.txtSDT);
            this.gbTenCongTy.Location = new System.Drawing.Point(164, 148);
            this.gbTenCongTy.Name = "gbTenCongTy";
            this.gbTenCongTy.Size = new System.Drawing.Size(134, 52);
            this.gbTenCongTy.TabIndex = 11;
            this.gbTenCongTy.TabStop = false;
            this.gbTenCongTy.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(15, 19);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 0;
            // 
            // gbSTK
            // 
            this.gbSTK.Controls.Add(this.dtpkNgaySinh);
            this.gbSTK.Location = new System.Drawing.Point(164, 32);
            this.gbSTK.Name = "gbSTK";
            this.gbSTK.Size = new System.Drawing.Size(134, 52);
            this.gbSTK.TabIndex = 11;
            this.gbSTK.TabStop = false;
            this.gbSTK.Text = "Ngày Sinh";
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txtEmail);
            this.gbEmail.Location = new System.Drawing.Point(332, 32);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(134, 52);
            this.gbEmail.TabIndex = 10;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // gbDiaChi
            // 
            this.gbDiaChi.Controls.Add(this.txtDiaChi);
            this.gbDiaChi.Location = new System.Drawing.Point(164, 90);
            this.gbDiaChi.Name = "gbDiaChi";
            this.gbDiaChi.Size = new System.Drawing.Size(134, 52);
            this.gbDiaChi.TabIndex = 9;
            this.gbDiaChi.TabStop = false;
            this.gbDiaChi.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(15, 19);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 0;
            // 
            // gbSDT
            // 
            this.gbSDT.Controls.Add(this.radNu);
            this.gbSDT.Controls.Add(this.radNam);
            this.gbSDT.Location = new System.Drawing.Point(9, 167);
            this.gbSDT.Name = "gbSDT";
            this.gbSDT.Size = new System.Drawing.Size(82, 70);
            this.gbSDT.TabIndex = 8;
            this.gbSDT.TabStop = false;
            this.gbSDT.Text = "Giới tính";
            // 
            // gbTenNCC
            // 
            this.gbTenNCC.Controls.Add(this.txtHoTen);
            this.gbTenNCC.Location = new System.Drawing.Point(9, 90);
            this.gbTenNCC.Name = "gbTenNCC";
            this.gbTenNCC.Size = new System.Drawing.Size(134, 52);
            this.gbTenNCC.TabIndex = 7;
            this.gbTenNCC.TabStop = false;
            this.gbTenNCC.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(15, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // gbMaNCC
            // 
            this.gbMaNCC.Controls.Add(this.txtMaNV);
            this.gbMaNCC.Location = new System.Drawing.Point(9, 32);
            this.gbMaNCC.Name = "gbMaNCC";
            this.gbMaNCC.Size = new System.Drawing.Size(134, 52);
            this.gbMaNCC.TabIndex = 6;
            this.gbMaNCC.TabStop = false;
            this.gbMaNCC.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(15, 19);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTonGiao);
            this.groupBox1.Location = new System.Drawing.Point(332, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 52);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tôn Giáo";
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Location = new System.Drawing.Point(15, 19);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.Size = new System.Drawing.Size(100, 20);
            this.txtTonGiao.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCMND);
            this.groupBox3.Location = new System.Drawing.Point(332, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 52);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(15, 19);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(100, 20);
            this.txtCMND.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbBoPhan);
            this.groupBox4.Location = new System.Drawing.Point(173, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 52);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mã Bộ phận";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbChucVu);
            this.groupBox5.Location = new System.Drawing.Point(323, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(134, 52);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mã Chức Vụ";
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(7, 16);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbChucVu.TabIndex = 0;
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(7, 16);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(121, 21);
            this.cbBoPhan.TabIndex = 24;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(9, 16);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(125, 20);
            this.dtpkNgaySinh.TabIndex = 0;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(15, 19);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(15, 43);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // UCQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTimKiemNV);
            this.Controls.Add(this.dtgvQLNV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCQuanLyNhanVien";
            this.Size = new System.Drawing.Size(900, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbTenCongTy.ResumeLayout(false);
            this.gbTenCongTy.PerformLayout();
            this.gbSTK.ResumeLayout(false);
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbDiaChi.ResumeLayout(false);
            this.gbDiaChi.PerformLayout();
            this.gbSDT.ResumeLayout(false);
            this.gbSDT.PerformLayout();
            this.gbTenNCC.ResumeLayout(false);
            this.gbTenNCC.PerformLayout();
            this.gbMaNCC.ResumeLayout(false);
            this.gbMaNCC.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgvQLNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnInsertChucVu;
        private System.Windows.Forms.Button btnRefeshChucVu;
        private System.Windows.Forms.DataGridView dtgvChucVu;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbTenCongTy;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox gbSTK;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox gbSDT;
        private System.Windows.Forms.GroupBox gbTenNCC;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox gbMaNCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTonGiao;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbBoPhan;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
    }
}
