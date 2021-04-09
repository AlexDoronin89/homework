using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cordinats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа от 1 до 4");

            int x;
            x = int.Parse(Console.ReadLine());

            int y;
            y = int.Parse(Console.ReadLine());

            if(x<0 && y < 0)
            {
                Console.WriteLine("1 квадрант");
                
            }
            else
                if(x>0 && y > 0)
            {
                Console.WriteLine("2 квадрант");
            }
            else
                if(x<0 && y > 0)
            {
                Console.WriteLine("3 квадрант");
            }
            else
                if(x>0 && y < 0)
            {
                Console.WriteLine("4 квадрант");
            }
            
            
            Console.ReadKey();
        }
    }
}
