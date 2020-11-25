using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace VizeFinal
{
    public class Hesap
    {
        public int OrtalamaHesapla(int vize, int final)
        {
           int ortalama = (vize * 2 / 5) + (final * 3 / 5);
           return ortalama;
        }

        public string HarfNotuHesapla(int ortalama)
        {
            string harfNotu = null;

            if (89 <= ortalama && ortalama <= 100)
            {
                harfNotu = "AA";
            }
            if (84 <= ortalama && ortalama <= 89)
            {
                harfNotu = "BA";
            }
            if (79 <= ortalama &&ortalama <= 84)
            {
                harfNotu = "BB";
            }
            if (69 <= ortalama && ortalama <= 79)
            {
                harfNotu = "CB";
            }
            if (59 <= ortalama && ortalama <= 69)
            {
                harfNotu = "CC";
            }
            if (55 <= ortalama && ortalama <= 59)
            {
                harfNotu = "DC";
            }
            if (49 <= ortalama && ortalama <= 55)
            {
                harfNotu = "DD";
            }
            if (39 <= ortalama && ortalama <= 49)
            {
                harfNotu = "FD";
            }
            if (0 <= ortalama && ortalama <= 39)
            {
                harfNotu = "FF";
            }
            return harfNotu;
        }

        public string GecmeDurumu(string harfNotu)
        {
            string durum = null;
            if (harfNotu == "FF" ||harfNotu == "FD")
            {
                durum = "kaldı";
            }
            else
            {
                durum = "geçti";
            }

            return durum;
        }
    }
}
