
namespace QLTSTBKhachSan.UI
{
    partial class FHelp
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
            this.pbLoadImg = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoadImg
            // 
            this.pbLoadImg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbLoadImg.Location = new System.Drawing.Point(65, 34);
            this.pbLoadImg.Name = "pbLoadImg";
            this.pbLoadImg.Size = new System.Drawing.Size(143, 124);
            this.pbLoadImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoadImg.TabIndex = 0;
            this.pbLoadImg.TabStop = false;
            this.pbLoadImg.Click += new System.EventHandler(this.pbLoadImg_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(343, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 415);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pbLoadImg);
            this.Name = "FHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoadImg;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}