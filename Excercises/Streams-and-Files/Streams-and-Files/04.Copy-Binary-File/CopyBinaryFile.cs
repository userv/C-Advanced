using System;
using System.IO;



public class CopyBinaryFile
{
    public static void Main()
    {
        string srcFilePath = "../../ejko.jpeg";
        string dstFilePath = "../../ejko-bejko.jpeg";
        using (FileStream reader = new FileStream(srcFilePath, FileMode.Open))
        {
            using (FileStream writer = new FileStream(dstFilePath, FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = reader.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    writer.Write(buffer, 0, readBytes);
                }
            }

        }
    }
}

