using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
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

            ~KlasaSDestruktorom() {
                Console.WriteLine("Destruktor objekta br. {0}.", RedniBroj);
                Debug.WriteLine("Destruktor objekta br. {0}.", RedniBroj);
            }

            public readonly int RedniBroj; // redni broj objekta

            static int Brojač = 0; // brojač ukupno stvorenih objekata
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine("Ušao sam u 'Main'");

            for (int i = 0; i < 1000; i++)
            {
                KlasaSDestruktorom ksd = new KlasaSDestruktorom();
            }

            Console.WriteLine("*** Pozivamo GC.Collect() ***");
            Debug.WriteLine("*** Pozivamo GC.Collect() ***");

            // explicitno pozivamo sustav za skupljanje smeća
            // redoslijed uništavanja objekata nije unaprijed određen!
            GC.Collect();

            Debug.WriteLine("*** GOTOVO!!! ***");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();

            Debug.WriteLine("*** SADA JE KONAČNO!!! ***");
        }
    }
}
