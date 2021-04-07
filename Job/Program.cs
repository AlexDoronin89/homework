using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary1;
            Console.WriteLine("Введите зарплату 1 работника");
            salary1 = int.Parse(Console.ReadLine());

            int salary2;
            Console.WriteLine("Введите зарплату 2 работника");
            salary2 = int.Parse(Console.ReadLine());

            int salary3;
            Console.WriteLine("Введите зарплату 3 работника");
            salary3 = int.Parse(Console.ReadLine());

            int result = salary3 / salary1;
            Console.WriteLine("Во столько разница разница между выс и низ зарплатой"+ result);

            Console.ReadKey();
        }
    }
}
