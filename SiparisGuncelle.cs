using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E7_WFA_HepsiOrada
{
    public partial class SiparisGuncelle : Form
    {
        public SiparisGuncelle()
        {
            InitializeComponent();
        }

        public string deger;

        private void btntamam_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (!string.IsNullOrEmpty(txtsiparistutarı.Text.Trim()))
            {
                deger = txtsiparistutarı.Text;
            }           
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void txtsiparistutarı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
