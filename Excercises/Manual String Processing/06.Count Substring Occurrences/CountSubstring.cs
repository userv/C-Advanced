using System;

public class CountSubstring
{
    public static void Main()
    {
        string inputText = Console.ReadLine();
        string pattern = Console.ReadLine();
        int count = 0;
        int index = inputText.IndexOf(pattern, StringComparison.InvariantCultureIgnoreCase);
        int startIndex = index;
        while (index != -1)
        {
            index = inputText.IndexOf(pattern, startIndex, StringComparison.InvariantCultureIgnoreCase);
            if (index != -1)
            {
                count++;
                startIndex = index + 1;
            }
        }
        Console.WriteLine(count);
    }
}

