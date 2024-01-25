using System;
namespace GeometrikSekiller
{
    class Daire : Sekil
    {
        private static double pi;
        private int r;
        static Daire()
        {
            pi = Math.PI;
        }
        internal Daire()
        {
            OlcuAl();
            if (Degerlendirme(r))
            {
                SonucYaz("Daire");
            }
        }
        internal override double CevreHesapla()
        {
            return 2 * pi * r;
        }
        internal override double AlanHesapla()
        {
            return pi * (r * r);
        }
        internal override double HacimHesapla()
        {
            return 4 / 3 * (pi * (r * r * r));
        }
        internal override void OlcuAl()
        {
            Console.Write("Daire'nin yaricapini girin: ");
            r = Kontrol(Console.ReadLine());
        }
    }
}