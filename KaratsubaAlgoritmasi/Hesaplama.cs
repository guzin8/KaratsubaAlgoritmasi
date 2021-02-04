using System;
using System.Collections.Generic;
using System.Text;

namespace KaratsubaAlgoritmasi
{
    class Hesaplama
    {
        public long Us(long sayi, long üs)
        {
            for (int i = 1; i <= üs; i++)
            {
                sayi *= sayi;
            }
            return sayi;
        }
    }
}
