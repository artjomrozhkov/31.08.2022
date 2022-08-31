using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._08._2022
{
    public abstract class Isik
    {
        public string nimi;
        public int synniaasta;
        public enum Sugu { isane,emane};
        public Sugu isikSugu;
        public double sissetulek;
        public double palk;
        public double maksuvaba;
        public double tulumaks;

        public Isik()
        { }

        public Isik(string nimi, int synniaasta, Sugu isikSugu,double maksuvaba,double palk)
        {
            this.nimi = nimi;
            this.synniaasta= synniaasta;
            this.isikSugu = isikSugu;
            this.maksuvaba = maksuvaba;
            this.palk = palk;
        }

        public abstract void print_Info();
        public abstract double arvutaSissetulek(double palk, double tulumaks,double maksuvaba);
        public void muuda_Nimi(string uusNimi) {    nimi = uusNimi; }
    }
}
