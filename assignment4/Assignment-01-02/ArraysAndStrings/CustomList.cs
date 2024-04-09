using System.Text;

namespace ArraysAndStrings;

public class CustomList
{
    private int Length = 0;
    private string[] array;
    public string print()
    {
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<Length; i++)
        {
            sb.Append($"{array[i]} ");
        }
        return sb.ToString();
    }
    public CustomList(int Len)
    {
        array = new string[Len];
    }

    public void clear()
    {
        Length = 0;
    }

    public bool add(string val)
    {
        if (Length == array.Length)
        {
            return false;
        }
        array[Length++] = val;
        return true;
    }

    public bool delete(string val)
    {
        for (int i = 0; i < Length; i++)
        {
            if (array[i] == val)
            {
                for (int j = i + 1; j < Length; j++)
                {
                    array[j - 1] = array[j];
                }
                Length--;
                return true;
            }
        }
        return false;
    }

    public void solution()
    {
        CustomList customList = new CustomList(10);
        while (true)
        {
            Console.Write("Enter command (+ item, - item, or -- to clear)):");
            string? input = Console.ReadLine();
            if (input == null)
            {
                break;
            }
            if (input == "--")
            {
                customList.clear();
            }
            else if (input[0] == '+')
            {
                customList.add(input.Substring(2));
            }
            else if (input[0] == '-')
            {
                customList.delete(input.Substring(2));
            }
            else
            {
                Console.WriteLine("Invalid input");
                break;
            }

            Console.WriteLine(customList.print());
        }
    }
}
