using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Bilet
    {
        protected double cenaPodstawowa;

        public Bilet()
        {


        }

        public Bilet(double cenaPodstawowa)
        {
            this.cenaPodstawowa = cenaPodstawowa;
        }
    }

    class BiletDoKina : Bilet
    {
        protected bool premiera;

        private bool trzyD;

        public BiletDoKina()
        {


        }

        public BiletDoKina(double cenaPodstawowa, bool premiera)
        {
            this.premiera = premiera;
            this.cenaPodstawowa = cenaPodstawowa;
        }

        public double ObliczCeneDoKina()
        {
            return this.cenaPodstawowa;
        }

        public void setTrzyD(bool flag)
        {
            this.trzyD = flag;
        }

        public void showPrice()
        {
            Console.WriteLine(this.cenaPodstawowa);
        }
    }

    class BiletNaBasen : Bilet
    {

        public BiletNaBasen(double cenaPodstawowa)
            : base(cenaPodstawowa)
        {

        }

        public void WyswietlCennikBasen()
        {
            Console.WriteLine(this.cenaPodstawowa + " " + (this.cenaPodstawowa / 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BiletDoKina biletJeden = new BiletDoKina();
            biletJeden.setTrzyD(true);
            BiletDoKina biletDwa = new BiletDoKina(2.5, true);

            biletJeden.showPrice();
            biletDwa.showPrice();

            BiletNaBasen biletBasen = new BiletNaBasen(15);
            biletBasen.WyswietlCennikBasen();

            // add -A
        }
    }
}
