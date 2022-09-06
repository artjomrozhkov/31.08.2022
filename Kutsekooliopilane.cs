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
        public double toetus;

        public string koht;
        public int laps;
        public double perepalk;
        public double keskhinna;


        double soidutoetus = 0;
        double pohitoetus = 0;
        double eritoetus = 0;
 



        public Kutsekooliopilane(string koht,int laps, double perepalk, double keskhinna,string oppeasutus, string eriala,string kursus,double toetus, string klass, string nimi, int synniaasta, Sugu isikSugu, double maksuvaba, double palk) : base(nimi, synniaasta, isikSugu, maksuvaba, palk)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.koht = koht;
            this.laps = laps;
            this.perepalk = perepalk;
            this.keskhinna = keskhinna;

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

        public string Toetus()
        {
            if (koht != "Tallinn")
            {
                soidutoetus = 50;
            }
            if (perepalk <= 300 || laps > 2)
            {
                eritoetus = 90;
            }
            if (keskhinna >= 3.3)
            {
                pohitoetus = 60;
            }
            string toetus = $"sõidetoetus {soidutoetus}, eritoetus {eritoetus}, põhitoetus {pohitoetus}";
            return toetus;
        }
        public override void print_Info()
        {
            Console.WriteLine($"Tema töötab on {oppeasutus} eriala eest {eriala} on {kursus} ja toetus on {toetus} ja tema tootasu on {arvutaSissetulek(palk, maksuvaba, tulumaks)},{Toetus()}, tema nimi on {nimi} {isikSugu} ja {arvutaVanus()} aastat");
        }
    }

}
