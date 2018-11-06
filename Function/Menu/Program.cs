using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            PrintMenu();
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine(sum(num1, num2));
                    break;

                case 2:
                    Console.WriteLine(sub(num1, num2));
                    break;

                case 3:
                    Console.WriteLine( mult(num1, num2));
                    break;

                case 4:
                    Console.WriteLine(div(num1, num2));
                    break;

                default:
                    break;
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Enter your choice: \n1. Sum \n2. Sub\n3. Mult\n4. Div\n5. Exit");

        }

        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        static int mult(int num1, int num2)
        {
            return num1 * num2;
        }

        static int div(int num1, int num2)
        {
            return num1 / num2;
        }


    }
}
