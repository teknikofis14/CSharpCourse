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
            //Veri Tanımlamaları
            double number9 = 10.4;
            byte number7 = 0;
            byte number8 = 255;
            short number5 = -32768;
            short number6 = 32767;
            int number1 = -2147483648;
            int number2 = 2147483647;
            long number3 = -9223372036854775808;
            long number4 = 9223372036854775807;
            bool condition1 = true;
            bool condition2 = false;
            char character = 'A';
            string city = "Karabük";
            var number10 = 10;  //var ile ilk atamayı sayısal değer atadığım için number10 integer oldu.
            number10 = 'A';  //number10 değeri integer olduğu için A atadığımda 65 değerini alır.
            //number10 = "A";   Çift tırnak ile metinsel ifade atamaya çalıştığımızda uygulama hata verir.

            Console.WriteLine("VERİ TİPLERİ");
            Console.WriteLine("------------");
            Console.WriteLine("Sayısal Veri Tipleri");
            Console.WriteLine("--------------------");
            Console.WriteLine("Integer veri tipi {0} ile {1} arasında değer alır ve bellekte 32 bit yer kaplar.", number1, number2);
            Console.WriteLine("Lont veri tipi {0} ile {1} arasında değer alır ve bellekte 64 bit yer kaplar.", number3, number4);
            Console.WriteLine("Short veri tipi {0} ile {1} arasında değer alır ve bellekte 16 bit yer kaplar.", number5, number6);
            Console.WriteLine("Byte veri tipi {0} ile {1} arasında değer alır ve bellekte 8 bit -yani bir byte- yer kaplar.", number7, number8);
            Console.WriteLine("Double veri tipi {0} gibi virgüllü değer alabilir ve bellekte 64 bit yer kaplar.", number9);

            Console.WriteLine(" ");
            Console.WriteLine("Mantıksal Veri Tipleri");
            Console.WriteLine("----------------------");
            Console.WriteLine("Bool veri tipi {0} ya da {1} değerini alır ve bellekte ... bit yer kaplar.", condition1, condition2);

            Console.WriteLine(" ");
            Console.WriteLine("Atama Veri Tipleri");
            Console.WriteLine("------------------");
            Console.WriteLine("Char veri tipi {0} gibi tek bir karakteri bellekte tutar.", character);
            Console.WriteLine("String veri tipi {0} gibi metinsel öğeleri bellekte tutar.", city);

            Console.WriteLine(" ");
            Console.WriteLine("Veri Tiplerini Sayısal İfdeye Dönüştürme");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Char veri tipindeki " +character+ " karakterini sayısal ifadeye dönüştürdüğümüzde {0} değeri çıkar.", (int)character); //char değerini int ile sayısal ifadeye dönüştürdük
            Console.WriteLine("enum Days ile belirlediğim {0} sabitimi sayısal ifadeye dönüştürdüğümüzde {1} değeri çıkar. Çünkü {2} değeri {3}. değerdir.", Days.Friday, (int)Days.Friday, Days.Monday, (int)Days.Monday); //enum days ile belirlediğim sabitimi int ile sayısal ifadeye dönüştürdük
            Console.WriteLine("enum Days1 ile belirlediğim {0} sabitimi sayısal ifadeye dönüştürdüğümüzde {1} değeri çıkar. Çünkü {2} değerine {3}. değeri atadım.", Days1.Friday, (int)Days1.Friday, Days1.Monday, (int)Days1.Monday); //enum days ile belirlediğim sabitimi int ile sayısal ifadeye dönüştürdük


            Console.WriteLine(" ");
            Console.WriteLine("Sabitleri Tanımlama");
            Console.WriteLine("-------------------");
            Console.WriteLine("enum ile {0}, {1} gibi haftanın günleri belirlenebilir. Bu sayede tekrar tanımlama yapılmasına gerek kalmaz. enum class program dışına yazılır.", Days.Monday, Days.Tuesday);
            



            Console.ReadLine();
            
        }
    }
    // Sabitleri tanımlamak için enum kullanılır.
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    enum Days1
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
