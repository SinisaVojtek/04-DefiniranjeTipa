using System;

namespace Vsite.CSharp
{
    public enum JedinicaDuljine
    {
        Milimetar,
        Centimetar,
        Decimetar,
        Metar,
        Kilometar
    }

    public struct Udaljenost
    {
        public double Broj;
        public JedinicaDuljine Jedinica;
        public Udaljenost(double broj, JedinicaDuljine jedinica) { this.Broj = broj; this.Jedinica = jedinica; }
        public Udaljenost(double broj) { this.Broj = broj; this.Jedinica = JedinicaDuljine.Decimetar; }

    }
    public class KonstruktorStrukture
    {
        public static void PozivPodrazumijevanogKonstruktora()
        {
            Udaljenost U = new Udaljenost();

            Console.Write(U.Broj);
            Console.WriteLine(U.Jedinica);

        }

        public static void PozivKonstruktoraSDvaArgumenta(double broj, JedinicaDuljine jedinica)
        {
            Udaljenost U2 = new Udaljenost(broj, jedinica);

            Console.Write(U2.Broj);
            Console.WriteLine(U2.Jedinica);

        }

        public static void PozivKonstruktoraSJednimArgumentom(double broj)
        {
            Udaljenost U3 = new Udaljenost(broj);

            Console.Write(U3.Broj);
            Console.WriteLine(U3.Jedinica);

        }

        static void Main(string[] args)
        {

            PozivPodrazumijevanogKonstruktora();

            PozivKonstruktoraSDvaArgumenta(5, JedinicaDuljine.Kilometar);

            PozivKonstruktoraSJednimArgumentom(17);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
