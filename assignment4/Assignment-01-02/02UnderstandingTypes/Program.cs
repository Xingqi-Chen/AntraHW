// Practice number sizes and ranges
using System.Text;

Console.WriteLine($"sbyte   {sizeof(sbyte), -15} {sbyte.MinValue, -30} {sbyte.MaxValue}");
Console.WriteLine($"byte    {sizeof(byte),-15} {byte.MinValue,-30} {byte.MaxValue}");
Console.WriteLine($"short   {sizeof(short),-15} {short.MinValue,-30} {short.MaxValue}");
Console.WriteLine($"ushort  {sizeof(ushort),-15} {ushort.MinValue,-30} {ushort.MaxValue}");
Console.WriteLine($"int     {sizeof(int),-15} {int.MinValue,-30} {int.MaxValue}");
Console.WriteLine($"uint    {sizeof(uint),-15} {uint.MinValue,-30} {uint.MaxValue}");
Console.WriteLine($"long    {sizeof(long),-15} {long.MinValue,-30} {long.MaxValue}");
Console.WriteLine($"ulong   {sizeof(ulong),-15} {ulong.MinValue,-30} {ulong.MaxValue}");
Console.WriteLine($"float   {sizeof(float),-15} {float.MinValue,-30} {float.MaxValue}");
Console.WriteLine($"double  {sizeof(double),-15} {double.MinValue,-30} {double.MaxValue}");
Console.WriteLine($"decimal {sizeof(decimal),-15} {decimal.MinValue,-30} {decimal.MaxValue}");

// Centuries Convertor
Console.Write("Input: ");
string? input = Console.ReadLine();
if(input != null)
{
    int centuries = int.Parse(input);

    int yearsPC = 100;
    int daysPY = 365;
    int hoursPD = 24;
    int minutesPH = 60;
    int secondsPM = 60;
    int millisecondsPS = 1000;
    int microsecondsPM = 1000;
    int nanosecondsPM = 1000;

    long years = (long) (centuries * yearsPC);
    long days = years * daysPY;
    long hours = days * hoursPD;
    long minutes = hours * minutesPH;
    long seconds = minutes * secondsPM;
    long milliseconds = seconds * millisecondsPS;
    long microseconds = milliseconds * microsecondsPM;
    long nanoseconds = microseconds * nanosecondsPM;

    Console.WriteLine($"Output: {centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
}

// FizzBuzz
StringBuilder sb = new StringBuilder();
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        sb.Append("fizzbuzz ");
    }
    else if (i % 3 == 0)
    {
        sb.Append("fizz ");
    }
    else if (i % 5 == 0)
    {
        sb.Append("buzz ");
    }
    else
    {
        sb.Append($"{i} ");
    }
}
Console.WriteLine(sb.ToString());

// number guessing
int correctNumber = new Random().Next(3) + 1;
string? guess = Console.ReadLine();
if(guess != null)
{
    int gn = int.Parse(guess);
    if(gn == correctNumber)
    {
        Console.WriteLine("Correct");
    }else if(gn < 1 || gn > 3)
    {
        Console.WriteLine("Outside the range");
    }else if(gn > correctNumber)
    {
        Console.WriteLine("Too high");
    }else if(gn < correctNumber)
    {
        Console.WriteLine("Too low");
    }
}

// Print-a-Pyramid
for(int y = 0; y < 9; y++)
{
    if(y % 2 == 1)
    {
        Console.WriteLine();
    }
    else
    {
        for(int a = 0; a < (9-y)/2; a++)
        {
            Console.Write(" ");
        }
        for(int a = 0; a < y+1; a++)
        {
            Console.Write("*");
        }
        for (int a = 0; a < (9 - y) / 2; a++)
        {
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// Birth date
DateTime birthDate = new DateTime(2000, 5, 30);
TimeSpan age = DateTime.Now - birthDate;
int ageDays = age.Days;
Console.WriteLine($"The person is {ageDays} days old.");
int daysToNextAnniversary = 10000 - (ageDays % 10000);
Console.WriteLine($"Extra: {daysToNextAnniversary}");

// Greeting
int hour = DateTime.Now.Hour;
if(hour > 4 && hour <= 11)
{
    Console.WriteLine("Good Morning");
}else if(hour > 11 && hour <= 18)
{
    Console.WriteLine("Good Afternoon");
}else if(hour > 18 && hour <= 21)
{
    Console.WriteLine("Good Evening");
}
else
{
    Console.WriteLine("Good Night");
}

// Counting up to 24
for (int a = 1; a <= 4; a++)
{
    StringBuilder lineSb = new StringBuilder();
    for (int b = 0; b <= 24; b += a)
    {
        lineSb.Append($"{b},");
    }
    lineSb.Length--;
    lineSb.Append('\n');
    Console.WriteLine(lineSb.ToString());
}