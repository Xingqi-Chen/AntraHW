using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class ReverseString
{
    static void reverseString(string input)
    {
        // convert to char array
        char[] chars = new char[input.Length];
        for (int i = input.Length - 1; i >= 0; i--)
        {
            chars[input.Length - i - 1] = input[i];
        }
        string converted = new string(chars);
        Console.WriteLine(converted);

        // print in back direction
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }

    public void solution()
    {
        reverseString(Console.ReadLine());
    }
}
