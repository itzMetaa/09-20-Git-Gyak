﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiMunka
{
    class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();

            f.init();


            Console.WriteLine("\n\nKérem nyomjon meg egy gombot a kilépéshe4z!");
            Console.ReadKey();
        }
    }
}
