using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_koktel.Sastojci
{
    public class CocaCola : Sastojak
    {
        protected int kolicina;
        protected string vrsta;

        public CocaCola(int kolicina, string vrsta)
        {
            decilitri = 2.5;
            this.kolicina = kolicina;
            this.vrsta = vrsta;
        }

        public override string Prikazi()
        {
            return kolicina + " Coca-Cola " + vrsta;
        }
    }       
}
