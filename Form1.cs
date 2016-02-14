using System;
using System.Windows.Forms;

namespace E7_WFA_HepsiOrada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kategoriler = { "Teknoloji", "Temizlik", "Beyaz Eşya" };
        string[,] urunler = new string[9, 3];
        int toplamtutar;
        int sepetelemansay;
        int siparissay = 0;
        int geneltoplam = 0;
        int uruniddondur;
        private void Form1_Load(object sender, EventArgs e)
        {
            urunler[0, 0] = "Teknoloji";
            urunler[0, 1] = "laptop";
            urunler[0, 2] = "2000";

            urunler[1, 0] = "Teknoloji";
            urunler[1, 1] = "telefon";
            urunler[1, 2] = "1000";

            urunler[2, 0] = "Teknoloji";
            urunler[2, 1] = "tablet";
            urunler[2, 2] = "500";

            urunler[3, 0] = "Temizlik";
            urunler[3, 1] = "deterjan";
            urunler[3, 2] = "5";

            urunler[4, 0] = "Temizlik";
            urunler[4, 1] = "sabun";
            urunler[4, 2] = "3";

            urunler[5, 0] = "Temizlik";
            urunler[5, 1] = "şampuan";
            urunler[5, 2] = "10";

            urunler[6, 0] = "Beyaz Eşya";
            urunler[6, 1] = "çamaşır makinesi";
            urunler[6, 2] = "1250";

            urunler[7, 0] = "Beyaz Eşya";
            urunler[7, 1] = "bulaşık makinesi";
            urunler[7, 2] = "1750";

            urunler[8, 0] = "Beyaz Eşya";
            urunler[8, 1] = "fırın";
            urunler[8, 2] = "2000";

            foreach (string item in kategoriler)
            {
                cmbKategori.Items.Add(item);
                cmbKategoriSec.Items.Add(item);
            }
            cmbKategori.SelectedIndex = 0;
            cmbKategoriSec.SelectedIndex = 0;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunListeDoldur();
        }

        private void UrunListeDoldur()
        {
            lstUrunler.Items.Clear();

            for (int i = 0; i < urunler.GetLength(0); i++)
            {
                if (urunler[i, 0] == cmbKategori.SelectedItem.ToString())
                {
                    lstUrunler.Items.Add(urunler[i, 1] + "=" + urunler[i, 2] + " TL");
                }
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            sepetelemansay = lstSepet.Items.Count;
            foreach (string item in lstUrunler.SelectedItems)
            {
                lstSepet.Items.Add(item);
            }
            FiyatDizisi();
            radioBes.Checked = false;
            radioOn.Checked = false;
            radioOnBes.Checked = false;
        }



        private void radioBes_CheckedChanged(object sender, EventArgs e)
        {
            IndirimHesapla(5);
        }
        private void radioOn_CheckedChanged(object sender, EventArgs e)
        {
            IndirimHesapla(10);
        }

        private void radioOnBes_CheckedChanged(object sender, EventArgs e)
        {
            IndirimHesapla(15);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (lstSepet.Items.Count > 0)
            {
                siparissay++;

                lstTumSiparisler.Items.Add(siparissay + ". sipariş : " + lblToplamTutar.Text);

                geneltoplam += FiyatiBul(lblToplamTutar.Text);
                txtGenelToplam.Text = geneltoplam.ToString();

                lstSepet.Items.Clear();
                lblToplamUrun.Text = "";
                lblToplamTutar.Text = "";
                toplamtutar = 0;
                radioBes.Checked = false;
                radioOn.Checked = false;
                radioOnBes.Checked = false;
            }
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstTumSiparisler.SelectedIndex != -1)
            {
                int index = lstTumSiparisler.SelectedIndex;

                SiparisGuncelle altform = new SiparisGuncelle();
                altform.ShowDialog();

                if (altform.DialogResult == DialogResult.OK)
                {
                    int eskifiyat = FiyatiBul((string)lstTumSiparisler.Items[index]);
                    int yenifiyat = Convert.ToInt32(altform.deger);
                    int fark = yenifiyat - eskifiyat;

                    if (fark != 0)
                    {
                        lstTumSiparisler.Items.RemoveAt(index);
                        lstTumSiparisler.Items.Add((index + 1) + ". sipariş : güncel tutar =" + altform.deger + " TL");
                        lstTumSiparisler.Sorted = true;
                        geneltoplam += fark;
                        txtGenelToplam.Text = geneltoplam.ToString();
                    }
                    else
                        MessageBox.Show("aynı fiyatı girdiniz");
                }
            }
        }

        private int FiyatiBul(string deger)
        {
            char[] toplamdizi = deger.ToCharArray();
            int index = Array.IndexOf(toplamdizi, '=');
            int aradeger = Convert.ToInt32(deger.Substring(index + 1, (deger.Length - 3) - (index + 1)));
            return aradeger;
        }

        private void IndirimHesapla(int indirim)
        {
            if (lstSepet.Items.Count > 0)
            {
                lblToplamTutar.Text = "indirimli toplam tutar =" + (toplamtutar * (100 - indirim) / 100).ToString() + " TL";
            }

        }

        private void FiyatDizisi()
        {
            for (int i = sepetelemansay; i < lstSepet.Items.Count; i++)
            {
                string harf = lstSepet.Items[i].ToString();
                toplamtutar += FiyatiBul(harf);
                lblToplamUrun.Text = "toplam ürün =" + lstSepet.Items.Count.ToString() + " ADET";
                lblToplamTutar.Text = "toplam tutar =" + toplamtutar.ToString() + " TL";
            }
        }

        private void cmbKategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUrunSec.Items.Clear();
            for (int i = 0; i < urunler.GetLength(0); i++)
            {
                if (urunler[i, 0] == cmbKategoriSec.SelectedItem.ToString())
                {
                    cmbUrunSec.Items.Add(urunler[i, 1]);
                }
            }
            cmbUrunSec.SelectedIndex = 0;

        }

        private void cmbUrunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < urunler.GetLength(0); i++)
            {
                if (urunler[i, 1] == cmbUrunSec.SelectedItem.ToString())
                {
                    txtFiyatGuncelle.Text = urunler[i, 2];
                    uruniddondur = i;
                    break;
                }
            }

        }

        private void btnUrunBilgiGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiyatGuncelle.Text.Trim()))
            {
                if (urunler[uruniddondur, 2] != txtFiyatGuncelle.Text)
                {
                    urunler[uruniddondur, 2] = txtFiyatGuncelle.Text;
                    MessageBox.Show("Fiyat Güncellendi");
                    UrunListeDoldur();

                }

                else
                    MessageBox.Show("Aynı fiyatı girdiniz!");
            }
        }

        private void txtFiyatGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        string[] siparisMesajlari = null;
        private void btnMesajKaydet_Click(object sender, EventArgs e)
        {
            if (lstTumSiparisler.SelectedIndex > -1)
            {
                Array.Resize(ref siparisMesajlari, lstTumSiparisler.Items.Count);
                siparisMesajlari[lstTumSiparisler.SelectedIndex] = rchtxtMesaj.Text;
            }
            else
                MessageBox.Show("Lütfen sipariş seçiniz.");
        }

        private void lstTumSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTumSiparisler.SelectedIndex > -1)
            {
                try
                {
                    rchtxtMesaj.Text = siparisMesajlari[lstTumSiparisler.SelectedIndex];
                }
                catch (Exception)
                {
                    rchtxtMesaj.Text = "";
                }               
            }
        }
    }
}
