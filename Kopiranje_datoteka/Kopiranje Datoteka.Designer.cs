using System;

namespace Kopiranje_datoteka
{
    partial class Kopiranje_Datoteke
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
            this.OdaberiFile = new System.Windows.Forms.Button();
            this.OdaberiFolder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Kopiraj = new System.Windows.Forms.Button();
            this.Zaustavi = new System.Windows.Forms.Button();
            this.Tekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OdaberiFile
            // 
            this.OdaberiFile.Location = new System.Drawing.Point(57, 24);
            this.OdaberiFile.Name = "OdaberiFile";
            this.OdaberiFile.Size = new System.Drawing.Size(172, 23);
            this.OdaberiFile.TabIndex = 0;
            this.OdaberiFile.Text = "Odaberi datoteku:\r\n";
            this.OdaberiFile.UseVisualStyleBackColor = true;
            this.OdaberiFile.Click += new System.EventHandler(this.OdaberiFile_Click);
            // 
            // OdaberiFolder
            // 
            this.OdaberiFolder.Location = new System.Drawing.Point(57, 70);
            this.OdaberiFolder.Name = "OdaberiFolder";
            this.OdaberiFolder.Size = new System.Drawing.Size(172, 23);
            this.OdaberiFolder.TabIndex = 1;
            this.OdaberiFolder.Text = "Odaberi odredište:";
            this.OdaberiFolder.UseVisualStyleBackColor = true;
            this.OdaberiFolder.Click += new System.EventHandler(this.OdaberiFolder_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(226, 193);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 42);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(508, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Kopiraj
            // 
            this.Kopiraj.Location = new System.Drawing.Point(35, 193);
            this.Kopiraj.Name = "Kopiraj";
            this.Kopiraj.Size = new System.Drawing.Size(172, 42);
            this.Kopiraj.TabIndex = 5;
            this.Kopiraj.Text = "Kopiraj datoteku:";
            this.Kopiraj.UseVisualStyleBackColor = true;
            this.Kopiraj.Click += new System.EventHandler(this.Kopiraj_Click);
            // 
            // Zaustavi
            // 
            this.Zaustavi.Location = new System.Drawing.Point(603, 193);
            this.Zaustavi.Name = "Zaustavi";
            this.Zaustavi.Size = new System.Drawing.Size(172, 42);
            this.Zaustavi.TabIndex = 6;
            this.Zaustavi.Text = "Zaustavi kopiranje:\r\n";
            this.Zaustavi.UseVisualStyleBackColor = true;
            this.Zaustavi.Click += new System.EventHandler(this.Zaustavi_Click);
            // 
            // Tekst
            // 
            this.Tekst.AutoSize = true;
            this.Tekst.Location = new System.Drawing.Point(546, 238);
            this.Tekst.Name = "Tekst";
            this.Tekst.Size = new System.Drawing.Size(51, 13);
            this.Tekst.TabIndex = 8;
            this.Tekst.Text = "Posto (%)";
            this.Tekst.Click += new System.EventHandler(this.Posto_Click);
            // 
            // Kopiranje_Datoteke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tekst);
            this.Controls.Add(this.Zaustavi);
            this.Controls.Add(this.Kopiraj);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.OdaberiFolder);
            this.Controls.Add(this.OdaberiFile);
            this.Name = "Kopiranje_Datoteke";
            this.Text = "Kopiranje Datoteka";
            this.Load += new System.EventHandler(this.KopiranjeDatoteke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void KopiranjeDatoteke_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button OdaberiFile;
        private System.Windows.Forms.Button OdaberiFolder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Kopiraj;
        private System.Windows.Forms.Button Zaustavi;
        private System.Windows.Forms.Label Tekst;
    }
}

