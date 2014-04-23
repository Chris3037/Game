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

        static void Main(string[] args)
        {
            Song();
            //Welcome();
            //Object();
            //Direction();
            End();
        }

        //Welcome Function
        static void Welcome()
        {
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome to the game " + userName);
        }

        //Object Function
        static void Object()
        {
            Console.WriteLine();
        }

        //Direction Function
        static void Direction()
        {
            Console.WriteLine(dir);
            if (dir >= 8)
            {
                dir = 1;
            }
            dir++;
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
