using System;

namespace Vsite.CSharp
{
    class Bazna
    {
        public Bazna() { A = 5; }

        protected Bazna(int a) // konstruktor je protected!
        {
            A = a;
            Console.WriteLine(string.Format("Bazna.Bazna({0})", a));
        }

        public readonly int A;
    }

    class Izvedena : Bazna
    {
        public Izvedena(): this(3,5)
        {
            Console.WriteLine(string.Format("Izvedena.Izvedena()"));
        }

        public Izvedena(int a, int b): base(a)
        {
            B = b;
            Console.WriteLine(string.Format("Izvedena.Izvedena({0}, {1})", a, b));
        }


        public readonly int B;
    }

    public class DelegiranjeKonstruktora
    {
        public static void StvoriInstancuBazneKlase()
        {

            Bazna b = new CSharp.Bazna();
            Console.WriteLine(b.A);
        }

        public static void StvoriInstancuIzvedeneKlasePraznimKonstruktorom()
        {
            Izvedena i = new CSharp.Izvedena();

            Console.WriteLine(i.A);
            Console.WriteLine(i.B);
        }

        public static void StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(int a, int b)
        {

            Izvedena i = new Izvedena(5,3);
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);

        }

        static void Main(string[] args)
        {
            StvoriInstancuBazneKlase();

            StvoriInstancuIzvedeneKlasePraznimKonstruktorom();

            StvoriInstancuIzvedeneKlaseKonstruktoromSDvaArgumenta(5, 7);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }

}
