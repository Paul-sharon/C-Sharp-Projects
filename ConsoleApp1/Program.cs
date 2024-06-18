using System;
namespace ConsoleApp1;
internal class Program
{
    static void Main(string[] args)
    {
        int day;
        Console.WriteLine("Enter a number upto 7");
        day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("tuesday");
                break;
            case 4:
                Console.WriteLine("wednesday");
                break;
            case 5:
                Console.WriteLine("thursday");
                break;
            case 6:
                Console.WriteLine("friday");
                break;
            case 7:
                Console.WriteLine("saturday");
                break;
            default:
                Console.WriteLine("Choice correct numebr");
                break;
        }
    }
}
