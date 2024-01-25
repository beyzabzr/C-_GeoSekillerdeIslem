using System;
namespace GeometrikSekiller
{
    class Program
    {
        public static void Main(string[] args)
        {
        Baslangic:
            Console.WriteLine("***Geometrik sekilerde islem yapmak***");
            Console.WriteLine("Islem yapmak istediginiz geometrik seklin numarasini girin: ");
            Console.WriteLine("\n 1. Daire \n 2. Dikdortgen \n 3. Kare \n 4. Ucgen");

            switch (Console.ReadLine())
            {
                case "1":
                    new Daire();
                    break;
                case "2":
                    new Dikdortgen();
                    break;
                case "3":
                    new Kare();
                    break;
                case "4":
                    new Ucgen();
                    break;
                default:
                    Yardimci.Yazdir(Sabitler.Gecersiz);
                    break;
            }

        Tekrar:

            Console.WriteLine();
            Console.Write("Hesap yapmaya devam etmek istiyormusunuz? [E]-Evet/ [H]-Hayir \n");
            Yardimci.Yazdir(Sabitler.Cizgi);
            switch (Console.ReadLine().ToLower())
            {
                case "e":
                    goto Baslangic;
                case "h":
                    break;
                default:
                    Yardimci.Yazdir(Sabitler.Gecersiz);
                    goto Tekrar;
            }
        }
    }
}