using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class RotateArray
{
    static int[] rotateArray(int[] array, int c)
    {
        int[] result = new int[array.Length];

        for (int i = 0; i < c; i++)
        {
            int last = array[array.Length - 1];
            for (int j = array.Length - 1; j > 0; j--)
            {
                array[j] = array[j - 1];
            }
            array[0] = last;
            for (int j = 0; j < array.Length; j++)
            {
                result[j] += array[j];
            }
        }
        return result;
    }

    public void solution()
    {
        int[] result = new int[1];
        string? arraystr = Console.ReadLine();
        string? times = Console.ReadLine();
        if (arraystr != null && times != null)
        {
            string[] tmp = arraystr.Split(' ');
            int[] inputArr = new int[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
            {
                inputArr[i] = int.Parse(tmp[i]);
            }
            int c = int.Parse(times);
            result = rotateArray(inputArr, c);
        }
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}
