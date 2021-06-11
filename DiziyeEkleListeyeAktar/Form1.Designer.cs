
namespace DiziyeEkleListeyeAktar
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstbxListe = new System.Windows.Forms.ListBox();
            this.txtbSehir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(81, 320);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(143, 36);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(318, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstbxListe
            // 
            this.lstbxListe.FormattingEnabled = true;
            this.lstbxListe.ItemHeight = 20;
            this.lstbxListe.Location = new System.Drawing.Point(28, 32);
            this.lstbxListe.Name = "lstbxListe";
            this.lstbxListe.Size = new System.Drawing.Size(268, 224);
            this.lstbxListe.TabIndex = 2;
            // 
            // txtbSehir
            // 
            this.txtbSehir.Location = new System.Drawing.Point(318, 32);
            this.txtbSehir.Name = "txtbSehir";
            this.txtbSehir.Size = new System.Drawing.Size(152, 26);
            this.txtbSehir.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 421);
            this.Controls.Add(this.txtbSehir);
            this.Controls.Add(this.lstbxListe);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnListele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstbxListe;
        private System.Windows.Forms.TextBox txtbSehir;
    }
}

