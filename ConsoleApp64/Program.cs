using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilenpuaninnotkarsiligi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen puanınızı giriniz");
            int puan = Int32.Parse(Console.ReadLine());

            if (puan >= 0 && puan <= 49)
            {
                Console.WriteLine("Notunuz 1");
            }
            else if (puan >= 50 && puan <= 59)
            {
                Console.WriteLine("Notunuz 2");
            }
            else if (puan >= 60 && puan <= 69)
            {
                Console.WriteLine("Notunuz 3");
            }
            else if (puan >= 70 && puan <= 84)
            {
                Console.WriteLine("Notunuz 4");
            }
            else if (puan >= 85 && puan <= 100)
            {
                Console.WriteLine("Notunuz 5");
            }
            else
            {
                Console.WriteLine("Hatalı puan girdiniz. Lütfen 0 ile 100 arasında bir puan giriniz");
            }
            Console.ReadLine();
        }
    }
}