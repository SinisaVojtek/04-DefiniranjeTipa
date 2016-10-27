using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    public class BrojačInstanci
    {

        static int brojač = 0;

        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojač);
        }

        int instanca;

        public BrojačInstanci()
        {
            instanca = ++brojač;

        }

        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
