
using ArraysAndStrings;

public class CopyingAnArray
{
   void solution()
    {

        int[] array = new int[10];
        for (int i = 0; i < 10; i++)
        {
            array[i] = i;
        }

        int[] copied = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            copied[i] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        for (int i = 0; i < copied.Length; i++)
        {
            Console.Write($"{copied[i]} ");
        }
    }
}
    
