// Playing with Console App

using System.Text;

Console.WriteLine("What is your favorite color?");
string? color = Console.ReadLine();

Console.WriteLine("What is your astrology sign?");
string? sign = Console.ReadLine();

Console.WriteLine("What is your street address number?");
string? number = Console.ReadLine();

if(color != null && sign != null && number != null)
{
    string hackerName = $"{color}{sign}{number}";
    Console.WriteLine($"Your hacker name is {hackerName}.");
}