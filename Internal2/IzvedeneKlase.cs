using System;

namespace Vsite.CSharp
{
    public class IzvedenaIzJavneBazne : JavnaBazna
    {
    }

    public class IzvedenaIzBazne : Bazna
    {
    }



    internal class InternaBazna
    {
        public void IspišiMe()
        {
            Console.WriteLine("InternaBazna");
        }
    }

    public class IzvedenaIzInterneBazne 
    {

        public void IspišiMe()
        {
            InternaBazna ib = new CSharp.InternaBazna();
            ib.IspišiMe();
        }
    }
}
