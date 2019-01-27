using prog_koktel.Sastojci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_koktel
{
    class Program
    {
        static void Main(string[] args)
        {
            Koktel CubaLibre = new Koktel("Cuba Libre");
            CubaLibre.Dodaj(new Limeta(0.5));
            CubaLibre.Dodaj(new Rum(0.4, "Bacardi gold"));
            CubaLibre.Dodaj(new CocaCola(1, "Zero"));
            CubaLibre.Dodaj(new Led("Zdrobljeni"));
            Console.WriteLine(CubaLibre.Posluzi());

            Console.ReadLine();
        }
    }
}
