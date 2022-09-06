using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._08._2022
{
    class Tootaja : Isik
    {
        public string asutus;
        public string amet;

        public Tootaja(string asutus, string amet, int tootasu,string nimi, int synniaasta, Sugu isikSugu, double maksuvaba, double palk) : base(nimi, synniaasta, isikSugu, maksuvaba, palk)
        {
            this.asutus = asutus;
            this.amet = amet;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks,double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }
        public override int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - synniaasta;
            return vanus;
        }

        public override void print_Info()
        {
            Console.WriteLine($"Tema asutus koht on {asutus}, tema amet on {amet} ja tema tootasu on {arvutaSissetulek(palk,maksuvaba,tulumaks)}, tema nimi on {nimi} {isikSugu} ja {arvutaVanus()} aastat");
        }
    }
}
