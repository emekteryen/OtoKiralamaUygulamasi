using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Arac> araclar = new List<Arac>();

        private void Form1_Load(object sender, EventArgs e)
        {
            AracTipiComboBoxiDoldur();
        }

        private void AracTipiComboBoxiDoldur()
        {
            AracTipi araba = new AracTipi();
            araba.Ad = "Araba";
            araba.Aciklama = "binek araba";
            cmbAracTipi.Items.Add(araba);

            AracTipi otobus = new AracTipi();
            otobus.Ad = "Otobus";
            otobus.Aciklama = "yolculuk için kullanılır";
            cmbAracTipi.Items.Add(otobus);

            AracTipi kamyon = new AracTipi();
            kamyon.Ad = "Kamyon";
            kamyon.Aciklama = "taşımacılık";
            cmbAracTipi.Items.Add(kamyon);

            araclar.Add(new Arac(araba, "bmw 7.40", 250));
            araclar.Add(new Arac(araba, "mercedes cla 180", 200));
            araclar.Add(new Arac(otobus, "Man new plann", 500));
            araclar.Add(new Arac(otobus, "Safir", 600));
            araclar.Add(new Arac(kamyon, "mercedes 10 teker", 300));
            araclar.Add(new Arac(kamyon, "BMC", 400));
        }

        private void cmbAracTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAracTipi.SelectedItem != null)
            {
                listView1.Items.Clear();
                AracTipi seciliAracTipi =(AracTipi)cmbAracTipi.SelectedItem;

                foreach (Arac item in araclar)
                {
                    if (item.AracTipi == seciliAracTipi)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Tag = item;
                        li.Text = item.Ad;
                        li.SubItems.Add(item.GunlukKiraBedeli.ToString());
                        listView1.Items.Add(li);
                    }
                }
            }
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Arac seciliArac =(Arac)listView1.SelectedItems[0].Tag;
                seciliArac.KiralanmaGunu = Convert.ToInt32(txtGunSayisi.Text);
                listBox1.Items.Add(seciliArac);
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Siparis sp = new Siparis(listBox1);
            sp.ShowDialog();
        }
    }
}
