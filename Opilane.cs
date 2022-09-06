using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._08._2022
{
    internal class Opilane : Isik
    {
        public string koolinimi;
        public string klass;
        public string spetsialiseerumine;

        public Opilane(string koolinimi, string klass, string spetsialiseerumine,string nimi,int synniaasta, Sugu isikSugu,double maksuvaba,double palk) : base(nimi,synniaasta,isikSugu,maksuvaba,palk)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks, double palk)
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
            Console.WriteLine($"Tema koolinimi on {koolinimi} ja ta õpib on {klass} eriala eest {spetsialiseerumine} ja tema tootasu on {arvutaSissetulek(palk, maksuvaba, tulumaks)}, tema nimi on {nimi} {isikSugu} ja {arvutaVanus()} aastat");
        }
    }
}
