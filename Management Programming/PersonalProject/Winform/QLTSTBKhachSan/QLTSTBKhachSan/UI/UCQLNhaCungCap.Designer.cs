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
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.gbSDT = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.gbTenNCC = new System.Windows.Forms.GroupBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.gbMaNCC = new System.Windows.Forms.GroupBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gbTool = new System.Windows.Forms.GroupBox();
            this.btnInsertNhaCungCap = new System.Windows.Forms.Button();
            this.btnUpdateNCC = new System.Windows.Forms.Button();
            this.btnDeleteNCC = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản lí nhà cung cấp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(438, 30);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(162, 20);
            this.txtTimKiem.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(613, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 30);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtgvNCC
            // 
            this.dtgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNCC.Location = new System.Drawing.Point(22, 363);
            this.dtgvNCC.Name = "dtgvNCC";
            this.dtgvNCC.ReadOnly = true;
            this.dtgvNCC.RowHeadersWidth = 51;
            this.dtgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNCC.Size = new System.Drawing.Size(860, 178);
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
            this.gbInfo.Location = new System.Drawing.Point(13, 98);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(508, 251);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông Tin";
            // 
            // gbTenCongTy
            // 
            this.gbTenCongTy.Controls.Add(this.txtTenCongTy);
            this.gbTenCongTy.Location = new System.Drawing.Point(337, 32);
            this.gbTenCongTy.Name = "gbTenCongTy";
            this.gbTenCongTy.Size = new System.Drawing.Size(134, 52);
            this.gbTenCongTy.TabIndex = 11;
            this.gbTenCongTy.TabStop = false;
            this.gbTenCongTy.Text = "Tên Công Ty";
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Location = new System.Drawing.Point(15, 19);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.Size = new System.Drawing.Size(100, 20);
            this.txtTenCongTy.TabIndex = 0;
            // 
            // gbSTK
            // 
            this.gbSTK.Controls.Add(this.txtSTK);
            this.gbSTK.Location = new System.Drawing.Point(164, 148);
            this.gbSTK.Name = "gbSTK";
            this.gbSTK.Size = new System.Drawing.Size(134, 52);
            this.gbSTK.TabIndex = 11;
            this.gbSTK.TabStop = false;
            this.gbSTK.Text = "Số Tài Khoản";
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(15, 19);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(100, 20);
            this.txtSTK.TabIndex = 0;
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txtEmail);
            this.gbEmail.Location = new System.Drawing.Point(164, 90);
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
            this.gbDiaChi.Location = new System.Drawing.Point(164, 32);
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
            this.gbSDT.Controls.Add(this.txtSDT);
            this.gbSDT.Location = new System.Drawing.Point(9, 148);
            this.gbSDT.Name = "gbSDT";
            this.gbSDT.Size = new System.Drawing.Size(134, 52);
            this.gbSDT.TabIndex = 8;
            this.gbSDT.TabStop = false;
            this.gbSDT.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(15, 19);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 0;
            // 
            // gbTenNCC
            // 
            this.gbTenNCC.Controls.Add(this.txtTenNCC);
            this.gbTenNCC.Location = new System.Drawing.Point(9, 90);
            this.gbTenNCC.Name = "gbTenNCC";
            this.gbTenNCC.Size = new System.Drawing.Size(134, 52);
            this.gbTenNCC.TabIndex = 7;
            this.gbTenNCC.TabStop = false;
            this.gbTenNCC.Text = "Tên Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(15, 19);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(100, 20);
            this.txtTenNCC.TabIndex = 0;
            // 
            // gbMaNCC
            // 
            this.gbMaNCC.Controls.Add(this.txtMaNCC);
            this.gbMaNCC.Location = new System.Drawing.Point(9, 32);
            this.gbMaNCC.Name = "gbMaNCC";
            this.gbMaNCC.Size = new System.Drawing.Size(134, 52);
            this.gbMaNCC.TabIndex = 6;
            this.gbMaNCC.TabStop = false;
            this.gbMaNCC.Text = "Mã Nhà Cung Cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(15, 19);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(100, 20);
            this.txtMaNCC.TabIndex = 0;
            // 
            // gbTool
            // 
            this.gbTool.Controls.Add(this.btnRefesh);
            this.gbTool.Controls.Add(this.btnDeleteNCC);
            this.gbTool.Controls.Add(this.btnUpdateNCC);
            this.gbTool.Controls.Add(this.btnInsertNhaCungCap);
            this.gbTool.Location = new System.Drawing.Point(536, 98);
            this.gbTool.Name = "gbTool";
            this.gbTool.Size = new System.Drawing.Size(196, 115);
            this.gbTool.TabIndex = 12;
            this.gbTool.TabStop = false;
            this.gbTool.Text = "Tool";
            // 
            // btnInsertNhaCungCap
            // 
            this.btnInsertNhaCungCap.Location = new System.Drawing.Point(30, 18);
            this.btnInsertNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertNhaCungCap.Name = "btnInsertNhaCungCap";
            this.btnInsertNhaCungCap.Size = new System.Drawing.Size(64, 30);
            this.btnInsertNhaCungCap.TabIndex = 14;
            this.btnInsertNhaCungCap.Text = "Thêm";
            this.btnInsertNhaCungCap.UseVisualStyleBackColor = true;
            this.btnInsertNhaCungCap.Click += new System.EventHandler(this.btnInsertNhaCungCap_Click);
            // 
            // btnUpdateNCC
            // 
            this.btnUpdateNCC.Location = new System.Drawing.Point(117, 18);
            this.btnUpdateNCC.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateNCC.Name = "btnUpdateNCC";
            this.btnUpdateNCC.Size = new System.Drawing.Size(64, 30);
            this.btnUpdateNCC.TabIndex = 15;
            this.btnUpdateNCC.Text = "Sửa";
            this.btnUpdateNCC.UseVisualStyleBackColor = true;
            this.btnUpdateNCC.Click += new System.EventHandler(this.btnUpdateNCC_Click);
            // 
            // btnDeleteNCC
            // 
            this.btnDeleteNCC.Location = new System.Drawing.Point(30, 66);
            this.btnDeleteNCC.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNCC.Name = "btnDeleteNCC";
            this.btnDeleteNCC.Size = new System.Drawing.Size(64, 30);
            this.btnDeleteNCC.TabIndex = 16;
            this.btnDeleteNCC.Text = "Xoá";
            this.btnDeleteNCC.UseVisualStyleBackColor = true;
            this.btnDeleteNCC.Click += new System.EventHandler(this.btnDeleteNCC_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(117, 66);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(64, 30);
            this.btnRefesh.TabIndex = 17;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.UseVisualStyleBackColor = true;
            // 
            // UCQLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTool);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dtgvNCC);
            this.Controls.Add(this.panel1);
            this.Name = "UCQLNhaCungCap";
            this.Size = new System.Drawing.Size(900, 569);
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
            this.gbDiaChi.PerformLayout();
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
        private System.Windows.Forms.TextBox txtDiaChi;
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
    }
}
