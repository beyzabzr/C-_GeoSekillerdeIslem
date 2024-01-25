using System;
namespace GeometrikSekiller
{
    class Dikdortgen : Sekil
    {
        private int[] kenarOlcu;
        private int yukseklik;
        internal Dikdortgen()
        {
            OlcuAl();
            if (Degerlendirme(kenarOlcu) && Degerlendirme(yukseklik))
            {
                SonucYaz("Dikdortgen");
            }
        }
        internal override double CevreHesapla()
        {
            return 2 * (kenarOlcu[0] + kenarOlcu[1]);
        }
        internal override double AlanHesapla()
        {
            return kenarOlcu[0] * kenarOlcu[1];
        }
        internal override double HacimHesapla()
        {
            return kenarOlcu[0] * kenarOlcu[1] * yukseklik;
        }
        internal override void OlcuAl()
        {
            Console.Write("Dikdortgenin yuksekligini girin");
            yukseklik = Kontrol(Console.ReadLine());

            kenarOlcu = new int[2];
            string[] kenarIsim = new string[] { "genislik", "boy" };
            Console.WriteLine("Dikdortgenin kenar uzunluklarini girin");
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