namespace QLTSTBKhachSan.UI
{
    partial class UCQLNhaCungCap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvNCC = new System.Windows.Forms.DataGridView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbTenCongTy = new System.Windows.Forms.GroupBox();
            this.txtTenCongTy = new System.Windows.Forms.TextBox();
            this.gbSTK = new System.Windows.Forms.GroupBox();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbDiaChi = new System.Windows.Forms.GroupBox();
            this.cbDiaChi = new System.Windows.Forms.ComboBox();
            this.gbSDT = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.gbTenNCC = new System.Windows.Forms.GroupBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.gbMaNCC = new System.Windows.Forms.GroupBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gbTool = new System.Windows.Forms.GroupBox();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnDeleteNCC = new System.Windows.Forms.Button();
            this.btnUpdateNCC = new System.Windows.Forms.Button();
            this.btnInsertNhaCungCap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).BeginInit();
            this.gbInfo.SuspendLayout();
            this.gbTenCongTy.SuspendLayout();
            this.gbSTK.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbDiaChi.SuspendLayout();
            this.gbSDT.SuspendLayout();
            this.gbTenNCC.SuspendLayout();
            this.gbMaNCC.SuspendLayout();
            this.gbTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lí nhà cung cấp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(584, 37);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 22);
            this.txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(817, 30);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 37);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtgvNCC
            // 
            this.dtgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNCC.Location = new System.Drawing.Point(29, 447);
            this.dtgvNCC.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvNCC.Name = "dtgvNCC";
            this.dtgvNCC.ReadOnly = true;
            this.dtgvNCC.RowHeadersWidth = 51;
            this.dtgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNCC.Size = new System.Drawing.Size(1147, 219);
            this.dtgvNCC.TabIndex = 10;
            this.dtgvNCC.Click += new System.EventHandler(this.dtgvNCC_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.gbTenCongTy);
            this.gbInfo.Controls.Add(this.gbSTK);
            this.gbInfo.Controls.Add(this.gbEmail);
            this.gbInfo.Controls.Add(this.gbDiaChi);
            this.gbInfo.Controls.Add(this.gbSDT);
            this.gbInfo.Controls.Add(this.gbTenNCC);
            this.gbInfo.Controls.Add(this.gbMaNCC);
            this.gbInfo.Location = new System.Drawing.Point(17, 121);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbInfo.Size = new System.Drawing.Size(677, 309);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông Tin";
            this.gbInfo.Enter += new System.EventHandler(this.gbInfo_Enter);
            // 
            // gbTenCongTy
            // 
            this.gbTenCongTy.Controls.Add(this.txtTenCongTy);
            this.gbTenCongTy.Location = new System.Drawing.Point(449, 39);
            this.gbTenCongTy.Margin = new System.Windows.Forms.Padding(4);
            this.gbTenCongTy.Name = "gbTenCongTy";
            this.gbTenCongTy.Padding = new System.Windows.Forms.Padding(4);
            this.gbTenCongTy.Size = new System.Drawing.Size(179, 64);
            this.gbTenCongTy.TabIndex = 11;
            this.gbTenCongTy.TabStop = false;
            this.gbTenCongTy.Text = "Tên Công Ty";
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(20, 23);
            this.txtTenCongTy.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(132, 22);
            this.txtTenCongTy.TabIndex = 0;
            // 
            // gbSTK
            // 
            this.gbSTK.Controls.Add(this.txtSTK);
            this.gbSTK.Location = new System.Drawing.Point(219, 182);
            this.gbSTK.Margin = new System.Windows.Forms.Padding(4);
            this.gbSTK.Name = "gbSTK";
            this.gbSTK.Padding = new System.Windows.Forms.Padding(4);
            this.gbSTK.Size = new System.Drawing.Size(179, 64);
            this.gbSTK.TabIndex = 11;
            this.gbSTK.TabStop = false;
            this.gbSTK.Text = "Số Tài Khoản";
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(20, 23);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(132, 22);
            this.txtSTK.TabIndex = 0;
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txtEmail);
            this.gbEmail.Location = new System.Drawing.Point(219, 111);
            this.gbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Padding = new System.Windows.Forms.Padding(4);
            this.gbEmail.Size = new System.Drawing.Size(179, 64);
            this.gbEmail.TabIndex = 10;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(20, 23);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // gbDiaChi
            // 
            this.gbDiaChi.Controls.Add(this.cbDiaChi);
            this.gbDiaChi.Location = new System.Drawing.Point(219, 39);
            this.gbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.gbDiaChi.Name = "gbDiaChi";
            this.gbDiaChi.Padding = new System.Windows.Forms.Padding(4);
            this.gbDiaChi.Size = new System.Drawing.Size(179, 64);
            this.gbDiaChi.TabIndex = 9;
            this.gbDiaChi.TabStop = false;
            this.gbDiaChi.Text = "Địa Chỉ";
            // 
            // cbDiaChi
            // 
            this.cbDiaChi.FormattingEnabled = true;
            this.cbDiaChi.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa-Vũng Tàu",
            "Bạc Liêu",
            "Bắc Kạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ (TP)",
            "Đà Nẵng (TP)",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội (TP)",
            "Hà Tây",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng (TP)",
            "Hòa Bình",
            "Hồ Chí Minh (TP)",
            "Hậu Giang",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên – Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái",
            ""});
            this.cbDiaChi.Location = new System.Drawing.Point(8, 22);
            this.cbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiaChi.Name = "cbDiaChi";
            this.cbDiaChi.Size = new System.Drawing.Size(148, 24);
            this.cbDiaChi.TabIndex = 0;
            // 
            // gbSDT
            // 
            this.gbSDT.Controls.Add(this.txtSDT);
            this.gbSDT.Location = new System.Drawing.Point(12, 182);
            this.gbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.gbSDT.Name = "gbSDT";
            this.gbSDT.Padding = new System.Windows.Forms.Padding(4);
            this.gbSDT.Size = new System.Drawing.Size(179, 64);
            this.gbSDT.TabIndex = 8;
            this.gbSDT.TabStop = false;
            this.gbSDT.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(20, 23);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(132, 22);
            this.txtSDT.TabIndex = 0;
            // 
            // gbTenNCC
            // 
            this.gbTenNCC.Controls.Add(this.txtTenNCC);
            this.gbTenNCC.Location = new System.Drawing.Point(12, 111);
            this.gbTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.gbTenNCC.Name = "gbTenNCC";
            this.gbTenNCC.Padding = new System.Windows.Forms.Padding(4);
            this.gbTenNCC.Size = new System.Drawing.Size(179, 64);
            this.gbTenNCC.TabIndex = 7;
            this.gbTenNCC.TabStop = false;
            this.gbTenNCC.Text = "Tên Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(20, 23);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(132, 22);
            this.txtTenNCC.TabIndex = 0;
            // 
            // gbMaNCC
            // 
            this.gbMaNCC.Controls.Add(this.txtMaNCC);
            this.gbMaNCC.Location = new System.Drawing.Point(12, 39);
            this.gbMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.gbMaNCC.Name = "gbMaNCC";
            this.gbMaNCC.Padding = new System.Windows.Forms.Padding(4);
            this.gbMaNCC.Size = new System.Drawing.Size(179, 64);
            this.gbMaNCC.TabIndex = 6;
            this.gbMaNCC.TabStop = false;
            this.gbMaNCC.Text = "Mã Nhà Cung Cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(20, 23);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(132, 22);
            this.txtMaNCC.TabIndex = 0;
            // 
            // gbTool
            // 
            this.gbTool.Controls.Add(this.btnRefesh);
            this.gbTool.Controls.Add(this.btnDeleteNCC);
            this.gbTool.Controls.Add(this.btnUpdateNCC);
            this.gbTool.Controls.Add(this.btnInsertNhaCungCap);
            this.gbTool.Location = new System.Drawing.Point(715, 121);
            this.gbTool.Margin = new System.Windows.Forms.Padding(4);
            this.gbTool.Name = "gbTool";
            this.gbTool.Padding = new System.Windows.Forms.Padding(4);
            this.gbTool.Size = new System.Drawing.Size(261, 142);
            this.gbTool.TabIndex = 12;
            this.gbTool.TabStop = false;
            this.gbTool.Text = "Tool";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(156, 81);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(85, 37);
            this.btnRefesh.TabIndex = 17;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnDeleteNCC
            // 
            this.btnDeleteNCC.Location = new System.Drawing.Point(40, 81);
            this.btnDeleteNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteNCC.Name = "btnDeleteNCC";
            this.btnDeleteNCC.Size = new System.Drawing.Size(85, 37);
            this.btnDeleteNCC.TabIndex = 16;
            this.btnDeleteNCC.Text = "Xoá";
            this.btnDeleteNCC.UseVisualStyleBackColor = true;
            this.btnDeleteNCC.Click += new System.EventHandler(this.btnDeleteNCC_Click);
            // 
            // btnUpdateNCC
            // 
            this.btnUpdateNCC.Location = new System.Drawing.Point(156, 22);
            this.btnUpdateNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateNCC.Name = "btnUpdateNCC";
            this.btnUpdateNCC.Size = new System.Drawing.Size(85, 37);
            this.btnUpdateNCC.TabIndex = 15;
            this.btnUpdateNCC.Text = "Sửa";
            this.btnUpdateNCC.UseVisualStyleBackColor = true;
            this.btnUpdateNCC.Click += new System.EventHandler(this.btnUpdateNCC_Click);
            // 
            // btnInsertNhaCungCap
            // 
            this.btnInsertNhaCungCap.Location = new System.Drawing.Point(40, 22);
            this.btnInsertNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertNhaCungCap.Name = "btnInsertNhaCungCap";
            this.btnInsertNhaCungCap.Size = new System.Drawing.Size(85, 37);
            this.btnInsertNhaCungCap.TabIndex = 14;
            this.btnInsertNhaCungCap.Text = "Thêm";
            this.btnInsertNhaCungCap.UseVisualStyleBackColor = true;
            this.btnInsertNhaCungCap.Click += new System.EventHandler(this.btnInsertNhaCungCap_Click);
            // 
            // UCQLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTool);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dtgvNCC);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCQLNhaCungCap";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.UCQLNhaCungCap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCQLNhaCungCap_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbTenCongTy.ResumeLayout(false);
            this.gbTenCongTy.PerformLayout();
            this.gbSTK.ResumeLayout(false);
            this.gbSTK.PerformLayout();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbDiaChi.ResumeLayout(false);
            this.gbSDT.ResumeLayout(false);
            this.gbSDT.PerformLayout();
            this.gbTenNCC.ResumeLayout(false);
            this.gbTenNCC.PerformLayout();
            this.gbMaNCC.ResumeLayout(false);
            this.gbMaNCC.PerformLayout();
            this.gbTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvNCC;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.GroupBox gbMaNCC;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox gbTenNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.GroupBox gbSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox gbDiaChi;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbSTK;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.GroupBox gbTenCongTy;
        private System.Windows.Forms.TextBox txtTenCongTy;
        private System.Windows.Forms.GroupBox gbTool;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnDeleteNCC;
        private System.Windows.Forms.Button btnUpdateNCC;
        private System.Windows.Forms.Button btnInsertNhaCungCap;
        private System.Windows.Forms.ComboBox cbDiaChi;
    }
}
