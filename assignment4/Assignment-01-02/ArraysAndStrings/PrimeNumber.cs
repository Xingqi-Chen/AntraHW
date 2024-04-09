using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class PrimeNumber
{
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> list = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                list.Add(i);
            }
        }
        return list.ToArray();
    }

    public void solution()
    {
        int[] result = FindPrimesInRange(2, 100);
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
    
}
