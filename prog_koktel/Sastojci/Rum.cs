using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_koktel.Sastojci
{
    public class Rum : Sastojak
    {
        protected string imeRuma;

        public Rum(double decl, string ime)
        {
            this.decilitri = decl;
            this.imeRuma = ime;
        }

        public override string Prikazi()
        {
            return decilitri + "decl Ruma " + imeRuma;
        }
    }
}
