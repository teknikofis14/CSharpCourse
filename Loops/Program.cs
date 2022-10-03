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



            Console.WriteLine("for döngüsüyle yapılan işlem");
            Console.WriteLine("----------------------------");

            //ForLoop Metodunu çağırır.
            ForLoop();




            Console.WriteLine("while döngüsüyle yapılan işlem");
            Console.WriteLine("------------------------------");

            //WhileLoop Metodunu çağırır.
            WhileLoop();




            Console.WriteLine("do while döngüsüyle yapılan işlem");
            Console.WriteLine("---------------------------------");

            //DoWhileLoop Metodunu çağırır.
            DoWhileLoop();




            Console.WriteLine("for each döngüsüyle yapılan işlem");
            Console.WriteLine("---------------------------------");

            //ForEachLoop Metodunu çağırır.
            ForEachLoop();




            Console.WriteLine("ÖRNEK UYGULAMA - Bir sayının asal olup olmadığı");
            Console.WriteLine("-----------------------------------------------");

            //Örnek uygulama
            //IsPrimeNumber Metodunu çağırır.
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }





            //Konsolun açık kalmasını sağlar.
            Console.ReadLine();
        }



        private static bool IsPrimeNumber(int number)
        {
            //Örnek Uygulama
            //Konsoldan girilen bir sayının asal olup olmadığını bulan uygulama
            //IsPrimeNumber metodu true/false döndüreceği için bool olarak tanımlanmıştır.
            //
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;

                    //result false ise for döngüsünü durdurmak için i değerini sayıya atadık.
                    i = number;
                }
            }
            return result;
        }


        private static void ForEachLoop()
        {
            //for each döngüsü
            //daha çok dizilerde kullanılır.
            //dizide her bir öğeyi dolaşır.
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }


        private static void DoWhileLoop()
        {
            //do while döngüsü
            //10'dan 0'a kadar olan sayıları döndürür.
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }


        private static void WhileLoop()
        {
            //while döngüsü
            //100'den 0'a kadar olan sayıları döndürür.
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }


        private static void ForLoop()
        {
            //for döngüsü
            //1'den 100'e kadar olan sayıları döndürür.
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }


    }
}
