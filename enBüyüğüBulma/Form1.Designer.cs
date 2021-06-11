
namespace enBüyüğüBulma
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
            this.btnBüyükBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSırala = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBüyükBul
            // 
            this.btnBüyükBul.Location = new System.Drawing.Point(113, 171);
            this.btnBüyükBul.Name = "btnBüyükBul";
            this.btnBüyükBul.Size = new System.Drawing.Size(190, 70);
            this.btnBüyükBul.TabIndex = 0;
            this.btnBüyükBul.Text = "Büyüğü bul";
            this.btnBüyükBul.UseVisualStyleBackColor = true;
            this.btnBüyükBul.Click += new System.EventHandler(this.btnBüyükBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnSırala
            // 
            this.btnSırala.Location = new System.Drawing.Point(429, 65);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(75, 43);
            this.btnSırala.TabIndex = 2;
            this.btnSırala.Text = "sırala";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(560, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 204);
            this.listBox1.TabIndex = 3;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(429, 125);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(106, 46);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "ters sırala";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSelected
            // 
            this.btnSelected.Location = new System.Drawing.Point(429, 195);
            this.btnSelected.Name = "btnSelected";
            this.btnSelected.Size = new System.Drawing.Size(94, 46);
            this.btnSelected.TabIndex = 5;
            this.btnSelected.Text = "seçili olan";
            this.btnSelected.UseVisualStyleBackColor = true;
            this.btnSelected.Click += new System.EventHandler(this.btnSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 326);
            this.Controls.Add(this.btnSelected);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBüyükBul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBüyükBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSelected;
    }
}

