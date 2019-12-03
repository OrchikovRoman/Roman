using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForSkierTask;

namespace Task2_skier
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleStart();
            ConsoleMenu();
        }

        static void ConsoleStart()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("========I WELCOME YOU IN THE APP OF A SKIER=================");
            Console.WriteLine("============================================================");
        }

        static void ConsoleMenu()
        {
            bool isMenu = true;
            while (isMenu)
            {
                Console.WriteLine("\n<Press 1>: View list Skiers\n");
                Console.WriteLine("<Press 2>: Create a new skier\n");
                Console.WriteLine("<Press 3>: To remove a skier\n");
                Console.WriteLine("<Press D>: For clear Console\n");
                Console.WriteLine("<Press 9> double click: <EXIT>\n\n");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        SkierTaskKeeper.PrintSkiersList();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" = Good choice!\n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Enter the distance of the first skier training: ");
                        double distX = InputCheck();
                        Console.WriteLine("Enter the percentage of increase in distance training skier: ");
                        double growthY = InputCheck();
                        Console.WriteLine("Enter the goal of the skier in kilometers: ");
                        double targetZ = InputCheck();
                        var result = new SkierTask(distX,growthY,targetZ);
                        SkierTask.SolutionSkierTask(distX,growthY,targetZ);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" = Selected! Now you are on the dark side! \n");
                        Console.WriteLine("============================================================");
                        Console.WriteLine("Enter the number of the selected solution you are going to break down into molecules: ");
                        int target = int.Parse(Console.ReadLine());
                        SkierTaskKeeper.Delete(target);
                        break;

                    case ConsoleKey.D:
                        Console.Clear();
                        break;

                    case ConsoleKey.D9:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static double InputCheck()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number, try again");
            }
            return number;
        }
    }
}
