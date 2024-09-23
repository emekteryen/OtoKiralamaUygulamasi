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
    public partial class Siparis : Form
    {
        
        

        public Siparis(ListBox listBox1)
        {
            InitializeComponent();
            decimal toplamFaturaTutari = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Arac arac =(Arac)listBox1.Items[i];
                toplamFaturaTutari += Convert.ToDecimal(arac.Faturatutari);
            }
            label1.Text = toplamFaturaTutari.ToString();
        }
    }
}
