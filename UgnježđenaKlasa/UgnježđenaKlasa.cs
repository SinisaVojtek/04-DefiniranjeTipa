using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    public class UgnježđenaKlasa
    {
        static void Main(string[] args)
        {
            Gnijezdo g = new Gnijezdo();
            g.IspišiMe();

            IzvedenoGnijezdo ig = new IzvedenoGnijezdo();
            ig.PredstaviSe();

            IzravnoKorištenjeUgnježđeneKlase();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static void IzravnoKorištenjeUgnježđeneKlase()
        {
            Gnijezdo.Ugnježđena gu = new Gnijezdo.Ugnježđena();
            gu.PredstaviSeNeposredno();
        }
    }
}
