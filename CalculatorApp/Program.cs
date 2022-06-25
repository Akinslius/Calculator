using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            double num1,num2;
            Console.WriteLine("Enter the two numbers one after the other");
            num1= Convert.ToDouble( Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /)");
            op = Console.ReadLine()[0];

            switch (op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}",num1 ,num2,(num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;

                case '/':
                    if(num2 == 0.0)
                    {
                        Console.WriteLine("Divide by Zero situation");
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                        
                    }
                    break;

                default:
                    Console.WriteLine("{0} is not a valid operator",op);
                    break;

            }

            Console.WriteLine("Press Any key to exit the Program");
            Console.ReadKey();
           
            
           

             




        }
    }
}
