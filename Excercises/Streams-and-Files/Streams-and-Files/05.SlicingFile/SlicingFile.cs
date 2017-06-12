using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SlicingFile
{
    public static void Main()
    {
        string sourceFilePath = "../../test.pdf";
        string destinationDirectoryPath = "../../";
        int parts = 6;
        Slice(sourceFilePath, destinationDirectoryPath, parts);
        Console.Write("Enter file names to assemble:");
        List<string> files = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).ToList();
        Assemble(files, destinationDirectoryPath);
    }

    private static void Assemble(List<string> files, string destinationDirectoryPath)
    {
        string fileExtension = files[0].Split('.').Last();
        string dstFilePath = $"{destinationDirectoryPath}assembled.{fileExtension}";
        int numberOfParts = files.Count;
        using (FileStream writer=new FileStream(dstFilePath,FileMode.Create))
        {
            for (int i = 0; i < numberOfParts; i++)
            {
                
                using (FileStream reader=new FileStream(destinationDirectoryPath+files[i],FileMode.Open))
                {
                    long fileLength = reader.Length;
                    byte[] buffer = new byte[fileLength];
                    int readBytes = reader.Read(buffer, 0, buffer.Length);
                    writer.Write(buffer,0,readBytes);
                }
            }
            
        }
    }


    private static void Slice(string sourceFilePath, string destinationDirectoryPath, int parts)
    {
        using (FileStream reader=new FileStream(sourceFilePath,FileMode.Open))
        {
            long fileLength = reader.Length;
            string fileExtension = sourceFilePath.Split('.').Last();
            long sizeParts = fileLength / parts + fileLength % parts;
            byte[] buffer=new byte[sizeParts];
            
            for (int i = 0; i < parts; i++)
            {
                int readBytes = reader.Read(buffer, 0, buffer.Length);
                string partName = $"Part-{i}.{fileExtension}";
                string dstFilePath = destinationDirectoryPath  + partName;
                using (FileStream writer = new FileStream(dstFilePath, FileMode.Create))
                {
                    writer.Write(buffer,0,readBytes);
                }
            }
            
        }
    }
}

