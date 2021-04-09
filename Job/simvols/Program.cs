using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simvols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            
            string name = Console.ReadLine();
            
            Console.Write("Введите символ");
           
            string symbol = Console.ReadLine();
            for (int i = 0; i < (name.Length + 5); i++)
            {
                Console.Write(symbol);
            }
            Console.Write("\n"+ symbol + name + symbol +"\n");
            for (int i = 0; i < (name.Length + 5); i++)
            {
                Console.Write(symbol);
            }
            Console.ReadKey();
        }
    }
}
