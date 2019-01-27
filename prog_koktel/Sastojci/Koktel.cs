using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_koktel.Sastojci
{
    public class Koktel
    {
        private List<Sastojak> koktel = new List<Sastojak>();
        private string imeKoktela;
        
        public Koktel(string ime)
        {
            this.imeKoktela = ime;
        }

        public void Dodaj(Sastojak s)
        {
            koktel.Add(s);
        }

        //public void Dodaj()

        public string Posluzi()
        {
            double UkupnoDcl = 0;

            Console.WriteLine("Posluzujem koktel " + imeKoktela + "\nSastojci (" + koktel.Count() + "):");
            foreach(Sastojak s in koktel)
            {
                Console.WriteLine(s.Prikazi());
                UkupnoDcl += s.VratiDcl();
            }

            return "Potrebna casa minimalno dcl: " + UkupnoDcl;
            
        }


    }
}
