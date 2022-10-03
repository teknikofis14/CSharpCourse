using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for döngüsü
            //1'den 100'e kadar olan sayıları döndürür.
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }



            //while döngüsü
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }



            //Konsolun açık kalmasını sağlar.
            Console.ReadLine();
        }
    }
}
