using System;
namespace GeometrikSekiller
{
    enum Sabitler
    {
        Cizgi, Gecersiz
    }
    static class Yardimci
    {
        static string[] strings;
        static Yardimci()
        {
            strings = new string[]
            {
                "---------------------------------",
                "Gecersiz secim yaptiniz"
            };
        }
        internal static void Yazdir(Sabitler s)
        {
            string mesaj = strings[(int)s];
            Console.WriteLine(mesaj);
        }
    }
}