using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            Sum();
            Sub();
            Mlt();
        }
        static void Write()
        {
            Console.WriteLine("Hello world!!");
        }
        static void Sum()
        {
            Console.Write("Num1: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Result: ");
            Console.WriteLine(num+num2);


        }
        static void Sub()
        {
            Console.Write("Num1: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Result: ");
            Console.WriteLine(num - num2);


        }
        static void Mlt()
        {
            Console.Write("Num1: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Num2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Result: ");
            Console.WriteLine(num * num2);


        }
    }
}
