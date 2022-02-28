using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeBiljke
{
    class Biljka
    {

    }

    class Stablo : Biljka
    {
        bool opadajuListovi;

        public Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }

        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }
    }

    class Cvijet : Biljka
    {

    }

    class Bijelogoricno : Stablo
    {

        public Bijelogoricno(bool opadajuListovi) : base(opadajuListovi)
        {
            opadajuListovi = true;
            OpadajuListovi = opadajuListovi;
        }

        public virtual string Ispis()
        {
            return "Stablu otpadaju listovi. " + OpadajuListovi + ".";
        }
    }

    class Crnogoricno : Stablo
    {
        public Crnogoricno(bool opadajuListovi) : base(opadajuListovi)
        {
            opadajuListovi = false;
            OpadajuListovi = opadajuListovi;
        }
        public virtual string Ispis()
        {

            return "Stablu otpadaju listovi. " + OpadajuListovi + ".";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor=new Crnogoricno(false);

            Console.WriteLine(Hrast.Ispis());
            Console.WriteLine(Bor.Ispis());

            Console.ReadKey();

        }
    }
}
