using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Program
    {
        //Public Variables
        static string userName = "";
        static int dir = 1;
        static char input = ' ';
        static bool gameOn = true;

        static void Main(string[] args)
        {
            Welcome();
            Engine();
        }

        //Welcome Function
        static void Welcome()
        {
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome to the game " + userName);
            Console.WriteLine("Use the 'A' key and the 'D' key to rotate the object.");
            Console.WriteLine("That's all you can do...");
            Engine();
        }

        //Controls Function
        static void Controls()
        {
        }

        //Direction Function
        static void Direction()
        {
        }

        //Object Function
        static void Object()
        {
            while (gameOn)
            {

                input = Console.ReadKey().KeyChar;
                if (input == 'd')
                {
                    dir++;
                }
                else if (input == 'a')
                {
                    dir--;
                }

                if (dir == 9)
                {
                    dir = 1;
                }

                if (dir == 0)
                {
                    dir = 8;
                }
                Console.Clear();
                Console.WriteLine(dir);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                if (dir == 1)
                {
                    Console.WriteLine("                                         o");
                    Console.WriteLine("                                        o o");
                    Console.WriteLine("                                       o   o");
                }
                else if (dir == 2)
                {
                    Console.WriteLine("                                          o");
                    Console.WriteLine("                                        o o");
                    Console.WriteLine("                                      o   o");
                }
                else if (dir == 3)
                {
                    Console.WriteLine("                                       o");
                    Console.WriteLine("                                         o");
                    Console.WriteLine("                                       o");
                }
                else if (dir == 4)
                {
                    Console.WriteLine("                                     o   o");
                    Console.WriteLine("                                       o o");
                    Console.WriteLine("                                         o");
                }
                else if (dir == 5)
                {
                    Console.WriteLine("                                      o   o");
                    Console.WriteLine("                                       o o");
                    Console.WriteLine("                                        o");
                }
                else if (dir == 6)
                {
                    Console.WriteLine("                                       o   o");
                    Console.WriteLine("                                       o o");
                    Console.WriteLine("                                       o");
                }
                else if (dir == 7)
                {
                    Console.WriteLine("                                         o");
                    Console.WriteLine("                                       o");
                    Console.WriteLine("                                         o");
                }
                else if (dir == 8)
                {
                    Console.WriteLine("                                        o");
                    Console.WriteLine("                                        o o");
                    Console.WriteLine("                                        o   o");
                }
            }
        }

        //Engine Function
        static void Engine()
        {
            while (gameOn)
            {
                Object();
                Thread.Sleep(50);
            }
        }

        //Song Function
        static void Song()
        {
            //E6
            Console.Beep(1318, 400);
            //B5
            Console.Beep(988, 200);
            //C6
            Console.Beep(1046, 200);
            //D6
            Console.Beep(1175, 400);
            //C6
            Console.Beep(1046, 200);
            //B5
            Console.Beep(988, 200);
            //A5
            Console.Beep(880, 400);
            Console.Beep(880, 200);
            Console.Beep(1046, 200);
            Console.Beep(1318, 400);
            Console.Beep(1175, 200);
            Console.Beep(1046, 200);
            Console.Beep(988, 600);
            Console.Beep(988, 200);
            Console.Beep(1175, 400);
            Console.Beep(1318, 400);
            Console.Beep(1046, 400);
            Console.Beep(880, 400);
            Console.Beep(880, 400);
            Thread.Sleep(600);
            Console.Beep(1175, 600);
            //F6
            Console.Beep(1397, 200);
            //A6
            Console.Beep(1760, 400);
            //G6
            Console.Beep(1568, 200);
            //F6
            Console.Beep(1397, 200);
            Console.Beep(1318, 200);
            Console.Beep(1318, 400);
            Console.Beep(1046, 200);
            Console.Beep(1318, 400);
            Console.Beep(1175, 200);
            Console.Beep(1046, 200);
            Console.Beep(988, 400);
            Console.Beep(988, 200);
            Console.Beep(1046, 200);
            Console.Beep(1175, 400);
            Console.Beep(1318, 400);
            Console.Beep(1046, 400);
            Console.Beep(880, 400);
            Console.Beep(880, 400);
        }

        //End Function
        static void End()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
