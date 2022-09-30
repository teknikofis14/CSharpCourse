using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Engin";
            //string student2 = "Derin";
            //string student3 = "Salih";


            //3 elemanlı bir dizi tanımlar. [] ifadesi dizi olduğunu belirtir.
            string[] students = new string[3];

            //students dizisinin ilk öğesini belirtir.
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            //students dizisindeki her bir elemanı sırasıyla student değişkenine işlem yapar.
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }



            //Üstteki dizinin farklı bir şekilde tanımlanması
            string[] students2 = new[] { "Engin", "Derin", "Salih" };

            //students2 dizisindeki her bir elemanı sırasıyla student değişkenine işlem yapar.
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }



            //Üstteki dizinin new kullanılmadan tanımlanması
            string[] students3 = { "Engin", "Derin", "Salih" };


            //Çok boyutlu diziler
            //Türkiye'nin yedi bölgesi ve her bölgesine ait 3 şehir olan bir dizi yapalım.
            //7 satır ve 3 sütunlu bir dizi oluşturur.
            string[,] regions = new string[7, 3]
            {
                { "İstanbul","İzmit","Balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"},
                { "Van","Erzurum","Ağrı"},
                { "Diyarbakır","Gaziantep","Şanlıurfa"},
            };


            //regions dizisinin satır sayısını almak için GetUpperBound(0) kullandım. 0. dimension
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {

                //regions dizisinin sütun sayısını almak için GetUpperBound(1) kullandım. 1. dimension
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }

                Console.WriteLine("**********");
            }


            //Konsol ekranında bekletir.
            Console.ReadLine();
        }
    }
}
