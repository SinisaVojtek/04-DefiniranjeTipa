using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class SaStatičkimKonstruktorom1
    {
        public SaStatičkimKonstruktorom1() {
            Console.WriteLine("SaStatičkimKonstruktorom1.KonstruktorKlase");
        }

        static SaStatičkimKonstruktorom1() {
            Console.WriteLine("SaStatičkimKonstruktorom1.StatičkiKonstruktor");
        }

        public static void Metoda1()
        {
            Console.WriteLine("SaStatičkimKonstruktorom1.Metoda1");
        }
    }

    class SaStatičkimKonstruktorom2 : SaStatičkimKonstruktorom1
    {
        // TODO: U klasu dodati prazni konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.KonstruktorKlase"

        public SaStatičkimKonstruktorom2() {
            Console.WriteLine("SaStatičkimKonstruktorom2.KonstruktorKlase");
        }
        // TODO: U klasu dodati statički konstruktor koji će ispisati poruku "SaStatičkimKonstruktorom2.StatičkiKonstruktor"

        static SaStatičkimKonstruktorom2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.StatičkiKonstruktor");
        }

        // TODO: Ponovno pokrenuti program i pogledati ispis

        public void Metoda2()
        {
            Console.WriteLine("SaStatičkimKonstruktorom2.Metoda2");
        }
    }


    public class StatičkiKonstruktor
    {
        public static void PozoviSamoStatičkuMetodu()
        {
            SaStatičkimKonstruktorom1.Metoda1();
        }

        public static void PozoviNestatičkuMetodu()
        {
            SaStatičkimKonstruktorom2 sk = new SaStatičkimKonstruktorom2();
            sk.Metoda2();
        }
        static void Main(string[] args)
        {
            PozoviSamoStatičkuMetodu();
            Console.WriteLine();
            PozoviNestatičkuMetodu();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
