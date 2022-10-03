using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //Intro metodunu çağırır.
            //Intro();


            //sentence isimli string bir değişken atadık ve değişkenin değerini verdik.
            string sentence = "My name is Nedim AKCA";

            //sentence değişkeninin uzunluğunu result değişkenine atadık.
            var result = sentence.Length;

            //result değerini ekrana yazdırır.
            Console.WriteLine(result);



            //sentence değişkenini klonladım ve result2 değişkenine atadık. sentence değişkeni daha sonra değişse de ilk değerde kalmasını sağladı.
            var result2 = sentence.Clone();
            sentence = "My name is Emre AKCA";

            //result2 değerini ekrana yazdırır. result2 klonlanan sentence olması sebebiyle ilk değeri ekrana yazdıracak.
            Console.WriteLine(result2);



            //Bu cümle A harfiyle mi bitiyor?
            //EndsWith bool değer döndürür.
            bool result3 = sentence.EndsWith("A");

            //Bu cümle My name ile mi başlıyor?
            //StartsWith bool değer döndürür.
            bool result4 = sentence.StartsWith("My name");

            //Bir string de belirli bir ifadeyi ya da karakteri aramak için IndexOf kullanılır.
            var result5 = sentence.IndexOf("name");

            //name kelimesinin kaçıncı karakterde başladığını ekrana yazdırır.
            Console.WriteLine(result5);

            //sentence değişkeni içerisinde boşluk kararkterinin kaçıncı karakterde olduğunu bulur. İlk boşluğu verir. M=0 y=1 ve boşluk da 2'dir.
            var result6 = sentence.IndexOf(" ");

            //boşluğun kaçıncı karakterde olduğunu ekrana yazdırır. Değer 2
            Console.WriteLine(result6);

            //Sondan geriye doğru aramak için LastIndexOf kullanılır.
            var result7 = sentence.LastIndexOf(" ");

            //Son boşluğun kaçıncı karakterde olduğunu ekrana yazdırır.
            Console.WriteLine(result7);

            //0. karakterden itibaren (yani cümlenin başına) Hello virgül ve bir boşluk ekledik.
            var result8 = sentence.Insert(0, "Hello, ");

            //Hello virgül ve bir boşluk eklenmiş cümleyi ekrana yazdırır.
            Console.WriteLine(result8);

            //Substring metni parçalamaya yarar. 3. karakterden itibaren aldık.
            //var result9 = sentence.Substring(3);

            //3. karakterden itibaren 4 karakter al.
            var result9 = sentence.Substring(3, 4);

            //Parzçalanmış metni ekrana yazdırır.
            Console.WriteLine(result9);

            //ToLower küçük harfe dönüştürür.
            var result10 = sentence.ToLower();

            //Küçük harfe dönüştürülen metni ekrana yazdırır.
            Console.WriteLine(result10);

            //ToUpper büyük harfe dönüştürür.
            var result11 = sentence.ToUpper();

            //Büyük harfe dönüştürülen metni ekrana yazdırır.
            Console.WriteLine(result11);

            //Replace aranan karakteri belirlenen karakterle değiştirir. Burada boşluk karakterlerini - ile değiştirdik.
            var result12 = sentence.Replace(" ", "-");

            //Değiştirilen karakterle metni ekrana yazdırır.
            Console.WriteLine(result12);

            //Remove belirlenen indexten sonrasını belirlenen karakter sayısını atmaya yarar. " name" kaldırdık.
            var result13 = sentence.Remove(2, 5);

            //Çıkarılan karakterler olmadan metni ekrana yazdırır.
            Console.WriteLine(result13);






            //Konsolun açık kalmasını sağlar.
            Console.ReadLine();
        }




        private static void Intro()
        {
            //string metinsel ifadeleri tanımlamakta kullanılır.
            //string ler char array (dizi) idir.
            string city = "Karabük";

            //city değişkeninin 0. öğesini ekrana yazdırır.
            Console.WriteLine(city[0]);



            //string char array olması sebebiyle foreach ile öğeleri döndürülebilir.
            //city değişkeninin her bir öğesini alt alta yazdırma
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }


            //string ifadeler toplanabilir.
            string city2 = "İstanbul";
            //city ile city2 değişkenlerini topladığımızda iki metni yan yana yazar.
            string result = city + city2;
            Console.WriteLine(result);

            //result değişkenini oluşturmadan ekrana yazdırdık.
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }

    }
}
