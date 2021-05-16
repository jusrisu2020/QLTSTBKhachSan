
namespace QLTSTBKhachSan.UI
{
    partial class FDangNhap
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
            this.lbTitle1 = new System.Windows.Forms.Label();
            this.btnLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.pnLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle2 = new System.Windows.Forms.Label();
            this.lbTitle3 = new System.Windows.Forms.Label();
            this.lbFooter = new System.Windows.Forms.Label();
            this.chkPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMiniMize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gnWallBG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnLogin.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnWallBG)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle1
            // 
            this.lbTitle1.AutoSize = true;
            this.lbTitle1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbTitle1.Location = new System.Drawing.Point(102, 27);
            this.lbTitle1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle1.Name = "lbTitle1";
            this.lbTitle1.Size = new System.Drawing.Size(145, 56);
            this.lbTitle1.TabIndex = 1;
            this.lbTitle1.Text = "Hotel";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BorderRadius = 22;
            this.btnLogIn.CheckedState.Parent = this.btnLogIn;
            this.btnLogIn.CustomImages.Parent = this.btnLogIn;
            this.btnLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLogIn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnLogIn.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLogIn.HoverState.Parent = this.btnLogIn;
            this.btnLogIn.Location = new System.Drawing.Point(99, 436);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.ShadowDecoration.Parent = this.btnLogIn;
            this.btnLogIn.Size = new System.Drawing.Size(183, 47);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.White;
            this.pnLogin.Controls.Add(this.txtUserName);
            this.pnLogin.Controls.Add(this.pnTitle);
            this.pnLogin.Controls.Add(this.lbFooter);
            this.pnLogin.Controls.Add(this.chkPassword);
            this.pnLogin.Controls.Add(this.txtPassword);
            this.pnLogin.Controls.Add(this.btnLogIn);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnLogin.Location = new System.Drawing.Point(0, 0);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.ShadowDecoration.Parent = this.pnLogin;
            this.pnLogin.Size = new System.Drawing.Size(400, 600);
            this.pnLogin.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "ad";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.Location = new System.Drawing.Point(85, 258);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionStart = 2;
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(217, 39);
            this.txtUserName.TabIndex = 0;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lbTitle2);
            this.pnTitle.Controls.Add(this.lbTitle3);
            this.pnTitle.Controls.Add(this.lbTitle1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(400, 200);
            this.pnTitle.TabIndex = 21;
            // 
            // lbTitle2
            // 
            this.lbTitle2.AutoSize = true;
            this.lbTitle2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbTitle2.Location = new System.Drawing.Point(167, 81);
            this.lbTitle2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle2.Name = "lbTitle2";
            this.lbTitle2.Size = new System.Drawing.Size(207, 41);
            this.lbTitle2.TabIndex = 4;
            this.lbTitle2.Text = "Equipment ";
            // 
            // lbTitle3
            // 
            this.lbTitle3.AutoSize = true;
            this.lbTitle3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbTitle3.Location = new System.Drawing.Point(41, 122);
            this.lbTitle3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle3.Name = "lbTitle3";
            this.lbTitle3.Size = new System.Drawing.Size(227, 38);
            this.lbTitle3.TabIndex = 3;
            this.lbTitle3.Text = "Management";
            // 
            // lbFooter
            // 
            this.lbFooter.AutoSize = true;
            this.lbFooter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.lbFooter.Location = new System.Drawing.Point(11, 572);
            this.lbFooter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFooter.Name = "lbFooter";
            this.lbFooter.Size = new System.Drawing.Size(187, 19);
            this.lbFooter.TabIndex = 2;
            this.lbFooter.Text = "Infomation Technology";
            // 
            // chkPassword
            // 
            this.chkPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkPassword.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkPassword.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chkPassword.CheckedState.Parent = this.chkPassword;
            this.chkPassword.Location = new System.Drawing.Point(85, 380);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.ShadowDecoration.Parent = this.chkPassword;
            this.chkPassword.Size = new System.Drawing.Size(35, 20);
            this.chkPassword.TabIndex = 2;
            this.chkPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkPassword.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.chkPassword.UncheckedState.Parent = this.chkPassword;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "1";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(85, 326);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionStart = 1;
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(217, 39);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnMiniMize
            // 
            this.btnMiniMize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniMize.BorderColor = System.Drawing.Color.DimGray;
            this.btnMiniMize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMiniMize.FillColor = System.Drawing.Color.DimGray;
            this.btnMiniMize.HoverState.Parent = this.btnMiniMize;
            this.btnMiniMize.IconColor = System.Drawing.Color.White;
            this.btnMiniMize.Location = new System.Drawing.Point(717, 11);
            this.btnMiniMize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMiniMize.Name = "btnMiniMize";
            this.btnMiniMize.PressedDepth = 4;
            this.btnMiniMize.ShadowDecoration.Parent = this.btnMiniMize;
            this.btnMiniMize.Size = new System.Drawing.Size(34, 19);
            this.btnMiniMize.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FillColor = System.Drawing.Color.DimGray;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(755, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedDepth = 5;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(34, 19);
            this.btnClose.TabIndex = 20;
            // 
            // gnWallBG
            // 
            this.gnWallBG.Dock = System.Windows.Forms.DockStyle.Left;
            this.gnWallBG.Image = global::QLTSTBKhachSan.Properties.Resources.WallBgLogin;
            this.gnWallBG.Location = new System.Drawing.Point(400, 0);
            this.gnWallBG.Margin = new System.Windows.Forms.Padding(2);
            this.gnWallBG.Name = "gnWallBG";
            this.gnWallBG.ShadowDecoration.Parent = this.gnWallBG;
            this.gnWallBG.Size = new System.Drawing.Size(400, 600);
            this.gnWallBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gnWallBG.TabIndex = 2;
            this.gnWallBG.TabStop = false;
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnMiniMize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gnWallBG);
            this.Controls.Add(this.pnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDangNhap";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FDangNhap_KeyDown);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnWallBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle1;
        private Guna.UI2.WinForms.Guna2PictureBox gnWallBG;
        private Guna.UI2.WinForms.Guna2Button btnLogIn;
        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2ControlBox btnMiniMize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chkPassword;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle3;
        private System.Windows.Forms.Label lbFooter;
        private System.Windows.Forms.Label lbTitle2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
    }
}