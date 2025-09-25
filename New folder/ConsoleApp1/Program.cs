using System;
//using System.Data;
//using System.IO.Pipelines;
namespace HelloWOrld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(5 + 5);
            Console.WriteLine(10 - 5);
            Console.WriteLine(5 * 5);
            Console.WriteLine(10 / 2);
            Console.WriteLine(10 % 3);
            Console.WriteLine(10 / 3);
            int a = 11;
            int b = 2;
            int result = a / b;
            Console.WriteLine(result);
            long mynum = 15000000000; // data type long
            Console.WriteLine(mynum);
            bool isCSharpfun = true; //data type boolean
            bool isfishtasty = false;
            Console.WriteLine(isCSharpfun); // prints true
            Console.WriteLine(isfishtasty); // prints false
            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(4.6));
            Console.WriteLine(Math.Ceiling(4.2));
            Console.WriteLine(Math.Floor(4.7));


            bool sCSharpfun = true; //data type boolean
            bool sfishtasty = false;
            Console.WriteLine(sCSharpfun); // prints true
            Console.WriteLine(sfishtasty); // prints false
            
             bool sCSharpfu = true; //data type boolean
            bool sfishtast = false;
            Console.WriteLine(sCSharpfu); // prints true
            Console.WriteLine(sfishtast); // prints false
        }
    }
}