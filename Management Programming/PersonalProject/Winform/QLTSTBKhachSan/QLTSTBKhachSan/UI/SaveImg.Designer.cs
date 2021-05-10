namespace QLTSTBKhachSan.UI
{
    partial class SaveImg
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
            this.btnSave = new System.Windows.Forms.Button();
            this.picOutPut = new System.Windows.Forms.PictureBox();
            this.dtgvHinhAnh = new System.Windows.Forms.DataGridView();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOutPut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(238, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picOutPut
            // 
            this.picOutPut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picOutPut.Location = new System.Drawing.Point(44, 273);
            this.picOutPut.Name = "picOutPut";
            this.picOutPut.Size = new System.Drawing.Size(215, 135);
            this.picOutPut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOutPut.TabIndex = 0;
            this.picOutPut.TabStop = false;
            // 
            // dtgvHinhAnh
            // 
            this.dtgvHinhAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHinhAnh.Location = new System.Drawing.Point(338, 58);
            this.dtgvHinhAnh.Name = "dtgvHinhAnh";
            this.dtgvHinhAnh.RowHeadersWidth = 51;
            this.dtgvHinhAnh.RowTemplate.Height = 140;
            this.dtgvHinhAnh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHinhAnh.Size = new System.Drawing.Size(450, 380);
            this.dtgvHinhAnh.TabIndex = 4;
            this.dtgvHinhAnh.Click += new System.EventHandler(this.dtgvHinhAnh_Click);
            // 
            // picInput
            // 
            this.picInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picInput.Location = new System.Drawing.Point(44, 97);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(215, 135);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInput.TabIndex = 5;
            this.picInput.TabStop = false;
            this.picInput.Click += new System.EventHandler(this.picInput_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(78, 29);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(139, 20);
            this.txtPath.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Hình";
            // 
            // SaveImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.dtgvHinhAnh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picOutPut);
            this.Name = "SaveImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveXuatImg";
            ((System.ComponentModel.ISupportInitialize)(this.picOutPut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picOutPut;
        private System.Windows.Forms.DataGridView dtgvHinhAnh;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
    }
}