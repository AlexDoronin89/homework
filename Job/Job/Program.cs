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

            if (salary1 > salary2)
            {
                Console.WriteLine("Мин ЗП   "+ salary2);
            }
            else
            {
                if (salary1 < salary2)
                {
                    Console.WriteLine("Мин ЗП   "+ salary1);
                }
            }
            
            Console.WriteLine("Введите зарплату 3 работника");
            salary3 = int.Parse(Console.ReadLine());
            if(salary1 < salary3 || salary2 < salary3)
            {
                Console.WriteLine("Макс ЗП   "+salary3);
            }
            else
            {
                if(salary2 > salary3 || salary1 > salary3)
                {
                    Console.WriteLine("Макс ЗП   "+salary2  );
                }
            }   
       





            Console.ReadKey();
        }
    }
}
