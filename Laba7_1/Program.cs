using System;
using System.Collections.Generic;
namespace Laba7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CompInv<Furniture> cp = new CompInv<Furniture>();
            var list = new List<Furniture>();

            list.Add(new Furniture("Стіл", 1000,400));
            list.Add(new Furniture("Стілець", 2000,100 ));
            list.Add(new Furniture("Диван", 5000, 500));
            list.Add(new Furniture("Ліжко", 3000, 600));


            Console.WriteLine("Каталог до сортировки: \n");
            foreach (Furniture a in list)
                Console.WriteLine(a);

            Console.WriteLine("Каталог після сортировки за ціною: \n");
            list.Sort();

            foreach (Furniture a in list)
                Console.WriteLine(a);

            Console.WriteLine("Каталог після сортировки за ціною і габаритом: \n");
            list.Sort(cp);

            foreach (Furniture a in list)
                Console.WriteLine(a);



            Arr arr = new Arr();

            foreach (int i in arr)
                Console.Write(i + "\t");

            Console.ReadLine();
        }
    }
}
