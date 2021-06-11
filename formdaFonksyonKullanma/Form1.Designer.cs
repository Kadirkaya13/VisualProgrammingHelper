
namespace formdaFonksyonKullanma
{
    partial class Form1
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
            this.txtbAd = new System.Windows.Forms.TextBox();
            this.txtbSoyad = new System.Windows.Forms.TextBox();
            this.txtbSehir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lstbAktar = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbAd
            // 
            this.txtbAd.Location = new System.Drawing.Point(158, 46);
            this.txtbAd.Name = "txtbAd";
            this.txtbAd.Size = new System.Drawing.Size(166, 26);
            this.txtbAd.TabIndex = 0;
            // 
            // txtbSoyad
            // 
            this.txtbSoyad.Location = new System.Drawing.Point(158, 124);
            this.txtbSoyad.Name = "txtbSoyad";
            this.txtbSoyad.Size = new System.Drawing.Size(166, 26);
            this.txtbSoyad.TabIndex = 1;
            // 
            // txtbSehir
            // 
            this.txtbSehir.Location = new System.Drawing.Point(158, 201);
            this.txtbSehir.Name = "txtbSehir";
            this.txtbSehir.Size = new System.Drawing.Size(166, 26);
            this.txtbSehir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "sehir";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnYazdır
            // 
            this.btnYazdır.Location = new System.Drawing.Point(111, 287);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(94, 44);
            this.btnYazdır.TabIndex = 6;
            this.btnYazdır.Text = "yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(283, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 44);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(619, 207);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(119, 55);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "hesapla";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "hesap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(393, 501);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(107, 86);
            this.btnAktar.TabIndex = 12;
            this.btnAktar.Text = "aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lstbAktar
            // 
            this.lstbAktar.FormattingEnabled = true;
            this.lstbAktar.ItemHeight = 20;
            this.lstbAktar.Location = new System.Drawing.Point(122, 501);
            this.lstbAktar.Name = "lstbAktar";
            this.lstbAktar.Size = new System.Drawing.Size(226, 164);
            this.lstbAktar.TabIndex = 13;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(393, 594);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(107, 71);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 700);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstbAktar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbSehir);
            this.Controls.Add(this.txtbSoyad);
            this.Controls.Add(this.txtbAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbAd;
        private System.Windows.Forms.TextBox txtbSoyad;
        private System.Windows.Forms.TextBox txtbSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lstbAktar;
        private System.Windows.Forms.Button btnShow;
    }
}

