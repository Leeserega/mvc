using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace ConsoleApp1
{
    class Program
    {
        static int fib (int n)
        {
            if (n < 2) return 1;
            else return (fib(n - 2) + fib(n - 1));
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Привет, как тебя звать то ?");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, {0}", name);
            int u = 1, v = 1;
            for (int i = 1; i <= 30; i++) //Console.WriteLine("{0}", fib(i));
            {
                Console.WriteLine("{0}", u);
                int w = u + v;
                u = v;v = w;
            }
            var len = 100;
            Turtle.Speed = 6;
            Square(len);

            Turtle.PenUp();
            Turtle.Move(len);
            Turtle.PenDown();

            Turtle.Turn(30);
            Turtle.Move(len);
            Turtle.Turn(120);
            Turtle.Move(len);
            Turtle.Turn(30);

            Turtle.PenUp();
            Turtle.Move(2 * len / 3);
            Turtle.Turn(90);
            Turtle.Move(2 * len / 3);
            Turtle.Turn(90);
            Turtle.PenDown();

            Square(len / 3);
            */
            Turtle.Speed = 8;
            for (int i = 0; i < 3; i++)
            {
                draw(100, 3);
                Turtle.Turn(120);
            }
        }

        static void Square(int len)
        {
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
        }
        static void draw (int len, int n)
        {
            if (n == 0) Turtle.Move(len);
            else
            {
                draw(len / 3, n - 1);
                Turtle.Turn(-60);
                draw(len / 3, n - 1);
                Turtle.Turn(120);
                draw(len / 3, n - 1);
                Turtle.Turn(-60);
                draw(len / 3, n - 1);
            }
        }
    }
}
