using System;

namespace KarakterDegistirmeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifade: ");
            string ifade = Console.ReadLine();

            KarakterDegistirici karakterDegistirici = new KarakterDegistirici();
            string sonuc = karakterDegistirici.KarakterleriDegistir(ifade);

            Console.WriteLine("Sonuç: " + sonuc);
        }
    }

    class KarakterDegistirici
    {
        public string KarakterleriDegistir(string ifade)
        {
            if (ifade.Length >= 2)
            {
                char ilkKarakter = ifade[0];
                char sonKarakter = ifade[ifade.Length - 1];

                char[] karakterler = ifade.ToCharArray();
                karakterler[0] = sonKarakter;
                karakterler[karakterler.Length - 1] = ilkKarakter;

                return new string(karakterler);
            }
            else
            {
                return ifade;
            }
        }
    }
}
