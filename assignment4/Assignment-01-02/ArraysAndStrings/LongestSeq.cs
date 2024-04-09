using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class LongestSeq
{
    static int[] longestSeq(int[] array)
    {
        int longest = 0;
        int cum = 1;
        int num = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                cum++;
            }
            else
            {
                if (longest < cum)
                {
                    longest = cum;
                    num = array[i - 1];
                }
                cum = 1;
            }
        }
        if (longest < cum)
        {
            longest = cum;
            cum = 1;
            num = array[array.Length - 1];
        }
        int[] result = new int[longest];
        for (int i = 0; i < longest; i++)
        {
            result[i] = num;
        }
        return result;
    }

    public void solution()
    {
        string? oneArray = Console.ReadLine();

        string[] tmp = oneArray.Split(' ');
        int[] inputArr = new int[tmp.Length];
        for (int i = 0; i < tmp.Length; i++)
        {
            inputArr[i] = int.Parse(tmp[i]);
        }

        int[] result = longestSeq(inputArr);

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}
