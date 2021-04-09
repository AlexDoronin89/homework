using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 2 числа");

            int number1;
            number1 = int.Parse(Console.ReadLine());

            int number2;
            number2 = int.Parse(Console.ReadLine());

            int number3;



            if (number1 < number2)
            {
                Console.WriteLine("Число 1 меньше   " + number1);
            }
            else
            {
                if (number1 > number2)
                {
                    Console.WriteLine("Число 2 меньше   " + number2);
                }
            }
            Console.WriteLine("Введите 3-тье число");
            number3 = int.Parse(Console.ReadLine());

            if (number3 > number2 || number3 > number1)
            {
                Console.WriteLine("Большее число  " + number3);
            }
            else
            {
                if (number2 > number3 || number1 > number3)
                {
                    Console.WriteLine("Большее число   " + number2);
                }
            }
            if (number1 > number3)
            {
                Console.WriteLine("Большее число   "+ number1);
            }
            Console.ReadKey();
        }             
    }
}
