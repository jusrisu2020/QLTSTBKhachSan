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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnNew = new System.Windows.Forms.Panel();
            this.gbTenCongTy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTenCongTy = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemNCC = new Guna.UI2.WinForms.Guna2Button();
            this.gbEmail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbSTK = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbSDT = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbDiaChi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbDiaChi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbTenNCC = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvNCC = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCongTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDTGV = new System.Windows.Forms.Panel();
            this.pnTitle.SuspendLayout();
            this.pnNew.SuspendLayout();
            this.gbTenCongTy.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbSTK.SuspendLayout();
            this.gbSDT.SuspendLayout();
            this.gbDiaChi.SuspendLayout();
            this.gbTenNCC.SuspendLayout();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).BeginInit();
            this.pnDTGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnTitle.Controls.Add(this.btnSearch);
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Controls.Add(this.txtSearch);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.pnTitle.Size = new System.Drawing.Size(1000, 67);
            this.pnTitle.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::QLTSTBKhachSan.Properties.Resources.search_26px;
            this.btnSearch.Location = new System.Drawing.Point(850, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(99, 30);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(61, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(193, 31);
            this.lbTitle.TabIndex = 28;
            this.lbTitle.Text = "Nhà Cung Cấp";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = global::QLTSTBKhachSan.Properties.Resources.IconSearch;
            this.txtSearch.Location = new System.Drawing.Point(563, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search.....";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(280, 30);
            this.txtSearch.TabIndex = 25;
            // 
            // pnNew
            // 
            this.pnNew.Controls.Add(this.gbTenCongTy);
            this.pnNew.Controls.Add(this.btnThemNCC);
            this.pnNew.Controls.Add(this.gbEmail);
            this.pnNew.Controls.Add(this.gbSTK);
            this.pnNew.Controls.Add(this.gbSDT);
            this.pnNew.Controls.Add(this.gbDiaChi);
            this.pnNew.Controls.Add(this.gbTenNCC);
            this.pnNew.Location = new System.Drawing.Point(2, 112);
            this.pnNew.Margin = new System.Windows.Forms.Padding(2);
            this.pnNew.Name = "pnNew";
            this.pnNew.Size = new System.Drawing.Size(476, 245);
            this.pnNew.TabIndex = 39;
            this.pnNew.Visible = false;
            // 
            // gbTenCongTy
            // 
            this.gbTenCongTy.BorderRadius = 5;
            this.gbTenCongTy.Controls.Add(this.txtTenCongTy);
            this.gbTenCongTy.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbTenCongTy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTenCongTy.ForeColor = System.Drawing.Color.White;
            this.gbTenCongTy.Location = new System.Drawing.Point(294, 103);
            this.gbTenCongTy.Name = "gbTenCongTy";
            this.gbTenCongTy.ShadowDecoration.Parent = this.gbTenCongTy;
            this.gbTenCongTy.Size = new System.Drawing.Size(172, 94);
            this.gbTenCongTy.TabIndex = 34;
            this.gbTenCongTy.Text = "Tên Công Ty";
            // 
            // txtTenCongTy
            // 
            this.txtTenCongTy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCongTy.DefaultText = "";
            this.txtTenCongTy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenCongTy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenCongTy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCongTy.DisabledState.Parent = this.txtTenCongTy;
            this.txtTenCongTy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCongTy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCongTy.FocusedState.Parent = this.txtTenCongTy;
            this.txtTenCongTy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCongTy.HoverState.Parent = this.txtTenCongTy;
            this.txtTenCongTy.Location = new System.Drawing.Point(10, 45);
            this.txtTenCongTy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenCongTy.Name = "txtTenCongTy";
            this.txtTenCongTy.PasswordChar = '\0';
            this.txtTenCongTy.PlaceholderText = "";
            this.txtTenCongTy.SelectedText = "";
            this.txtTenCongTy.ShadowDecoration.Parent = this.txtTenCongTy;
            this.txtTenCongTy.Size = new System.Drawing.Size(158, 39);
            this.txtTenCongTy.TabIndex = 31;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BorderRadius = 8;
            this.btnThemNCC.CheckedState.Parent = this.btnThemNCC;
            this.btnThemNCC.CustomImages.Parent = this.btnThemNCC;
            this.btnThemNCC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.White;
            this.btnThemNCC.HoverState.Parent = this.btnThemNCC;
            this.btnThemNCC.Image = global::QLTSTBKhachSan.Properties.Resources.add_32px;
            this.btnThemNCC.Location = new System.Drawing.Point(353, 203);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.ShadowDecoration.Parent = this.btnThemNCC;
            this.btnThemNCC.Size = new System.Drawing.Size(113, 35);
            this.btnThemNCC.TabIndex = 30;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // gbEmail
            // 
            this.gbEmail.BorderRadius = 5;
            this.gbEmail.Controls.Add(this.txtEmail);
            this.gbEmail.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmail.ForeColor = System.Drawing.Color.White;
            this.gbEmail.Location = new System.Drawing.Point(7, 103);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.ShadowDecoration.Parent = this.gbEmail;
            this.gbEmail.Size = new System.Drawing.Size(134, 94);
            this.gbEmail.TabIndex = 35;
            this.gbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(5, 48);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(124, 35);
            this.txtEmail.TabIndex = 31;
            // 
            // gbSTK
            // 
            this.gbSTK.BorderRadius = 5;
            this.gbSTK.Controls.Add(this.txtSTK);
            this.gbSTK.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbSTK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSTK.ForeColor = System.Drawing.Color.White;
            this.gbSTK.Location = new System.Drawing.Point(154, 103);
            this.gbSTK.Name = "gbSTK";
            this.gbSTK.ShadowDecoration.Parent = this.gbSTK;
            this.gbSTK.Size = new System.Drawing.Size(134, 94);
            this.gbSTK.TabIndex = 33;
            this.gbSTK.Text = "Số Tài Khoản";
            // 
            // txtSTK
            // 
            this.txtSTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSTK.DefaultText = "";
            this.txtSTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSTK.DisabledState.Parent = this.txtSTK;
            this.txtSTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSTK.FocusedState.Parent = this.txtSTK;
            this.txtSTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSTK.HoverState.Parent = this.txtSTK;
            this.txtSTK.Location = new System.Drawing.Point(10, 45);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.PasswordChar = '\0';
            this.txtSTK.PlaceholderText = "";
            this.txtSTK.SelectedText = "";
            this.txtSTK.ShadowDecoration.Parent = this.txtSTK;
            this.txtSTK.Size = new System.Drawing.Size(115, 39);
            this.txtSTK.TabIndex = 31;
            // 
            // gbSDT
            // 
            this.gbSDT.BorderRadius = 5;
            this.gbSDT.Controls.Add(this.txtSDT);
            this.gbSDT.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbSDT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSDT.ForeColor = System.Drawing.Color.White;
            this.gbSDT.Location = new System.Drawing.Point(173, 3);
            this.gbSDT.Name = "gbSDT";
            this.gbSDT.ShadowDecoration.Parent = this.gbSDT;
            this.gbSDT.Size = new System.Drawing.Size(134, 94);
            this.gbSDT.TabIndex = 34;
            this.gbSDT.Text = "Phone";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.Parent = this.txtSDT;
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedState.Parent = this.txtSDT;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.HoverState.Parent = this.txtSDT;
            this.txtSDT.Location = new System.Drawing.Point(8, 49);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.ShadowDecoration.Parent = this.txtSDT;
            this.txtSDT.Size = new System.Drawing.Size(117, 38);
            this.txtSDT.TabIndex = 31;
            // 
            // gbDiaChi
            // 
            this.gbDiaChi.BorderRadius = 5;
            this.gbDiaChi.Controls.Add(this.cbDiaChi);
            this.gbDiaChi.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbDiaChi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiaChi.ForeColor = System.Drawing.Color.White;
            this.gbDiaChi.Location = new System.Drawing.Point(313, 3);
            this.gbDiaChi.Name = "gbDiaChi";
            this.gbDiaChi.ShadowDecoration.Parent = this.gbDiaChi;
            this.gbDiaChi.Size = new System.Drawing.Size(159, 94);
            this.gbDiaChi.TabIndex = 32;
            this.gbDiaChi.Text = "Địa Chỉ";
            // 
            // cbDiaChi
            // 
            this.cbDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.cbDiaChi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDiaChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiaChi.FocusedColor = System.Drawing.Color.Empty;
            this.cbDiaChi.FocusedState.Parent = this.cbDiaChi;
            this.cbDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDiaChi.FormattingEnabled = true;
            this.cbDiaChi.HoverState.Parent = this.cbDiaChi;
            this.cbDiaChi.ItemHeight = 30;
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
            "Yên Bái"});
            this.cbDiaChi.ItemsAppearance.Parent = this.cbDiaChi;
            this.cbDiaChi.Location = new System.Drawing.Point(9, 48);
            this.cbDiaChi.Name = "cbDiaChi";
            this.cbDiaChi.ShadowDecoration.Parent = this.cbDiaChi;
            this.cbDiaChi.Size = new System.Drawing.Size(144, 36);
            this.cbDiaChi.TabIndex = 30;
            // 
            // gbTenNCC
            // 
            this.gbTenNCC.BorderRadius = 5;
            this.gbTenNCC.Controls.Add(this.txtTenNCC);
            this.gbTenNCC.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbTenNCC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTenNCC.ForeColor = System.Drawing.Color.White;
            this.gbTenNCC.Location = new System.Drawing.Point(8, 3);
            this.gbTenNCC.Name = "gbTenNCC";
            this.gbTenNCC.ShadowDecoration.Parent = this.gbTenNCC;
            this.gbTenNCC.Size = new System.Drawing.Size(159, 94);
            this.gbTenNCC.TabIndex = 34;
            this.gbTenNCC.Text = "Tên Nhà Cung Cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.DefaultText = "";
            this.txtTenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.DisabledState.Parent = this.txtTenNCC;
            this.txtTenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.FocusedState.Parent = this.txtTenNCC;
            this.txtTenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.HoverState.Parent = this.txtTenNCC;
            this.txtTenNCC.Location = new System.Drawing.Point(5, 48);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.PasswordChar = '\0';
            this.txtTenNCC.PlaceholderText = "";
            this.txtTenNCC.SelectedText = "";
            this.txtTenNCC.ShadowDecoration.Parent = this.txtTenNCC;
            this.txtTenNCC.Size = new System.Drawing.Size(148, 39);
            this.txtTenNCC.TabIndex = 30;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnRefresh);
            this.pnButton.Controls.Add(this.btnDelete);
            this.pnButton.Controls.Add(this.btnUpdate);
            this.pnButton.Controls.Add(this.btnNew);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnButton.Location = new System.Drawing.Point(0, 67);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(1000, 43);
            this.pnButton.TabIndex = 43;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 8;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::QLTSTBKhachSan.Properties.Resources.refresh_26px;
            this.btnRefresh.Location = new System.Drawing.Point(322, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(106, 43);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::QLTSTBKhachSan.Properties.Resources.delete_30px;
            this.btnDelete.Location = new System.Drawing.Point(214, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(108, 43);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = global::QLTSTBKhachSan.Properties.Resources.update_file_filled_50px;
            this.btnUpdate.Location = new System.Drawing.Point(106, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(108, 43);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BorderRadius = 8;
            this.btnNew.CheckedState.Parent = this.btnNew;
            this.btnNew.CustomImages.Parent = this.btnNew;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.HoverState.Parent = this.btnNew;
            this.btnNew.Image = global::QLTSTBKhachSan.Properties.Resources.add_32px;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.ShadowDecoration.Parent = this.btnNew;
            this.btnNew.Size = new System.Drawing.Size(106, 43);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtgvNCC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNCC.BackgroundColor = System.Drawing.Color.White;
            this.dtgvNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvNCC.ColumnHeadersHeight = 50;
            this.dtgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaNCC,
            this.TenNCC,
            this.SDT,
            this.DiaChi,
            this.Email,
            this.STK,
            this.TenCongTy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvNCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvNCC.EnableHeadersVisualStyles = false;
            this.dtgvNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNCC.Location = new System.Drawing.Point(0, 0);
            this.dtgvNCC.Name = "dtgvNCC";
            this.dtgvNCC.ReadOnly = true;
            this.dtgvNCC.RowHeadersVisible = false;
            this.dtgvNCC.RowTemplate.Height = 50;
            this.dtgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNCC.Size = new System.Drawing.Size(1000, 490);
            this.dtgvNCC.TabIndex = 44;
            this.dtgvNCC.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvNCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvNCC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvNCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvNCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvNCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvNCC.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvNCC.ThemeStyle.ReadOnly = true;
            this.dtgvNCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvNCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvNCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvNCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvNCC.ThemeStyle.RowsStyle.Height = 50;
            this.dtgvNCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvNCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvNCC.Click += new System.EventHandler(this.dtgvNCC_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Phone";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // STK
            // 
            this.STK.DataPropertyName = "STK";
            this.STK.HeaderText = "Số Tài Khoản";
            this.STK.Name = "STK";
            this.STK.ReadOnly = true;
            // 
            // TenCongTy
            // 
            this.TenCongTy.DataPropertyName = "TenCongTy";
            this.TenCongTy.HeaderText = "Tên Công Ty";
            this.TenCongTy.Name = "TenCongTy";
            this.TenCongTy.ReadOnly = true;
            // 
            // pnDTGV
            // 
            this.pnDTGV.Controls.Add(this.dtgvNCC);
            this.pnDTGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDTGV.Location = new System.Drawing.Point(0, 110);
            this.pnDTGV.Name = "pnDTGV";
            this.pnDTGV.Size = new System.Drawing.Size(1000, 490);
            this.pnDTGV.TabIndex = 45;
            // 
            // UCQLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnNew);
            this.Controls.Add(this.pnDTGV);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCQLNhaCungCap";
            this.Size = new System.Drawing.Size(1000, 600);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnNew.ResumeLayout(false);
            this.gbTenCongTy.ResumeLayout(false);
            this.gbEmail.ResumeLayout(false);
            this.gbSTK.ResumeLayout(false);
            this.gbSDT.ResumeLayout(false);
            this.gbDiaChi.ResumeLayout(false);
            this.gbTenNCC.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).EndInit();
            this.pnDTGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel pnTitle;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnNew;
        private Guna.UI2.WinForms.Guna2Button btnThemNCC;
        private Guna.UI2.WinForms.Guna2GroupBox gbEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2GroupBox gbSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2GroupBox gbSTK;
        private Guna.UI2.WinForms.Guna2GroupBox gbTenNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNCC;
        private Guna.UI2.WinForms.Guna2GroupBox gbDiaChi;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiaChi;
        private System.Windows.Forms.Panel pnButton;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2GroupBox gbTenCongTy;
        private Guna.UI2.WinForms.Guna2TextBox txtTenCongTy;
        private Guna.UI2.WinForms.Guna2TextBox txtSTK;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvNCC;
        private System.Windows.Forms.Panel pnDTGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn STK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCongTy;
    }
}
