
namespace ListBoxFirstCountAfterWriteToListBox
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSırala = new System.Windows.Forms.Button();
            this.lstbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSırala
            // 
            this.btnSırala.Location = new System.Drawing.Point(412, 267);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(109, 47);
            this.btnSırala.TabIndex = 1;
            this.btnSırala.Text = "sırala";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // lstbListe
            // 
            this.lstbListe.FormattingEnabled = true;
            this.lstbListe.ItemHeight = 20;
            this.lstbListe.Location = new System.Drawing.Point(25, 27);
            this.lstbListe.Name = "lstbListe";
            this.lstbListe.Size = new System.Drawing.Size(480, 224);
            this.lstbListe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 326);
            this.Controls.Add(this.lstbListe);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.ListBox lstbListe;
    }
}

