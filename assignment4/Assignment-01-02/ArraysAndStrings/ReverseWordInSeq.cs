using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class ReverseWordInSeq
{
    static string reverseWordsInSentence(string sentence)
    {
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

        List<string> words = new List<string>();
        int startIndex = 0;
        int endIndex = 0;

        while (endIndex < sentence.Length)
        {
            if (Array.IndexOf(separators, sentence[endIndex]) != -1)
            {
                if (endIndex > startIndex)
                {
                    words.Add(sentence.Substring(startIndex, endIndex - startIndex));
                }
                words.Add(sentence[endIndex].ToString());
                startIndex = endIndex + 1;
            }
            endIndex++;
        }

        if (startIndex < endIndex)
        {
            words.Add(sentence.Substring(startIndex, endIndex - startIndex));
        }

        int i = 0;
        int j = words.Count - 1;
        while (i < j)
        {
            if (Array.IndexOf(separators, words[i][0]) != -1)
            {
                i++;
                continue;
            }
            if (Array.IndexOf(separators, words[j][0]) != -1)
            {
                j--;
                continue;
            }

            string tmp = words[i];
            words[i] = words[j];
            words[j] = tmp;
            i++;
            j--;
        }

        return string.Join("", words);
    }

    public void solution()
    {
        Console.WriteLine(reverseWordsInSentence("The quick brown fox /Yes! Really!!!/"));
    }
}
