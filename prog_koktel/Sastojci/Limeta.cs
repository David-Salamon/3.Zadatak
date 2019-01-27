using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_koktel.Sastojci
{
    public class Limeta : Sastojak
    {
        protected double kolicina;
        
        public Limeta(double kolicina)
        {
            decilitri = 0.4;
            this.kolicina = kolicina;
            decilitri = kolicina * decilitri;
        }

        public override string Prikazi()
        {
            return kolicina + " limete";
        }



    }
}
