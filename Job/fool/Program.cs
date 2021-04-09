using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fool
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = -1;
            bool numberIsZero= false;
            
            while(numberIsZero == false)
            {
                Console.WriteLine("Введите число");
                userInput = int.Parse(Console.ReadLine());

                numberIsZero = userInput == 0;

                if(numberIsZero == true)
                {
                    break;
                }
                Console.WriteLine(userInput);
            }
        Console.ReadKey();
        }

    }
}
