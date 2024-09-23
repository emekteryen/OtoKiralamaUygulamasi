using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoKiralama
{
    public class AracTipi
    {
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        private int Kapasite
        {
            get
            {
                if (this.Ad == "Araba")
                    return 4;
                else if (this.Ad == "Otobus")
                    return 54;
                else
                    return 8;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}-kapasitesi:{1}",this.Ad,this.Kapasite.ToString());
        }
    }
}
