// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
// type casting 
int a = 10;
double b = a; // implicit casting
Console.WriteLine(b.GetType());
Console.WriteLine(b);
int sum1 = 10 + 20;
int sum2 = sum1 + 30;
Console.WriteLine(sum1);
Console.WriteLine(sum2);
int x=10;
x+=5;
Console.WriteLine(x);
int y = 10;
y -= 5;
Console.WriteLine(y);
int p = 10;
p *= 5;
Console.WriteLine(p);
int q = 10;
q /= 5;
Console.WriteLine(q);
int r = 10;
r %= 3;
Console.WriteLine(r);
int k = 8;
Console.WriteLine(k > 5 && k < 10); //prints true as k is greater than 5 and less than 10
Console.WriteLine(k > 5 || k < 10); //prints true as k is greater than 5 or less than 10
Console.WriteLine(!(k > 5)); //prints false as k is greater than 5  


Console.WriteLine(k > 5 && k < 10); //prints true as k is greater than 5 and less than 10
Console.WriteLine(k > 5 || k < 10); //prints true as k is greater than 5 or less than 10
Console.WriteLine(!(k > 5)); //prints false as k is greater than 5  

Console.WriteLine(Math.Max(5, 10));
Console.WriteLine(Math.Min(5, 10));
Console.WriteLine(Math.Sqrt(64));      
Console.WriteLine(Math.Abs(-4.7));
Console.WriteLine(Math.Round(4.6));
Console.WriteLine(Math.Ceiling(4.2));
Console.WriteLine(Math.Floor(4.7));


