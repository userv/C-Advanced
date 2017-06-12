using System;
using System.IO;


public class LineNumbers
{
    public static void Main()
    {
        string srcPath = "../../test.txt";
        string dstPath = "../../result.txt";
        string inputLine = String.Empty;
        int count = 1;
        using (StreamReader reader = new StreamReader(srcPath))
        {
            using (StreamWriter writer = new StreamWriter(dstPath))
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    writer.WriteLine($"{count} {inputLine}");
                    count++;
                }
            }
        }
    }
}

