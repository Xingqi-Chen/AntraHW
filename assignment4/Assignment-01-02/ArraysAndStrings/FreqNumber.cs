using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class FreqNumber
{
    static int freNumber(int[] numbers)
    {

        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            if (!frequencyMap.ContainsKey(num))
            {
                frequencyMap[num] = 0;
            }
            frequencyMap[num]++;
        }

        int mostFrequentNumber = numbers[0];
        int highestFrequency = 0;

        foreach (int num in numbers)
        {
            if (frequencyMap[num] > highestFrequency || (frequencyMap[num] == highestFrequency && num < mostFrequentNumber))
            {
                mostFrequentNumber = num;
                highestFrequency = frequencyMap[num];
            }
        }

        return mostFrequentNumber;
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

        Console.WriteLine(freNumber(inputArr));
    }
}