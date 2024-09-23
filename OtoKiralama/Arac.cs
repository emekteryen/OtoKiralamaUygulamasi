using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoKiralama
{
    public class Arac
    {
        public AracTipi AracTipi { get; set; }
        public string Ad { get; set; }
        public int KiralanmaGunu { get; set; }
        public double GunlukKiraBedeli { get; set; }
        public double Faturatutari
        {
            get
            {
                return this.KiralanmaGunu * this.GunlukKiraBedeli;
            }
        }

        public Arac(AracTipi aracTipi, string ad, double gunlukKiraBedeli)
        {
            this.AracTipi = aracTipi;
            this.Ad = ad;
            this.GunlukKiraBedeli = gunlukKiraBedeli;
        }

        public override string ToString()
        {
            return String.Format("{0}-fatura Tutari:{1} TL",this.Ad,this.Faturatutari);
        }
    }
}
