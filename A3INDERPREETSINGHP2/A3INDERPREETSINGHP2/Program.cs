using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3INDERPREETSINGHP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int scndNum;
            string operation;
            int result;
            try
            {
            again:
                Console.Write("ENTER NOMBRE UN (FRENCH) : ");
                firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("ENTER NOMBRE DEUX(FRENCH): ");
                scndNum = Convert.ToInt32(Console.ReadLine());
            num:
                Console.Write("enter expressions for addition subtraction multiplication & division ");
                operation = Console.ReadLine();
                if (operation == "multiplication")
                {
                    result = firstNum * scndNum;
                    Console.WriteLine(firstNum + "x" + scndNum + "=" + result);
                    goto again;
                }
                else if (operation == "division")
                {
                    result = firstNum / scndNum;
                    Console.WriteLine(firstNum + "/" + scndNum + "=" + result);
                    goto again;
                }
                else if (operation == "addition")
                {
                    result = firstNum + scndNum;
                    Console.WriteLine(firstNum + "+" + scndNum + "=" + result);
                    goto again;
                }
                if (operation == "subraction")
                {
                    result = firstNum - scndNum;
                    Console.WriteLine(firstNum + "-" + scndNum + "=" + result);
                    goto again;
                }
                else
                {
                    Console.WriteLine("Enter a valid operation!!!");
                    goto num;
                }

            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Enter a valid arithmetic expression!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid format!!!");
            }
        }
    }
}
