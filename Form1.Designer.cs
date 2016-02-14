namespace E7_WFA_HepsiOrada
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOnBes = new System.Windows.Forms.RadioButton();
            this.radioOn = new System.Windows.Forms.RadioButton();
            this.radioBes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisGec = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTumSiparisler = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUrunBilgiGuncelle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFiyatGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbUrunSec = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKategoriSec = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMesajKaydet = new System.Windows.Forms.Button();
            this.rchtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 36);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(164, 21);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 73);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstUrunler.Size = new System.Drawing.Size(164, 199);
            this.lstUrunler.TabIndex = 1;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(217, 73);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(159, 199);
            this.lstSepet.TabIndex = 1;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(182, 140);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(29, 23);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = ">>";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOnBes);
            this.groupBox1.Controls.Add(this.radioOn);
            this.groupBox1.Controls.Add(this.radioBes);
            this.groupBox1.Location = new System.Drawing.Point(12, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indirim Miktarı Seçiniz";
            // 
            // radioOnBes
            // 
            this.radioOnBes.AutoSize = true;
            this.radioOnBes.Location = new System.Drawing.Point(9, 72);
            this.radioOnBes.Name = "radioOnBes";
            this.radioOnBes.Size = new System.Drawing.Size(45, 17);
            this.radioOnBes.TabIndex = 0;
            this.radioOnBes.TabStop = true;
            this.radioOnBes.Text = "%15";
            this.radioOnBes.UseVisualStyleBackColor = true;
            this.radioOnBes.CheckedChanged += new System.EventHandler(this.radioOnBes_CheckedChanged);
            // 
            // radioOn
            // 
            this.radioOn.AutoSize = true;
            this.radioOn.Location = new System.Drawing.Point(8, 49);
            this.radioOn.Name = "radioOn";
            this.radioOn.Size = new System.Drawing.Size(45, 17);
            this.radioOn.TabIndex = 0;
            this.radioOn.TabStop = true;
            this.radioOn.Text = "%10";
            this.radioOn.UseVisualStyleBackColor = true;
            this.radioOn.CheckedChanged += new System.EventHandler(this.radioOn_CheckedChanged);
            // 
            // radioBes
            // 
            this.radioBes.AutoSize = true;
            this.radioBes.Location = new System.Drawing.Point(9, 26);
            this.radioBes.Name = "radioBes";
            this.radioBes.Size = new System.Drawing.Size(39, 17);
            this.radioBes.TabIndex = 0;
            this.radioBes.TabStop = true;
            this.radioBes.Text = "%5";
            this.radioBes.UseVisualStyleBackColor = true;
            this.radioBes.CheckedChanged += new System.EventHandler(this.radioBes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KATEGORİ SEÇİNİZ:";
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Location = new System.Drawing.Point(214, 279);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(71, 13);
            this.lblToplamUrun.TabIndex = 4;
            this.lblToplamUrun.Text = "Toplam Ürün:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(214, 298);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(73, 13);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "Toplam Tutar:";
            // 
            // btnSiparisGec
            // 
            this.btnSiparisGec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSiparisGec.Location = new System.Drawing.Point(217, 351);
            this.btnSiparisGec.Name = "btnSiparisGec";
            this.btnSiparisGec.Size = new System.Drawing.Size(98, 66);
            this.btnSiparisGec.TabIndex = 5;
            this.btnSiparisGec.Text = "SİPARİS GEÇ";
            this.btnSiparisGec.UseVisualStyleBackColor = false;
            this.btnSiparisGec.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(3, 247);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 23);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGenelToplam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstTumSiparisler);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Location = new System.Drawing.Point(397, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 341);
            this.panel1.TabIndex = 7;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(4, 317);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.ReadOnly = true;
            this.txtGenelToplam.Size = new System.Drawing.Size(132, 20);
            this.txtGenelToplam.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genel Toplam:";
            // 
            // lstTumSiparisler
            // 
            this.lstTumSiparisler.FormattingEnabled = true;
            this.lstTumSiparisler.Location = new System.Drawing.Point(3, 0);
            this.lstTumSiparisler.Name = "lstTumSiparisler";
            this.lstTumSiparisler.Size = new System.Drawing.Size(248, 238);
            this.lstTumSiparisler.TabIndex = 0;
            this.lstTumSiparisler.SelectedIndexChanged += new System.EventHandler(this.lstTumSiparisler_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(760, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(218, 341);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUrunBilgiGuncelle);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(210, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUrunBilgiGuncelle
            // 
            this.btnUrunBilgiGuncelle.Location = new System.Drawing.Point(128, 253);
            this.btnUrunBilgiGuncelle.Name = "btnUrunBilgiGuncelle";
            this.btnUrunBilgiGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunBilgiGuncelle.TabIndex = 1;
            this.btnUrunBilgiGuncelle.Text = "GUNCELLE";
            this.btnUrunBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunBilgiGuncelle.Click += new System.EventHandler(this.btnUrunBilgiGuncelle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFiyatGuncelle);
            this.groupBox4.Location = new System.Drawing.Point(7, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 71);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox2";
            // 
            // txtFiyatGuncelle
            // 
            this.txtFiyatGuncelle.Location = new System.Drawing.Point(7, 30);
            this.txtFiyatGuncelle.Name = "txtFiyatGuncelle";
            this.txtFiyatGuncelle.Size = new System.Drawing.Size(184, 20);
            this.txtFiyatGuncelle.TabIndex = 0;
            this.txtFiyatGuncelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyatGuncelle_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbUrunSec);
            this.groupBox3.Location = new System.Drawing.Point(7, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 71);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox2";
            // 
            // cmbUrunSec
            // 
            this.cmbUrunSec.FormattingEnabled = true;
            this.cmbUrunSec.Location = new System.Drawing.Point(7, 28);
            this.cmbUrunSec.Name = "cmbUrunSec";
            this.cmbUrunSec.Size = new System.Drawing.Size(184, 21);
            this.cmbUrunSec.TabIndex = 0;
            this.cmbUrunSec.SelectedIndexChanged += new System.EventHandler(this.cmbUrunSec_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKategoriSec);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cmbKategoriSec
            // 
            this.cmbKategoriSec.FormattingEnabled = true;
            this.cmbKategoriSec.Location = new System.Drawing.Point(7, 28);
            this.cmbKategoriSec.Name = "cmbKategoriSec";
            this.cmbKategoriSec.Size = new System.Drawing.Size(184, 21);
            this.cmbKategoriSec.TabIndex = 0;
            this.cmbKategoriSec.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriSec_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMesajKaydet);
            this.tabPage2.Controls.Add(this.rchtxtMesaj);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(210, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMesajKaydet
            // 
            this.btnMesajKaydet.Location = new System.Drawing.Point(129, 181);
            this.btnMesajKaydet.Name = "btnMesajKaydet";
            this.btnMesajKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMesajKaydet.TabIndex = 1;
            this.btnMesajKaydet.Text = "KAYDET";
            this.btnMesajKaydet.UseVisualStyleBackColor = true;
            this.btnMesajKaydet.Click += new System.EventHandler(this.btnMesajKaydet_Click);
            // 
            // rchtxtMesaj
            // 
            this.rchtxtMesaj.Location = new System.Drawing.Point(7, 16);
            this.rchtxtMesaj.Name = "rchtxtMesaj";
            this.rchtxtMesaj.Size = new System.Drawing.Size(197, 158);
            this.rchtxtMesaj.TabIndex = 0;
            this.rchtxtMesaj.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSiparisGec);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblToplamUrun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategori);
            this.Name = "Form1";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOnBes;
        private System.Windows.Forms.RadioButton radioOn;
        private System.Windows.Forms.RadioButton radioBes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisGec;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTumSiparisler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUrunBilgiGuncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFiyatGuncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbUrunSec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbKategoriSec;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMesajKaydet;
        private System.Windows.Forms.RichTextBox rchtxtMesaj;
    }
}

