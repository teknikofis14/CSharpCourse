using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;


            Add();

            //Add3 metoduna parametrik değer gönderdi.
            var result = Add3(20, 30);
            Console.WriteLine(result);

            //Add4 metodunda number2'ye varsayılan parametrik değer atandı. number1 için paranetrik değer gönderildi.
            var result2 = Add4(20);
            Console.WriteLine(result2);


            //Multiply metodu (İki değişkenli olana gider)
            var result3 = Multiply(20, 12);
            Console.WriteLine(result3);

            Console.WriteLine(Multiply(number1, number2));


            //Multiply metodu (Üç değişkenli olana gider)
            var result4 = Multiply(20, 12, 5);
            Console.WriteLine(result4);


            //Challenge Params keyword ile toplama metodu
            var result5 = Add5(12, 14, 48);
            Console.WriteLine(result5);



            Console.ReadLine();
        }

        //Don't repaet yourself (Kendini tekrar etme) için metot kullanılır.
        //class Program altına Add isimli metot tanımladık ve Main kısmında bu metodu çağırdık.
        static void Add()
        {
            Console.WriteLine("Added!");
        }


        //Add3 ve Add2 aynı işlemi yapar.
        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }


        static int Add3(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //number2'ye varsayılan parametrik değer atandı.
        //Metotlarda varsayılan parametrik değeri olan değişkinler metodun en sonuna yazılır.
        static int Add4(int number1, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }




        //Method Overloading
        //değişken sayısı farklı iki metodun isimleri aynı olabilir. İlkinde iki değişken ikincisinde ise 3 değişken gönderiliyor.
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }


        //Challenge Params keyword ile toplama metodu
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
