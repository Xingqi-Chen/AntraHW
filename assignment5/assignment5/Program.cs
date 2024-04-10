
// Question 1
using assignment5;

static int[] GenerateNumbers(int len)
{
    int[] result = new int[len];
    for(int i = 1; i <= len; i++)
    {
        result[i-1] = i;
    }
    return result;
}

static void Reverse(ref int[] numbers)
{
    int i = 0;
    int j = numbers.Length - 1;
    while (i < j)
    {
        int tmp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = tmp;
        i++;
        j--;
    }
}

static void PrintNumbers(int[] numbers)
{
    for(int i=0; i< numbers.Length - 1; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.WriteLine(numbers[numbers.Length - 1]);
}

int[] numbers = GenerateNumbers(10);
Reverse(ref numbers);
PrintNumbers(numbers);

// Question 2
static int Fibonacci(int n)
{
    if(n == 1 || n == 2)
    {
        return 1;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for(int i=1; i<=10; i++)
{
    Console.Write(Fibonacci(i) + " ");
}
Console.WriteLine();

// Color and Ball
static void main()
{
    Ball ball1 = new Ball(20, new Color(20, 20, 20));
    Ball ball2 = new Ball(30, new Color(30, 30, 30));
    for(int i=1; i<=30; i++)
    {
        ball1.Throw();
        if(i == 15)
        {
            ball1.Pop();
        }
        ball2.Throw();
    }
    Console.WriteLine($"Ball1 throws {ball1.Counts}");
    Console.WriteLine($"Ball2 throws {ball2.Counts}");
}

main();