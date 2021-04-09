using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Введите число a и b");

                int a;
                a = int.Parse(Console.ReadLine());
                int b;
                b = int.Parse(Console.ReadLine());

                int result = a + b;

                Console.WriteLine("Сумма чисел a и b:  " + result);
            }
            Console.ReadKey();
        }
    }
}
