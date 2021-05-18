namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLiBoPhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtTKBoPhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.pnNewBP = new System.Windows.Forms.Panel();
            this.gbTenBP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTenBP = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNewBoPhan = new Guna.UI2.WinForms.Guna2Button();
            this.pnDTGV = new System.Windows.Forms.Panel();
            this.dtgvQLBP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnNewBP.SuspendLayout();
            this.gbTenBP.SuspendLayout();
            this.pnDTGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnTitle.Controls.Add(this.btnSearch);
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Controls.Add(this.txtTKBoPhan);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.pnTitle.Size = new System.Drawing.Size(1000, 80);
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
            this.btnSearch.Location = new System.Drawing.Point(848, 28);
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
            this.lbTitle.Location = new System.Drawing.Point(52, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(117, 31);
            this.lbTitle.TabIndex = 28;
            this.lbTitle.Text = "Bộ Phận";
            // 
            // txtTKBoPhan
            // 
            this.txtTKBoPhan.BorderRadius = 10;
            this.txtTKBoPhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKBoPhan.DefaultText = "";
            this.txtTKBoPhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTKBoPhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTKBoPhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKBoPhan.DisabledState.Parent = this.txtTKBoPhan;
            this.txtTKBoPhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKBoPhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKBoPhan.FocusedState.Parent = this.txtTKBoPhan;
            this.txtTKBoPhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKBoPhan.HoverState.Parent = this.txtTKBoPhan;
            this.txtTKBoPhan.IconLeft = global::QLTSTBKhachSan.Properties.Resources.IconSearch;
            this.txtTKBoPhan.Location = new System.Drawing.Point(561, 28);
            this.txtTKBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTKBoPhan.Name = "txtTKBoPhan";
            this.txtTKBoPhan.PasswordChar = '\0';
            this.txtTKBoPhan.PlaceholderText = "Search.....";
            this.txtTKBoPhan.SelectedText = "";
            this.txtTKBoPhan.ShadowDecoration.Parent = this.txtTKBoPhan;
            this.txtTKBoPhan.Size = new System.Drawing.Size(280, 30);
            this.txtTKBoPhan.TabIndex = 25;
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnRefresh);
            this.pnButton.Controls.Add(this.btnDelete);
            this.pnButton.Controls.Add(this.btnUpdate);
            this.pnButton.Controls.Add(this.btnNew);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnButton.Location = new System.Drawing.Point(0, 80);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(1000, 37);
            this.pnButton.TabIndex = 39;
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
            this.btnRefresh.Size = new System.Drawing.Size(106, 37);
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
            this.btnDelete.Size = new System.Drawing.Size(108, 37);
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
            this.btnUpdate.Size = new System.Drawing.Size(108, 37);
            this.btnUpdate.TabIndex = 39;
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
            this.btnNew.Size = new System.Drawing.Size(106, 37);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnNewBP
            // 
            this.pnNewBP.Controls.Add(this.gbTenBP);
            this.pnNewBP.Controls.Add(this.btnNewBoPhan);
            this.pnNewBP.Location = new System.Drawing.Point(1, 1);
            this.pnNewBP.Margin = new System.Windows.Forms.Padding(2);
            this.pnNewBP.Name = "pnNewBP";
            this.pnNewBP.Size = new System.Drawing.Size(140, 144);
            this.pnNewBP.TabIndex = 40;
            this.pnNewBP.Visible = false;
            // 
            // gbTenBP
            // 
            this.gbTenBP.BorderRadius = 5;
            this.gbTenBP.Controls.Add(this.txtTenBP);
            this.gbTenBP.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbTenBP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTenBP.ForeColor = System.Drawing.Color.White;
            this.gbTenBP.Location = new System.Drawing.Point(3, 3);
            this.gbTenBP.Name = "gbTenBP";
            this.gbTenBP.ShadowDecoration.Parent = this.gbTenBP;
            this.gbTenBP.Size = new System.Drawing.Size(134, 94);
            this.gbTenBP.TabIndex = 32;
            this.gbTenBP.Text = "Tên Bộ Phan";
            // 
            // txtTenBP
            // 
            this.txtTenBP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBP.DefaultText = "";
            this.txtTenBP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenBP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenBP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBP.DisabledState.Parent = this.txtTenBP;
            this.txtTenBP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBP.FocusedState.Parent = this.txtTenBP;
            this.txtTenBP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenBP.HoverState.Parent = this.txtTenBP;
            this.txtTenBP.Location = new System.Drawing.Point(4, 47);
            this.txtTenBP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenBP.Name = "txtTenBP";
            this.txtTenBP.PasswordChar = '\0';
            this.txtTenBP.PlaceholderText = "";
            this.txtTenBP.SelectedText = "";
            this.txtTenBP.ShadowDecoration.Parent = this.txtTenBP;
            this.txtTenBP.Size = new System.Drawing.Size(126, 30);
            this.txtTenBP.TabIndex = 34;
            // 
            // btnNewBoPhan
            // 
            this.btnNewBoPhan.BorderRadius = 8;
            this.btnNewBoPhan.CheckedState.Parent = this.btnNewBoPhan;
            this.btnNewBoPhan.CustomImages.Parent = this.btnNewBoPhan;
            this.btnNewBoPhan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBoPhan.ForeColor = System.Drawing.Color.White;
            this.btnNewBoPhan.HoverState.Parent = this.btnNewBoPhan;
            this.btnNewBoPhan.Image = global::QLTSTBKhachSan.Properties.Resources.add_32px;
            this.btnNewBoPhan.Location = new System.Drawing.Point(24, 103);
            this.btnNewBoPhan.Name = "btnNewBoPhan";
            this.btnNewBoPhan.ShadowDecoration.Parent = this.btnNewBoPhan;
            this.btnNewBoPhan.Size = new System.Drawing.Size(113, 35);
            this.btnNewBoPhan.TabIndex = 30;
            this.btnNewBoPhan.Text = "Thêm";
            this.btnNewBoPhan.Click += new System.EventHandler(this.btnNewBoPhan_Click);
            // 
            // pnDTGV
            // 
            this.pnDTGV.Controls.Add(this.pnNewBP);
            this.pnDTGV.Controls.Add(this.dtgvQLBP);
            this.pnDTGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDTGV.Location = new System.Drawing.Point(0, 117);
            this.pnDTGV.Name = "pnDTGV";
            this.pnDTGV.Size = new System.Drawing.Size(1000, 496);
            this.pnDTGV.TabIndex = 42;
            // 
            // dtgvQLBP
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dtgvQLBP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvQLBP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQLBP.BackgroundColor = System.Drawing.Color.White;
            this.dtgvQLBP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvQLBP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvQLBP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLBP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvQLBP.ColumnHeadersHeight = 50;
            this.dtgvQLBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvQLBP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaBP,
            this.TenBP});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQLBP.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvQLBP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQLBP.EnableHeadersVisualStyles = false;
            this.dtgvQLBP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvQLBP.Location = new System.Drawing.Point(0, 0);
            this.dtgvQLBP.Name = "dtgvQLBP";
            this.dtgvQLBP.ReadOnly = true;
            this.dtgvQLBP.RowHeadersVisible = false;
            this.dtgvQLBP.RowTemplate.Height = 50;
            this.dtgvQLBP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLBP.Size = new System.Drawing.Size(1000, 496);
            this.dtgvQLBP.TabIndex = 41;
            this.dtgvQLBP.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvQLBP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvQLBP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvQLBP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvQLBP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvQLBP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvQLBP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvQLBP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvQLBP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvQLBP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvQLBP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvQLBP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvQLBP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvQLBP.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvQLBP.ThemeStyle.ReadOnly = true;
            this.dtgvQLBP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvQLBP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvQLBP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvQLBP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvQLBP.ThemeStyle.RowsStyle.Height = 50;
            this.dtgvQLBP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvQLBP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvQLBP.Click += new System.EventHandler(this.dtgvQLBP_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MaBP
            // 
            this.MaBP.DataPropertyName = "MaBP";
            this.MaBP.HeaderText = "Mã Bộ Phận";
            this.MaBP.Name = "MaBP";
            this.MaBP.ReadOnly = true;
            // 
            // TenBP
            // 
            this.TenBP.DataPropertyName = "TenBP";
            this.TenBP.HeaderText = "Tên Bộ Phận";
            this.TenBP.Name = "TenBP";
            this.TenBP.ReadOnly = true;
            // 
            // UCQuanLiBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDTGV);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCQuanLiBoPhan";
            this.Size = new System.Drawing.Size(1000, 600);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.pnNewBP.ResumeLayout(false);
            this.gbTenBP.ResumeLayout(false);
            this.pnDTGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLBP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtTKBoPhan;
        private System.Windows.Forms.Panel pnButton;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Panel pnNewBP;
        private Guna.UI2.WinForms.Guna2Button btnNewBoPhan;
        private Guna.UI2.WinForms.Guna2GroupBox gbTenBP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenBP;
        private System.Windows.Forms.Panel pnDTGV;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvQLBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBP;
    }
}
