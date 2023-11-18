using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark_github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araç türü giriniz(Otomobil için [1],Kamyon için [2],[iş makinası için[3]: ");
            string aracturu = Console.ReadLine();
            Console.WriteLine("Kalınacak saati giriniz ");
            int kalınan_saat = Convert.ToInt32(Console.ReadLine());

            int odeme = 0;
            int kalınan_gün = kalınan_saat / 24;
            int kalan_saat = kalınan_saat % 24;

            if (aracturu == "1")
            {
                if (kalınan_saat >= 0 && kalınan_saat < 3)
                { odeme = odeme + 5; }
                else if (kalınan_saat >= 3 && kalınan_saat < 11)
                { odeme = 5 + (kalınan_saat - 2) * 1 + (kalınan_gün * 13); }
                else if (kalınan_saat >= 11)
                {
                    if (kalan_saat >= 2)
                    { odeme = 5 + (kalan_saat - 2) * 1 + (kalınan_gün * 13); }
                    else if (kalan_saat == 1)
                    { odeme = 5 + (kalan_saat - 1) * 1 + (kalınan_gün * 13); }
                    else if (kalan_saat == 0)
                    { odeme = (kalınan_gün * 13); }
                }
                Console.WriteLine("Aracınız için kaldığınız süre boyunca ödenecek tutar {0}", odeme);
            }
            else if (aracturu == "2")
            {
                if (kalınan_saat >= 0 && kalınan_saat < 3)
                { odeme = odeme + 8; }
                else if (kalınan_saat >= 3 && kalınan_saat < 11)
                { odeme = 8 + (kalınan_saat - 2) * 2; }
                else if (kalınan_saat >= 11)
                {
                    if (kalan_saat >= 2)
                    { odeme = 8 + (kalan_saat - 2) * 2 + (kalınan_gün * 24); }
                    else if (kalan_saat == 1)
                    { odeme = 8 + (kalan_saat - 1) * 2 + (kalınan_gün * 24); }
                    else if (kalan_saat == 0)
                    { odeme = (kalınan_gün * 24); }
                }
                Console.WriteLine("Aracınız için kaldığınız süre boyunca ödenecek tutar {0}", odeme);
            }
            else if (aracturu == "3")
            {
                if (kalınan_saat >= 0 && kalınan_saat < 3)
                { odeme = odeme + 12; }
                else if (kalınan_saat >= 3 && kalınan_saat < 11)
                { odeme = 12 + (kalınan_saat - 2) * 3; }
                else if (kalınan_saat >= 11)
                {
                    if (kalan_saat >= 2)
                    { odeme = 12 + (kalan_saat - 2) * 3 + (kalınan_gün * 36); }
                    else if (kalan_saat == 1)
                    { odeme = 12 + (kalan_saat - 1) * 3 + (kalınan_gün * 36); }
                    else if (kalan_saat == 0)
                    { odeme = (kalınan_gün * 36); }
                }
                Console.WriteLine("Aracınız için kaldığınız süre boyunca ödenecek tutar {0}", odeme);
            }
            else
            {
                Console.WriteLine("Hatalı tür girdiniz tekrar deneyiniz");
            }
            Console.ReadKey();
        }
    }
}
