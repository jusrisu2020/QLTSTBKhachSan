
namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLyNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.dtgvQLND = new System.Windows.Forms.DataGridView();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbMaCV = new System.Windows.Forms.ComboBox();
            this.btnShowChucVu = new System.Windows.Forms.Button();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            this.pnShowChucVu = new System.Windows.Forms.Panel();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLSThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.btnList = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.pnShowChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(485, 330);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(97, 23);
            this.btnThemTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(76, 40);
            this.btnThemTaiKhoan.TabIndex = 2;
            this.btnThemTaiKhoan.Text = "Create User";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // dtgvQLND
            // 
            this.dtgvQLND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQLND.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvQLND.Location = new System.Drawing.Point(6, 13);
            this.dtgvQLND.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQLND.Name = "dtgvQLND";
            this.dtgvQLND.ReadOnly = true;
            this.dtgvQLND.RowHeadersVisible = false;
            this.dtgvQLND.RowHeadersWidth = 100;
            this.dtgvQLND.RowTemplate.Height = 24;
            this.dtgvQLND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLND.Size = new System.Drawing.Size(948, 169);
            this.dtgvQLND.TabIndex = 7;
            this.dtgvQLND.Click += new System.EventHandler(this.dtgvQLND_Click);
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(18, 2);
            this.btnSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(76, 40);
            this.btnSuaTaiKhoan.TabIndex = 11;
            this.btnSuaTaiKhoan.Text = "Thêm Tài Khoản";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvQLND);
            this.panel2.Location = new System.Drawing.Point(10, 392);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 194);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnThemTaiKhoan);
            this.panel4.Controls.Add(this.btnSuaTaiKhoan);
            this.panel4.Location = new System.Drawing.Point(697, 85);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 132);
            this.panel4.TabIndex = 16;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(2, 88);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(2, 45);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMaTK);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Location = new System.Drawing.Point(47, 150);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 210);
            this.panel3.TabIndex = 17;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Enabled = false;
            this.txtMaTK.Location = new System.Drawing.Point(158, 146);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(100, 20);
            this.txtMaTK.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenHienThi);
            this.groupBox1.Location = new System.Drawing.Point(10, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tên hiển thị";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(6, 19);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(100, 20);
            this.txtTenHienThi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaNV);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 52);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã Nhân Viên";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(6, 19);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(106, 21);
            this.cbMaNV.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Location = new System.Drawing.Point(152, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 52);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "pass";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 19);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTenTK);
            this.groupBox4.Location = new System.Drawing.Point(10, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 52);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên Tài Khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(6, 19);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(100, 20);
            this.txtTenTK.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbMaCV);
            this.groupBox5.Location = new System.Drawing.Point(152, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 52);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Vụ";
            // 
            // cbMaCV
            // 
            this.cbMaCV.FormattingEnabled = true;
            this.cbMaCV.Location = new System.Drawing.Point(6, 19);
            this.cbMaCV.Name = "cbMaCV";
            this.cbMaCV.Size = new System.Drawing.Size(100, 21);
            this.cbMaCV.TabIndex = 12;
            // 
            // btnShowChucVu
            // 
            this.btnShowChucVu.Location = new System.Drawing.Point(310, 84);
            this.btnShowChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowChucVu.Name = "btnShowChucVu";
            this.btnShowChucVu.Size = new System.Drawing.Size(79, 29);
            this.btnShowChucVu.TabIndex = 20;
            this.btnShowChucVu.Text = "Chức Vụ Info";
            this.btnShowChucVu.UseVisualStyleBackColor = true;
            this.btnShowChucVu.Click += new System.EventHandler(this.btnShowChucVu_Click);
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChucVu.Location = new System.Drawing.Point(0, 0);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.ReadOnly = true;
            this.dtgvChucVu.RowHeadersVisible = false;
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(223, 114);
            this.dtgvChucVu.TabIndex = 21;
            // 
            // pnShowChucVu
            // 
            this.pnShowChucVu.Controls.Add(this.dtgvChucVu);
            this.pnShowChucVu.Location = new System.Drawing.Point(310, 128);
            this.pnShowChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.pnShowChucVu.Name = "pnShowChucVu";
            this.pnShowChucVu.Size = new System.Drawing.Size(223, 114);
            this.pnShowChucVu.TabIndex = 22;
            // 
            // picOutput
            // 
            this.picOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picOutput.Location = new System.Drawing.Point(551, 188);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(116, 70);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOutput.TabIndex = 24;
            this.picOutput.TabStop = false;
            this.picOutput.Tag = "sdf";
            // 
            // picInput
            // 
            this.picInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picInput.Location = new System.Drawing.Point(551, 108);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(116, 70);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInput.TabIndex = 23;
            this.picInput.TabStop = false;
            this.picInput.Tag = "sdf";
            this.picInput.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 10;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.IconLeft = global::QLTSTBKhachSan.Properties.Resources.IconSearch;
            this.txtTimKiem.Location = new System.Drawing.Point(25, 68);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Search.....";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(280, 30);
            this.txtTimKiem.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(1000, 5);
            this.panel5.TabIndex = 25;
            // 
            // btnLSThongBao
            // 
            this.btnLSThongBao.CheckedState.Parent = this.btnLSThongBao;
            this.btnLSThongBao.CustomImages.Parent = this.btnLSThongBao;
            this.btnLSThongBao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnLSThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLSThongBao.ForeColor = System.Drawing.Color.White;
            this.btnLSThongBao.HoverState.Parent = this.btnLSThongBao;
            this.btnLSThongBao.Image = global::QLTSTBKhachSan.Properties.Resources.bell_26px1;
            this.btnLSThongBao.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLSThongBao.Location = new System.Drawing.Point(834, 231);
            this.btnLSThongBao.Name = "btnLSThongBao";
            this.btnLSThongBao.ShadowDecoration.Parent = this.btnLSThongBao;
            this.btnLSThongBao.Size = new System.Drawing.Size(64, 41);
            this.btnLSThongBao.TabIndex = 15;
            // 
            // btnList
            // 
            this.btnList.CheckedState.Parent = this.btnList;
            this.btnList.CustomImages.Parent = this.btnList;
            this.btnList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.HoverState.Parent = this.btnList;
            this.btnList.Image = global::QLTSTBKhachSan.Properties.Resources.list_32px;
            this.btnList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnList.Location = new System.Drawing.Point(900, 222);
            this.btnList.Name = "btnList";
            this.btnList.ShadowDecoration.Parent = this.btnList;
            this.btnList.Size = new System.Drawing.Size(64, 41);
            this.btnList.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 595);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1000, 5);
            this.panel1.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(1000, 52);
            this.panel6.TabIndex = 27;
            // 
            // UCQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.picOutput);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnLSThongBao);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.pnShowChucVu);
            this.Controls.Add(this.btnShowChucVu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.UCQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.pnShowChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvQLND;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbMaCV;
        private System.Windows.Forms.Button btnShowChucVu;
        private System.Windows.Forms.DataGridView dtgvChucVu;
        private System.Windows.Forms.Panel pnShowChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.PictureBox picOutput;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnLSThongBao;
        private Guna.UI2.WinForms.Guna2Button btnList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
    }
}
