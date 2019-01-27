using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_koktel.Sastojci
{
    public class Sastojak
    {
        protected double decilitri;

        public double VratiDcl() { return decilitri; }

        public virtual string Prikazi()
        {
            return "Sastojak-false";
        }
    }
}
