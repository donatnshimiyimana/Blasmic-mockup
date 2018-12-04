using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Classjosue
    {
         public double num1;
        public double num2;
        public double addition(double num1, double num2){
            return (num1+num2);
        }
        public double subtruction(double num1, double num2){
            return (num1-num2);
        }
        public double multiplication(double num1, double num2){
            return (num1*num2);
        }
        public double division(double num1, double num2){
            if (num2==0)
            Console.WriteLine("invalid dnominator");
            return (num1/num2); 
        }

        public void operators()
        {
            Console.WriteLine("1.addition");
            Console.WriteLine("2.subtruction");
            Console.WriteLine("3.multiplication");
            Console.WriteLine("4.division");
        }
    }
}
