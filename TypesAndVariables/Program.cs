using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            short number1 = -32768;
            short number2 = 32767;
            int number3 = -2147483648;
            int number4 = 2147483647;
            long number5 = -9223372036854775808;
            long number6 = 9223372036854775807;
            Console.WriteLine("Short veri tipi {0} ile {1} arasında değer alır ve bellekte 16 bit yer kaplar.", number1, number2);
            Console.WriteLine("Integer veri tipi {0} ile {1} arasında değer alır ve bellekte 32 bit yer kaplar.", number3, number4);
            Console.WriteLine("Lont veri tipi {0} ile {1} arasında değer alır ve bellekte 64 bit yer kaplar.", number5, number6);
            Console.ReadLine();
            
        }
    }
}
