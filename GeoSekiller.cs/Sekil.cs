using System;
namespace GeometrikSekiller
{
    abstract class Sekil
    {
        internal abstract void OlcuAl();
        internal abstract double AlanHesapla();
        internal abstract double CevreHesapla();
        internal abstract double HacimHesapla();
        internal bool Degerlendirme(params int[] olculer)
        {
            for (int i = 0; i < olculer.Length; i++)
            {
                if (olculer[i] < 1)
                {
                    return false;
                }
            }
            return true;
        }
        internal int Kontrol(string olcuStr)
        {
            string mesaj = null;
            int olcu = 0;
            try
            {
                olcu = int.Parse(olcuStr);
                if (!Degerlendirme(olcu))
                {
                    throw new Exception();
                }
            }
            catch (FormatException)
            {
                mesaj = "Olcu bir tam sayi olmali";
            }
            catch (Exception)
            {
                mesaj = "Olcu 0'dan buyuk olmali";
            }
            Console.WriteLine(mesaj);
            return olcu;
        }
        internal virtual void SonucYaz(string sekil)
        {
            Console.WriteLine($"\n {sekil}; \n Cevresi: {CevreHesapla()} birim \n Alani: {AlanHesapla()} birim^2 \n Hacim: {HacimHesapla()} birim \n");
        }
    }
}