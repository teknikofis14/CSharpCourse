﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }



    interface IWorker
    {
        void Work();
        void Eat();
        void GetSallary();
    }



    class Manager : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSallary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }



    class Worker : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSallary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }



    class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSallary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }







}
