using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eyup2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList sehirler = new ArrayList();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirler.Text);

            listele();
        }

        private void listele()
        {
            lbSehirler.Items.Clear();
            foreach (string sehir in sehirler)
            {
                lbSehirler.Items.Add(sehir);
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            int indexNo = lbSehirler.SelectedIndex;
            sehirler.Insert(indexNo, txtSehirler.Text);
            listele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int indexNo = lbSehirler.SelectedIndex;
            sehirler[indexNo] = txtSehirler.Text;
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = lbSehirler.SelectedIndex;
            sehirler.RemoveAt(indexNo);
            listele();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains(txtSehirler.Text))
            {
                lblDurum.Text = "Aranan Değer Bulundu.";
                lbSehirler.SelectedIndex = sehirler.IndexOf(txtSehirler.Text);
            }
            else
            {
                lblDurum.Text = "Aranan Değer Bulunamadı.";
            }
        }
    }
} 

