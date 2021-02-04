using System;

namespace KaratsubaAlgoritmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int B = 10;
            Console.WriteLine("Kac basamakli sayilar gireceksiniz(3 den büyük): ");
            long n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İki tane "+  n + " basamakli sayi giriniz: ");
            long x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Hesaplama hesaplama = new Hesaplama();
            long k = hesaplama.Us(B, n - 2);

            long l = hesaplama.Us(B, 2 * (n - 2));

            long x1 = x / k;
            long y1 = y / k;
            long x0 = x - x1;
            long y0 = y - y1;
            long z0 = x0 * y0;
            long z2 = x1 * y1;
            long z1 = (x1 + x0) * (y1 - y0) - (z2 - z0);
            long p = z2 * l * (n - 2) + z1 * k + z0;

            Console.WriteLine("Sonuc: " + p);
        }
    }
}
