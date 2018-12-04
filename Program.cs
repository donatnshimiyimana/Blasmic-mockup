using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            int choose;

            Console.WriteLine("enter num1");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter number2");
            number2 = Convert.ToDouble(Console.ReadLine());

            var abj = new Classjosue();
            abj.operators();

            Console.WriteLine("choose an operation");
            choose = Convert.ToInt32 (Console.ReadLine());

            switch(choose)
            {
                case 1:
                    Console.WriteLine("addition= {0}", abj.addition(number1, number2));
                    break;
                case 2:
                    Console.WriteLine("subtruction= {0}", abj.subtruction(number1, number2));
                    break;
                case 3:
                    Console.WriteLine("multiplication= {0}", abj.multiplication(number1, number2));
                    break;
                case 4:
                    Console.WriteLine("division= {0}", abj.division(number1, number2));
                    break;
            }
           

            Console.ReadLine();
        }
    }
}
