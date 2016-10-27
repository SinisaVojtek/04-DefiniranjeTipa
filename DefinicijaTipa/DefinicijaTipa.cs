using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        int broj = 5;

        public void IspišiČlan()
        {
            Console.WriteLine(broj);
        }
    }


    struct MojaStruktura
    {

        private string tekst;

        public MojaStruktura(string tekst) { this.tekst = tekst; }

        public void IspišiČlan()
        {
            Console.WriteLine(tekst);
        }
    }


    public class DefinicijaTipa
    {
        public static void IspišiČlanKlase()
        {
            MojaKlasa MK = new MojaKlasa();
            MK.IspišiČlan();
        }

        public static void IspišiČlanStrukture()
        {
            MojaStruktura MS = new CSharp.MojaStruktura("MojaStruktura");
            MS.IspišiČlan();
        }

        static void Main(string[] args)
        {
            IspišiČlanKlase();

            IspišiČlanStrukture();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
