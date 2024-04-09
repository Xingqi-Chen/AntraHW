using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class Palindromes
{
    static string palindromes(string input)
    {
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        StringBuilder stringBuilder = new StringBuilder();

        foreach (char c in input)
        {
            if (Array.IndexOf(separators, c) != -1)
            {
                stringBuilder.Append(' ');
            }
            else
            {
                stringBuilder.Append(c);
            }
        }

        string[] words = stringBuilder.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> result = new List<string>();
        foreach (string word in words)
        {
            int i = 0;
            int j = word.Length - 1;
            bool isPalindrome = true;
            while (i < j)
            {
                if (word[i] != word[j])
                {
                    isPalindrome = false;
                    break;
                }
                i++;
                j--;
            }
            if (isPalindrome)
            {
                result.Add(word);
            }
        }
        result.Sort();
        StringBuilder sb = new StringBuilder();
        foreach (string word in result)
        {
            sb.Append(word + ", ");
        }

        if (result.Count > 0)
        {
            sb.Length -= 2;
        }

        return sb.ToString();
    }

    public void solution()
    {
        Console.WriteLine(palindromes("Hi,exe? ABBA! Hog fully a string: ExE, Bob"));
    }
}
