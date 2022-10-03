using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class oluşturulurken ilk harfi büyük yazılır. Ama onun örneği yazılırken ilk harfi küçük yazılır. CustomerManager Class, customerManager onun örneğidir.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();







            //Konsol ekranında bekletir.
            Console.ReadLine();
        }

    }


    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
