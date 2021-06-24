
namespace TextInImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBoxTextImage = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rtbInfoPalavra = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rtbTextDetected = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuckets = new System.Windows.Forms.ComboBox();
            this.btnFileImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnReloadBuckets = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextImage)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 396);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBoxTextImage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(618, 396);
            this.panel6.TabIndex = 2;
            // 
            // pictureBoxTextImage
            // 
            this.pictureBoxTextImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxTextImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTextImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTextImage.Name = "pictureBoxTextImage";
            this.pictureBoxTextImage.Size = new System.Drawing.Size(618, 396);
            this.pictureBoxTextImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTextImage.TabIndex = 0;
            this.pictureBoxTextImage.TabStop = false;
            this.pictureBoxTextImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTextImage_MouseDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rtbInfoPalavra);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(618, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 396);
            this.panel5.TabIndex = 1;
            // 
            // rtbInfoPalavra
            // 
            this.rtbInfoPalavra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfoPalavra.Location = new System.Drawing.Point(0, 0);
            this.rtbInfoPalavra.Name = "rtbInfoPalavra";
            this.rtbInfoPalavra.Size = new System.Drawing.Size(236, 396);
            this.rtbInfoPalavra.TabIndex = 0;
            this.rtbInfoPalavra.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rtbTextDetected);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 69);
            this.panel4.TabIndex = 1;
            // 
            // rtbTextDetected
            // 
            this.rtbTextDetected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextDetected.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbTextDetected.Location = new System.Drawing.Point(0, 0);
            this.rtbTextDetected.Name = "rtbTextDetected";
            this.rtbTextDetected.Size = new System.Drawing.Size(854, 69);
            this.rtbTextDetected.TabIndex = 0;
            this.rtbTextDetected.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReloadBuckets);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbBuckets);
            this.panel2.Controls.Add(this.btnFileImg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 41);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha o bucket:";
            // 
            // cbBuckets
            // 
            this.cbBuckets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuckets.FormattingEnabled = true;
            this.cbBuckets.Location = new System.Drawing.Point(127, 11);
            this.cbBuckets.Name = "cbBuckets";
            this.cbBuckets.Size = new System.Drawing.Size(209, 23);
            this.cbBuckets.TabIndex = 1;
            // 
            // btnFileImg
            // 
            this.btnFileImg.Location = new System.Drawing.Point(466, 11);
            this.btnFileImg.Name = "btnFileImg";
            this.btnFileImg.Size = new System.Drawing.Size(152, 23);
            this.btnFileImg.TabIndex = 0;
            this.btnFileImg.Text = "Abrir imagem";
            this.btnFileImg.UseVisualStyleBackColor = true;
            this.btnFileImg.Click += new System.EventHandler(this.btnFileImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnReloadBuckets
            // 
            this.btnReloadBuckets.BackgroundImage = global::TextInImage.Properties.Resources._126502;
            this.btnReloadBuckets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReloadBuckets.Location = new System.Drawing.Point(342, 12);
            this.btnReloadBuckets.Name = "btnReloadBuckets";
            this.btnReloadBuckets.Size = new System.Drawing.Size(29, 23);
            this.btnReloadBuckets.TabIndex = 3;
            this.btnReloadBuckets.UseVisualStyleBackColor = true;
            this.btnReloadBuckets.Click += new System.EventHandler(this.btnReloadBuckets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 506);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextImage)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFileImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxTextImage;
        private System.Windows.Forms.RichTextBox rtbTextDetected;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox rtbInfoPalavra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBuckets;
        private System.Windows.Forms.Button btnReloadBuckets;
    }
}

