using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_koktel.Sastojci
{
    public class Led : Sastojak
    {
        protected string vrsta;

        public Led(string vrsta)
        {
            decilitri = 1;
            this.vrsta = vrsta;
        }

        public override string Prikazi()
        {
            return "Led " + vrsta;
        }
    }
}
