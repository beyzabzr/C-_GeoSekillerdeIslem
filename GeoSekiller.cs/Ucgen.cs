using System;
namespace GeometrikSekiller
{
    class Ucgen : Sekil
    {
        private int[] kenarOlcu;
        private double cevre;
        private double alan;
        private int yukseklik;
        internal Ucgen()
        {
            OlcuAl();
            if (Degerlendirme(kenarOlcu) && Degerlendirme(yukseklik))
            {
                SonucYaz("Ucgen");
            }
        }
        internal override double CevreHesapla()
        {
            return cevre = kenarOlcu[0] + kenarOlcu[1] + kenarOlcu[2];
        }
        internal override double AlanHesapla()
        {
            double s = cevre / 2;
            return alan = Math.Sqrt(s * (s - kenarOlcu[0]) * (s - kenarOlcu[1]) * (s - kenarOlcu[2]));
        }
        internal override double HacimHesapla()
        {
            return alan * yukseklik / 3;
        }
        internal override void OlcuAl()
        {
            Console.Write("Ucgenein yuksekligini girin");
            yukseklik = Kontrol(Console.ReadLine());

            kenarOlcu = new int[3];
            string[] kenarIsim = new string[] { "sag", "taban", "sol" };
            Console.WriteLine("Ucgenin kenar uzunluklarini girin");
            Yardimci.Yazdir(Sabitler.Cizgi);
            for (int i = 0; i < kenarOlcu.Length; i++)
            {
                Console.Write(kenarIsim[i] + ": ");
                int olcu = Kontrol(Console.ReadLine());
                if (Degerlendirme(olcu))
                {
                    kenarOlcu[i] = olcu;
                }
                else
                {
                    break;
                }
            }
        }
    }
}