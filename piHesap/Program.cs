using System;

class Program
{
    static void Main()
    {
        // Dizi oluştur
        double[] oranlar = new double[10000];
        double toplam = 0;
        double cikarma = 0;

        // Diziye verileri 1/3, 1/5 gibi ekleyin
        for (int i = 0; i < oranlar.Length; i++)
        {
            oranlar[i] = 1.0 / (2 * i + 1);

            // Çift indisli elemanları toplam, tek indisli elemanları çıkarma değişkenine ekleyin
            if (i % 2 == 0)
                toplam += oranlar[i];
            else
                cikarma += oranlar[i];
        }
        // Pi sayısını hesaplayın
        double sonuc = 4 * (toplam - cikarma);

        // Sonuçları yazdır
        Console.WriteLine("Pi Sayısı : " + Math.PI);
        Console.WriteLine("Bizim Ulaştığımız Sonuç : " + sonuc);
        Console.WriteLine("İkisi Arasındaki Fark : " + (Math.PI - sonuc));

        Console.ReadKey(); // Programın kapanmaması için bekletme
    }
}
