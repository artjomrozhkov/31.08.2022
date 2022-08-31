using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._08._2022
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public string eriala;
        public string kursus;
        public int toetus;
        public Kutsekooliopilane(string oppeasutus, string eriala,string kursus,int toetus, string klass, string spetsialiseerumine, string nimi, int synniaasta, Sugu isikSugu, double maksuvaba, double palk) : base(nimi, synniaasta, isikSugu, maksuvaba, palk)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
        {
            double netopalk = ((palk - maksuvaba) * (1 - (tulumaks / 100))) + maksuvaba;
            return netopalk;
        }
        public int arvutaVanus()
        {
            int praeguneAasta = DateTime.Now.Year;
            int vanus = praeguneAasta - synniaasta;
            return vanus;
        }

        public override void print_Info()
        {
            Console.WriteLine($"Tema töötab on {oppeasutus} eriala eest {eriala} on {kursus} ja toetus on {toetus} ja tema tootasu on {arvutaSissetulek(palk, maksuvaba, tulumaks)}, tema nimi on {nimi} {isikSugu} ja {arvutaVanus()}");
        }
    }

}
