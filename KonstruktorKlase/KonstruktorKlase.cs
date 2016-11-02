using System;

namespace Vsite.CSharp
{
    public class Osoba
    {
        public readonly string Ime;
        public readonly string Prezime;
        public readonly DateTime DatumRođenja;
        public Osoba() { }
        public Osoba(string ime, string prezime, DateTime datum) { this.Ime = ime; this.Prezime = prezime; this.DatumRođenja = datum; }
    }

    public class KonstruktorKlase
    {
        public static void StvoriObjektPodrazumijevanimKonstruktorom()
        {
            Osoba O = new Osoba();

            Console.WriteLine(O.Ime);
            Console.WriteLine(O.Prezime);
            Console.WriteLine(O.DatumRođenja);

        }

        public static void StvoriObjektZadanimKonstruktorom(string ime, string prezime, DateTime datumRođenja)
        {
            Osoba O2 = new CSharp.Osoba(ime, prezime, datumRođenja);
            Console.WriteLine(O2.Ime);
            Console.WriteLine(O2.Prezime);
            Console.WriteLine(O2.DatumRođenja);

        }


        static void Main(string[] args)
        {
            StvoriObjektPodrazumijevanimKonstruktorom();

            StvoriObjektZadanimKonstruktorom("Hrvoje", "Horvat", new DateTime(1971, 7, 4));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
