using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ZippingSlicedFiles
{
    public static void Main()
    {
        string sourceFilePath = "../../ejko.jpeg";
        string destinationDirectoryPath = "../../";
        int parts = 6;
        Compress(sourceFilePath, destinationDirectoryPath, parts);
        Console.Write("Enter filenames to decompress:");
        List<string> files = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        Decompress(files, destinationDirectoryPath);
    }

    private static void Decompress(List<string> files, string destinationDirectoryPath)
    {
        string fileExtension = "jpeg";
        //string fileExtension = files[0].Split('.').Last();
        string dstFilePath = $"{destinationDirectoryPath}assembled.{fileExtension}";
        int numberOfParts = files.Count;
        using (FileStream writer = new FileStream(dstFilePath, FileMode.Create))
        {
            for (int i = 0; i < numberOfParts; i++)
            {

                using (FileStream reader = new FileStream(destinationDirectoryPath + files[i], FileMode.Open))
                {
                    long fileLength = reader.Length;
                    byte[] buffer = new byte[fileLength];
                    int readBytes = reader.Read(buffer, 0, buffer.Length);
                    using (GZipStream unzipStream=new GZipStream(reader,CompressionMode.Decompress,false))
                    {
                        unzipStream.Read(buffer,0,readBytes);
                        writer.Write(buffer, 0, readBytes);
                    }
                   
                }
            }

        }
    }


    private static void Compress(string sourceFilePath, string destinationDirectoryPath, int parts)
    {
        using (FileStream reader = new FileStream(sourceFilePath, FileMode.Open))
        {
            long fileLength = reader.Length;
           // string fileExtension = sourceFilePath.Split('.').Last();
            string fileExtension = "gz";
            long sizeParts = fileLength / parts + fileLength % parts;
            byte[] buffer = new byte[sizeParts];

            for (int i = 0; i < parts; i++)
            {
                int readBytes = reader.Read(buffer, 0, buffer.Length);
                string partName = $"Part-{i}.{fileExtension}";
                string dstFilePath = destinationDirectoryPath + partName;
                using (FileStream writer = new FileStream(dstFilePath, FileMode.Create))
                {
                    using (GZipStream gzStream=new GZipStream(writer,CompressionMode.Compress))
                    {
                        gzStream.Write(buffer,0,readBytes);
                    }
                   // writer.Write(buffer, 0, readBytes);
                }
            }

        }
    }
}

