namespace E7_WFA_HepsiOrada
{
    partial class SiparisGuncelle
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
            this.btntamam = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.txtsiparistutarı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(13, 161);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(75, 23);
            this.btntamam.TabIndex = 0;
            this.btntamam.Text = "TAMAM";
            this.btntamam.UseVisualStyleBackColor = true;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(170, 161);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 1;
            this.btniptal.Text = "İPTAL";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // txtsiparistutarı
            // 
            this.txtsiparistutarı.Location = new System.Drawing.Point(50, 50);
            this.txtsiparistutarı.Name = "txtsiparistutarı";
            this.txtsiparistutarı.Size = new System.Drawing.Size(157, 20);
            this.txtsiparistutarı.TabIndex = 2;
            this.txtsiparistutarı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsiparistutarı_KeyPress);
            // 
            // SiparisGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtsiparistutarı);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btntamam);
            this.Name = "SiparisGuncelle";
            this.Text = "SiparisGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntamam;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.TextBox txtsiparistutarı;
    }
}