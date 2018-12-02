using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3INDERPREETSINGHP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
        again:
            Console.WriteLine("MENU:");
            Console.WriteLine("1.display list of even numbers beginning at 0");
            Console.WriteLine("2.display sequence of perfect squares");
            Console.WriteLine("3.exit");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("DISPLAY EVEN MUMERALS");
                    string n = Console.ReadLine();
                    int num = int.Parse(n);
                    for (int i = 0; i <= num; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case "2":
                    int x = 1;
                    while (x >= 0)
                    {
                        int ans = x * x;
                        Console.WriteLine(ans);
                        Console.WriteLine("PRESS Z TO DISPLAY MENU");
                        string answer = Console.ReadLine();
                        if (answer == "Z")
                        {
                            x++;
                            Console.WriteLine(ans);
                        }
                        else
                        {
                            goto again;
                        }
                    }
                    break;
                case "3": break;

                default: goto again;
            }
        }
    }
}
