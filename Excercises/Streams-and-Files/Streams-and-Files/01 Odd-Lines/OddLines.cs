using System;
using System.IO;

public class OddLines
{
    public static void Main()
    {
        string srcPath = "../../test.txt";
        string dstPath = "../../result.txt";
        string inputLine = String.Empty;
        int count = 1;
        using (StreamReader reader=new StreamReader(srcPath))
        {
            using (StreamWriter writer=new StreamWriter(dstPath))
            {
                while ((inputLine=reader.ReadLine())!=null)
                {
                    if (count%2!=0)
                    {
                        writer.WriteLine(inputLine);
                    }
                    count++;
                }
            }
        }
    }
}

