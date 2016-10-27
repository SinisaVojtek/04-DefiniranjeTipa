using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public class KorištenjeObjekata
    {
        public static void IspišiTrenutniDatumVrijeme()
        {
            Console.WriteLine(DateTime.Now);
        }

        public static void IspišiDanašnjiDatum()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        public static void IspišiTrenutnoVrijeme()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static int IzračunajBrojDanaIzmeđuDvaDatuma(int godina1, int mjesec1, int dan1, int godina2, int mjesec2, int dan2)
        {
            DateTime datum1 = new DateTime(godina1, mjesec1, dan1);

            DateTime datum2 = new DateTime(godina2, mjesec2, dan2);

            TimeSpan period = datum2 - datum1;

            return period.Days; ;
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hr");

            IspišiTrenutniDatumVrijeme();

            IspišiDanašnjiDatum();

            IspišiTrenutnoVrijeme();

            Console.WriteLine(IzračunajBrojDanaIzmeđuDvaDatuma(2015, 5, 1, 2016, 5, 1));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

    }
}
