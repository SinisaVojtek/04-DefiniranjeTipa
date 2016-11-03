using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    public class KlasaSDestruktorom
    {
        public KlasaSDestruktorom()
        {
            RedniBroj = ++Brojač;
            string poruka = string.Format("Konstruktor objekta br. {0}", RedniBroj);
            // ispis u konzolu
            Console.WriteLine(poruka);
            // dijagnostički ispis u Output prozor Visual Studija
            Debug.WriteLine(poruka);
        }

        ~ KlasaSDestruktorom() {
            Console.WriteLine("Destruktor objekta br. {0}", RedniBroj);
            Debug.WriteLine("Destruktor objekta br. {0}.", RedniBroj); }

        public readonly int RedniBroj; // redni broj objekta

        static int Brojač = 0; // brojač ukupno stvorenih objekata
    }

    class Destruktor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            for (int i = 0; i < 100000; ++i)
            {
                KlasaSDestruktorom kld = new KlasaSDestruktorom();
            }
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Console.WriteLine("Završio sam 'Main'");
        }
    }
}
