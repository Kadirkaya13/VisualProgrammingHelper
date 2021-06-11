
namespace GörselProgramlamaFinalÇalışması
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
            this.btnCellNum = new System.Windows.Forms.Button();
            this.btnSayac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCellNum
            // 
            this.btnCellNum.Location = new System.Drawing.Point(37, 30);
            this.btnCellNum.Name = "btnCellNum";
            this.btnCellNum.Size = new System.Drawing.Size(75, 43);
            this.btnCellNum.TabIndex = 0;
            this.btnCellNum.Text = "bakteri";
            this.btnCellNum.UseVisualStyleBackColor = true;
            this.btnCellNum.Click += new System.EventHandler(this.btnCellNum_Click);
            // 
            // btnSayac
            // 
            this.btnSayac.Location = new System.Drawing.Point(260, 30);
            this.btnSayac.Name = "btnSayac";
            this.btnSayac.Size = new System.Drawing.Size(75, 43);
            this.btnSayac.TabIndex = 1;
            this.btnSayac.Text = "sayac";
            this.btnSayac.UseVisualStyleBackColor = true;
            this.btnSayac.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 272);
            this.Controls.Add(this.btnSayac);
            this.Controls.Add(this.btnCellNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCellNum;
        private System.Windows.Forms.Button btnSayac;
    }
}

