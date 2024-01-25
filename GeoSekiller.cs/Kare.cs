using System;
namespace GeometrikSekiller
{
    class Kare : Sekil
    {
        private int kenar;
        private int yukseklik;
        internal Kare()
        {
            OlcuAl();
            if (Degerlendirme(kenar) && Degerlendirme(yukseklik))
            {
                SonucYaz("Kare");
            }
        }
        internal override double CevreHesapla()
        {
            return kenar * 4;
        }
        internal override double AlanHesapla()
        {
            return kenar * kenar;
        }
        internal override double HacimHesapla()
        {
            return yukseklik * (kenar * kenar);
        }
        internal override void OlcuAl()
        {
            Console.Write("Karenin kenar uzunlugunu girin: ");
            kenar = Kontrol(Console.ReadLine());
            Console.Write("Karenin yuksekligini girin: ");
            yukseklik = Kontrol(Console.ReadLine());
        }
    }
}