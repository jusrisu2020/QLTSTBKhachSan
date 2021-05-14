namespace OutputFileLog
{
    partial class FFL1
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
            this.components = new System.ComponentModel.Container();
            this.btnTaoFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnShowPathToDialog = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTaoFile
            // 
            this.btnTaoFile.Location = new System.Drawing.Point(12, 66);
            this.btnTaoFile.Name = "btnTaoFile";
            this.btnTaoFile.Size = new System.Drawing.Size(75, 48);
            this.btnTaoFile.TabIndex = 0;
            this.btnTaoFile.Text = "Tạo File Log";
            this.btnTaoFile.UseVisualStyleBackColor = true;
            this.btnTaoFile.Click += new System.EventHandler(this.btnTaoFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(336, 66);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 48);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(93, 66);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(75, 48);
            this.btnDocFile.TabIndex = 2;
            this.btnDocFile.Text = "Đọc FileLog qua TextBox";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 195);
            this.textBox1.TabIndex = 3;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(9, 486);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(36, 13);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(255, 66);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 48);
            this.btnDeleteFile.TabIndex = 5;
            this.btnDeleteFile.Text = "Delete";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnShowPathToDialog
            // 
            this.btnShowPathToDialog.Location = new System.Drawing.Point(174, 66);
            this.btnShowPathToDialog.Name = "btnShowPathToDialog";
            this.btnShowPathToDialog.Size = new System.Drawing.Size(75, 48);
            this.btnShowPathToDialog.TabIndex = 6;
            this.btnShowPathToDialog.Text = "Show File Dialog";
            this.btnShowPathToDialog.UseVisualStyleBackColor = true;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(23, 22);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(32, 13);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "Riant";
            // 
            // FFL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 508);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnShowPathToDialog);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDocFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTaoFile);
            this.Name = "FFL1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFileLog1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnShowPathToDialog;
        private System.Windows.Forms.Label lbUserName;
    }
}

