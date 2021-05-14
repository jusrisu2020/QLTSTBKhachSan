
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvQLND = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDTGVND = new System.Windows.Forms.Panel();
            this.pnAddUser = new System.Windows.Forms.Panel();
            this.btnShowChucVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemAnh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.gbTenHienThi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTenHienThi = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnShowChucVu = new System.Windows.Forms.Panel();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbMaCV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbMaCV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbTenTK = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTenTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.gbMaNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).BeginInit();
            this.pnDTGVND.SuspendLayout();
            this.pnAddUser.SuspendLayout();
            this.gbTenHienThi.SuspendLayout();
            this.pnShowChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.gbMaCV.SuspendLayout();
            this.gbTenTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            this.gbMaNV.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(567, 8);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(64, 30);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Search...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtgvQLND
            // 
            this.dtgvQLND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQLND.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQLND.ColumnHeadersHeight = 50;
            this.dtgvQLND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvQLND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaTK,
            this.HinhAnh,
            this.MaNV,
            this.TenTK,
            this.TenHienThi,
            this.Pass,
            this.MaCV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQLND.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvQLND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQLND.GridColor = System.Drawing.Color.White;
            this.dtgvQLND.Location = new System.Drawing.Point(0, 0);
            this.dtgvQLND.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvQLND.Name = "dtgvQLND";
            this.dtgvQLND.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLND.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvQLND.RowHeadersVisible = false;
            this.dtgvQLND.RowHeadersWidth = 100;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvQLND.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvQLND.RowTemplate.Height = 100;
            this.dtgvQLND.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLND.Size = new System.Drawing.Size(1000, 474);
            this.dtgvQLND.TabIndex = 7;
            this.dtgvQLND.Click += new System.EventHandler(this.dtgvQLND_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MaTK
            // 
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã Tài Khoản";
            this.MaTK.Name = "MaTK";
            this.MaTK.ReadOnly = true;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TenTK";
            this.TenTK.HeaderText = "Tên Tài Khoản";
            this.TenTK.Name = "TenTK";
            this.TenTK.ReadOnly = true;
            // 
            // TenHienThi
            // 
            this.TenHienThi.DataPropertyName = "TenHienThi";
            this.TenHienThi.HeaderText = "Tên Hiển Thị";
            this.TenHienThi.Name = "TenHienThi";
            this.TenHienThi.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "Pass";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            this.Pass.Visible = false;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // pnDTGVND
            // 
            this.pnDTGVND.Controls.Add(this.dtgvQLND);
            this.pnDTGVND.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDTGVND.Location = new System.Drawing.Point(0, 126);
            this.pnDTGVND.Margin = new System.Windows.Forms.Padding(2);
            this.pnDTGVND.Name = "pnDTGVND";
            this.pnDTGVND.Size = new System.Drawing.Size(1000, 474);
            this.pnDTGVND.TabIndex = 12;
            // 
            // pnAddUser
            // 
            this.pnAddUser.Controls.Add(this.btnShowChucVu);
            this.pnAddUser.Controls.Add(this.btnThemAnh);
            this.pnAddUser.Controls.Add(this.guna2Button2);
            this.pnAddUser.Controls.Add(this.gbTenHienThi);
            this.pnAddUser.Controls.Add(this.pnShowChucVu);
            this.pnAddUser.Controls.Add(this.guna2GroupBox2);
            this.pnAddUser.Controls.Add(this.gbMaCV);
            this.pnAddUser.Controls.Add(this.gbTenTK);
            this.pnAddUser.Controls.Add(this.picInput);
            this.pnAddUser.Controls.Add(this.gbMaNV);
            this.pnAddUser.Location = new System.Drawing.Point(25, 105);
            this.pnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnAddUser.Name = "pnAddUser";
            this.pnAddUser.Size = new System.Drawing.Size(640, 297);
            this.pnAddUser.TabIndex = 17;
            this.pnAddUser.Visible = false;
            // 
            // btnShowChucVu
            // 
            this.btnShowChucVu.BorderRadius = 8;
            this.btnShowChucVu.CheckedState.Parent = this.btnShowChucVu;
            this.btnShowChucVu.CustomImages.Parent = this.btnShowChucVu;
            this.btnShowChucVu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowChucVu.ForeColor = System.Drawing.Color.White;
            this.btnShowChucVu.HoverState.Parent = this.btnShowChucVu;
            this.btnShowChucVu.Image = global::QLTSTBKhachSan.Properties.Resources.add_32px;
            this.btnShowChucVu.Location = new System.Drawing.Point(283, 6);
            this.btnShowChucVu.Name = "btnShowChucVu";
            this.btnShowChucVu.ShadowDecoration.Parent = this.btnShowChucVu;
            this.btnShowChucVu.Size = new System.Drawing.Size(113, 35);
            this.btnShowChucVu.TabIndex = 37;
            this.btnShowChucVu.Text = "Chức Vụ";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.BorderRadius = 8;
            this.btnThemAnh.CheckedState.Parent = this.btnThemAnh;
            this.btnThemAnh.CustomImages.Parent = this.btnThemAnh;
            this.btnThemAnh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemAnh.ForeColor = System.Drawing.Color.White;
            this.btnThemAnh.HoverState.Parent = this.btnThemAnh;
            this.btnThemAnh.Image = global::QLTSTBKhachSan.Properties.Resources.image_file_26px;
            this.btnThemAnh.Location = new System.Drawing.Point(524, 126);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.ShadowDecoration.Parent = this.btnThemAnh;
            this.btnThemAnh.Size = new System.Drawing.Size(113, 35);
            this.btnThemAnh.TabIndex = 36;
            this.btnThemAnh.Text = "Thêm Ảnh";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::QLTSTBKhachSan.Properties.Resources.add_32px;
            this.guna2Button2.Location = new System.Drawing.Point(527, 259);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(113, 35);
            this.guna2Button2.TabIndex = 30;
            this.guna2Button2.Text = "Thêm";
            this.guna2Button2.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // gbTenHienThi
            // 
            this.gbTenHienThi.BorderRadius = 5;
            this.gbTenHienThi.Controls.Add(this.txtTenHienThi);
            this.gbTenHienThi.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbTenHienThi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTenHienThi.ForeColor = System.Drawing.Color.White;
            this.gbTenHienThi.Location = new System.Drawing.Point(3, 200);
            this.gbTenHienThi.Name = "gbTenHienThi";
            this.gbTenHienThi.ShadowDecoration.Parent = this.gbTenHienThi;
            this.gbTenHienThi.Size = new System.Drawing.Size(134, 94);
            this.gbTenHienThi.TabIndex = 35;
            this.gbTenHienThi.Text = "Tên Hiển Thị";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHienThi.DefaultText = "";
            this.txtTenHienThi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenHienThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenHienThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHienThi.DisabledState.Parent = this.txtTenHienThi;
            this.txtTenHienThi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenHienThi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHienThi.FocusedState.Parent = this.txtTenHienThi;
            this.txtTenHienThi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenHienThi.HoverState.Parent = this.txtTenHienThi;
            this.txtTenHienThi.Location = new System.Drawing.Point(5, 48);
            this.txtTenHienThi.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.PasswordChar = '\0';
            this.txtTenHienThi.PlaceholderText = "";
            this.txtTenHienThi.SelectedText = "";
            this.txtTenHienThi.ShadowDecoration.Parent = this.txtTenHienThi;
            this.txtTenHienThi.Size = new System.Drawing.Size(124, 35);
            this.txtTenHienThi.TabIndex = 31;
            // 
            // pnShowChucVu
            // 
            this.pnShowChucVu.Controls.Add(this.dtgvChucVu);
            this.pnShowChucVu.Location = new System.Drawing.Point(283, 42);
            this.pnShowChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.pnShowChucVu.Name = "pnShowChucVu";
            this.pnShowChucVu.Size = new System.Drawing.Size(166, 130);
            this.pnShowChucVu.TabIndex = 22;
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(2, 5);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.ReadOnly = true;
            this.dtgvChucVu.RowHeadersVisible = false;
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.RowTemplate.Height = 24;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(156, 114);
            this.dtgvChucVu.TabIndex = 21;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 5;
            this.guna2GroupBox2.Controls.Add(this.txtPass);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(143, 103);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(134, 94);
            this.guna2GroupBox2.TabIndex = 34;
            this.guna2GroupBox2.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.Location = new System.Drawing.Point(8, 49);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(117, 38);
            this.txtPass.TabIndex = 31;
            // 
            // gbMaCV
            // 
            this.gbMaCV.BorderRadius = 5;
            this.gbMaCV.Controls.Add(this.cbMaCV);
            this.gbMaCV.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbMaCV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMaCV.ForeColor = System.Drawing.Color.White;
            this.gbMaCV.Location = new System.Drawing.Point(143, 3);
            this.gbMaCV.Name = "gbMaCV";
            this.gbMaCV.ShadowDecoration.Parent = this.gbMaCV;
            this.gbMaCV.Size = new System.Drawing.Size(134, 94);
            this.gbMaCV.TabIndex = 33;
            this.gbMaCV.Text = "Mã Chức Vụ";
            // 
            // cbMaCV
            // 
            this.cbMaCV.BackColor = System.Drawing.Color.Transparent;
            this.cbMaCV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaCV.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaCV.FocusedState.Parent = this.cbMaCV;
            this.cbMaCV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaCV.FormattingEnabled = true;
            this.cbMaCV.HoverState.Parent = this.cbMaCV;
            this.cbMaCV.ItemHeight = 30;
            this.cbMaCV.ItemsAppearance.Parent = this.cbMaCV;
            this.cbMaCV.Location = new System.Drawing.Point(11, 48);
            this.cbMaCV.Name = "cbMaCV";
            this.cbMaCV.ShadowDecoration.Parent = this.cbMaCV;
            this.cbMaCV.Size = new System.Drawing.Size(113, 36);
            this.cbMaCV.TabIndex = 31;
            // 
            // gbTenTK
            // 
            this.gbTenTK.BorderRadius = 5;
            this.gbTenTK.Controls.Add(this.txtTenTK);
            this.gbTenTK.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbTenTK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTenTK.ForeColor = System.Drawing.Color.White;
            this.gbTenTK.Location = new System.Drawing.Point(3, 103);
            this.gbTenTK.Name = "gbTenTK";
            this.gbTenTK.ShadowDecoration.Parent = this.gbTenTK;
            this.gbTenTK.Size = new System.Drawing.Size(134, 94);
            this.gbTenTK.TabIndex = 34;
            this.gbTenTK.Text = "Tên Tài Khoản";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTK.DefaultText = "";
            this.txtTenTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.DisabledState.Parent = this.txtTenTK;
            this.txtTenTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.FocusedState.Parent = this.txtTenTK;
            this.txtTenTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.HoverState.Parent = this.txtTenTK;
            this.txtTenTK.Location = new System.Drawing.Point(7, 49);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.PasswordChar = '\0';
            this.txtTenTK.PlaceholderText = "";
            this.txtTenTK.SelectedText = "";
            this.txtTenTK.ShadowDecoration.Parent = this.txtTenTK;
            this.txtTenTK.Size = new System.Drawing.Size(115, 39);
            this.txtTenTK.TabIndex = 30;
            // 
            // picInput
            // 
            this.picInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picInput.Location = new System.Drawing.Point(454, 6);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(183, 114);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInput.TabIndex = 23;
            this.picInput.TabStop = false;
            this.picInput.Tag = "sdf";
            this.picInput.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // gbMaNV
            // 
            this.gbMaNV.BorderRadius = 5;
            this.gbMaNV.Controls.Add(this.cbMaNV);
            this.gbMaNV.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbMaNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMaNV.ForeColor = System.Drawing.Color.White;
            this.gbMaNV.Location = new System.Drawing.Point(3, 3);
            this.gbMaNV.Name = "gbMaNV";
            this.gbMaNV.ShadowDecoration.Parent = this.gbMaNV;
            this.gbMaNV.Size = new System.Drawing.Size(134, 94);
            this.gbMaNV.TabIndex = 32;
            this.gbMaNV.Text = "Mã Nhân Viên";
            // 
            // cbMaNV
            // 
            this.cbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cbMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaNV.FocusedState.Parent = this.cbMaNV;
            this.cbMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.HoverState.Parent = this.cbMaNV;
            this.cbMaNV.ItemHeight = 30;
            this.cbMaNV.ItemsAppearance.Parent = this.cbMaNV;
            this.cbMaNV.Location = new System.Drawing.Point(9, 48);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.ShadowDecoration.Parent = this.cbMaNV;
            this.cbMaNV.Size = new System.Drawing.Size(113, 36);
            this.cbMaNV.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel6.Controls.Add(this.lbTitle);
            this.panel6.Controls.Add(this.btnTimKiem);
            this.panel6.Controls.Add(this.txtTimKiem);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(1000, 52);
            this.panel6.TabIndex = 27;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(20, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(166, 25);
            this.lbTitle.TabIndex = 28;
            this.lbTitle.Text = "Adminastrator";
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
            this.txtTimKiem.Location = new System.Drawing.Point(269, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Search.....";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(280, 30);
            this.txtTimKiem.TabIndex = 25;
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::QLTSTBKhachSan.Properties.Resources.delete_30px;
            this.btnXoa.Location = new System.Drawing.Point(158, 58);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(127, 42);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BorderRadius = 8;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Image = global::QLTSTBKhachSan.Properties.Resources.add_32px;
            this.btnAddUser.Location = new System.Drawing.Point(25, 58);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(127, 42);
            this.btnAddUser.TabIndex = 29;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UCQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnAddUser);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnDTGVND);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCQuanLyNguoiDung";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLND)).EndInit();
            this.pnDTGVND.ResumeLayout(false);
            this.pnAddUser.ResumeLayout(false);
            this.gbTenHienThi.ResumeLayout(false);
            this.pnShowChucVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.gbMaCV.ResumeLayout(false);
            this.gbTenTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            this.gbMaNV.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvQLND;
        private System.Windows.Forms.Panel pnDTGVND;
        private System.Windows.Forms.Panel pnAddUser;
        private System.Windows.Forms.DataGridView dtgvChucVu;
        private System.Windows.Forms.Panel pnShowChucVu;
        private System.Windows.Forms.PictureBox picInput;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaNV;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaCV;
        private Guna.UI2.WinForms.Guna2GroupBox gbMaNV;
        private Guna.UI2.WinForms.Guna2GroupBox gbMaCV;
        private Guna.UI2.WinForms.Guna2GroupBox gbTenTK;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTK;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2GroupBox gbTenHienThi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenHienThi;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThemAnh;
        private Guna.UI2.WinForms.Guna2Button btnShowChucVu;
    }
}
