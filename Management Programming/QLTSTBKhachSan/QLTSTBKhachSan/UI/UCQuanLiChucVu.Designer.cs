namespace QLTSTBKhachSan.UI
{
    partial class UCQuanLiChucVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvQLCV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenCV = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbTenCV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewChucVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.pnButton = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnNewCV = new System.Windows.Forms.Panel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pnDTGV = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLCV)).BeginInit();
            this.gbTenCV.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.pnNewCV.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.pnDTGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvQLCV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dtgvQLCV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvQLCV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvQLCV.BackgroundColor = System.Drawing.Color.White;
            this.dtgvQLCV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvQLCV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvQLCV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQLCV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvQLCV.ColumnHeadersHeight = 50;
            this.dtgvQLCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvQLCV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaCV,
            this.TenCV});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQLCV.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvQLCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQLCV.EnableHeadersVisualStyles = false;
            this.dtgvQLCV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvQLCV.Location = new System.Drawing.Point(0, 0);
            this.dtgvQLCV.Name = "dtgvQLCV";
            this.dtgvQLCV.ReadOnly = true;
            this.dtgvQLCV.RowHeadersVisible = false;
            this.dtgvQLCV.RowTemplate.Height = 50;
            this.dtgvQLCV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQLCV.Size = new System.Drawing.Size(1000, 506);
            this.dtgvQLCV.TabIndex = 45;
            this.dtgvQLCV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvQLCV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvQLCV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvQLCV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvQLCV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvQLCV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvQLCV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvQLCV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvQLCV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvQLCV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvQLCV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvQLCV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvQLCV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvQLCV.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvQLCV.ThemeStyle.ReadOnly = true;
            this.dtgvQLCV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvQLCV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvQLCV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvQLCV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvQLCV.ThemeStyle.RowsStyle.Height = 50;
            this.dtgvQLCV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvQLCV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvQLCV.Click += new System.EventHandler(this.dtgvQLCV_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã Chức Vụ";
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.Name = "TenCV";
            this.TenCV.ReadOnly = true;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenCV.DefaultText = "";
            this.txtTenCV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenCV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenCV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCV.DisabledState.Parent = this.txtTenCV;
            this.txtTenCV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenCV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCV.FocusedState.Parent = this.txtTenCV;
            this.txtTenCV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenCV.HoverState.Parent = this.txtTenCV;
            this.txtTenCV.Location = new System.Drawing.Point(4, 47);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.PasswordChar = '\0';
            this.txtTenCV.PlaceholderText = "";
            this.txtTenCV.SelectedText = "";
            this.txtTenCV.ShadowDecoration.Parent = this.txtTenCV;
            this.txtTenCV.Size = new System.Drawing.Size(126, 30);
            this.txtTenCV.TabIndex = 34;
            // 
            // gbTenCV
            // 
            this.gbTenCV.BorderRadius = 5;
            this.gbTenCV.Controls.Add(this.txtTenCV);
            this.gbTenCV.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.gbTenCV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTenCV.ForeColor = System.Drawing.Color.White;
            this.gbTenCV.Location = new System.Drawing.Point(3, 3);
            this.gbTenCV.Name = "gbTenCV";
            this.gbTenCV.ShadowDecoration.Parent = this.gbTenCV;
            this.gbTenCV.Size = new System.Drawing.Size(134, 94);
            this.gbTenCV.TabIndex = 32;
            this.gbTenCV.Text = "Tên Chức Vụ";
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
            this.btnUpdate.Size = new System.Drawing.Size(108, 33);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnRefresh.Size = new System.Drawing.Size(106, 33);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "Refesh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnNew.Size = new System.Drawing.Size(106, 33);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnNewChucVu
            // 
            this.btnNewChucVu.BorderRadius = 8;
            this.btnNewChucVu.CheckedState.Parent = this.btnNewChucVu;
            this.btnNewChucVu.CustomImages.Parent = this.btnNewChucVu;
            this.btnNewChucVu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewChucVu.ForeColor = System.Drawing.Color.White;
            this.btnNewChucVu.HoverState.Parent = this.btnNewChucVu;
            this.btnNewChucVu.Image = global::QLTSTBKhachSan.Properties.Resources.add_32px;
            this.btnNewChucVu.Location = new System.Drawing.Point(24, 103);
            this.btnNewChucVu.Name = "btnNewChucVu";
            this.btnNewChucVu.ShadowDecoration.Parent = this.btnNewChucVu;
            this.btnNewChucVu.Size = new System.Drawing.Size(113, 35);
            this.btnNewChucVu.TabIndex = 30;
            this.btnNewChucVu.Text = "Thêm";
            this.btnNewChucVu.Click += new System.EventHandler(this.btnNewChucVu_Click);
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
            this.btnDelete.Size = new System.Drawing.Size(108, 33);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.pnButton.Size = new System.Drawing.Size(1000, 33);
            this.pnButton.TabIndex = 43;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(44, 26);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(118, 31);
            this.lbTitle.TabIndex = 28;
            this.lbTitle.Text = "Chức Vụ";
            // 
            // pnNewCV
            // 
            this.pnNewCV.Controls.Add(this.btnNewChucVu);
            this.pnNewCV.Controls.Add(this.gbTenCV);
            this.pnNewCV.Location = new System.Drawing.Point(2, 5);
            this.pnNewCV.Margin = new System.Windows.Forms.Padding(2);
            this.pnNewCV.Name = "pnNewCV";
            this.pnNewCV.Size = new System.Drawing.Size(140, 144);
            this.pnNewCV.TabIndex = 44;
            this.pnNewCV.Visible = false;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.pnTitle.Size = new System.Drawing.Size(1000, 80);
            this.pnTitle.TabIndex = 42;
            // 
            // pnDTGV
            // 
            this.pnDTGV.Controls.Add(this.pnNewCV);
            this.pnDTGV.Controls.Add(this.dtgvQLCV);
            this.pnDTGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDTGV.Location = new System.Drawing.Point(0, 113);
            this.pnDTGV.Name = "pnDTGV";
            this.pnDTGV.Size = new System.Drawing.Size(1000, 506);
            this.pnDTGV.TabIndex = 46;
            // 
            // UCQuanLiChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDTGV);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCQuanLiChucVu";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLCV)).EndInit();
            this.gbTenCV.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.pnNewCV.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.pnDTGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dtgvQLCV;
        private Guna.UI2.WinForms.Guna2TextBox txtTenCV;
        private Guna.UI2.WinForms.Guna2GroupBox gbTenCV;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private Guna.UI2.WinForms.Guna2Button btnNewChucVu;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Panel pnNewCV;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.Panel pnDTGV;
    }
}
