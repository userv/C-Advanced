using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class WordCount
{
    public static void Main()
    {
        string wordsFile = "../../words.txt";
        string textFile = "../../text.txt";
        string resultFile = "../../result.txt";
        List<string> wordToSearch = new List<string>();
        Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
        using (StreamReader wordsReader = new StreamReader(wordsFile))
        {
            string currentWord = wordsReader.ReadLine();
            while (currentWord != null)
            {
                wordToSearch.Add(currentWord.ToLower());
                currentWord = wordsReader.ReadLine();
            }
        }
        using (StreamReader textReader = new StreamReader(textFile))
        {
            string textLine = String.Empty;
            while ((textLine = textReader.ReadLine()) != null)
            {

                string[] words = textLine.ToLower()
                    .Split(new char[] { '\n', '\r', ' ', '.', ',', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in wordToSearch)
                {
                    int count = 0;
                    foreach (var item in words)
                    {
                        if (item == word)
                        {
                            count++;
                        }
                    }
                    if (!wordsDictionary.ContainsKey(word))
                    {
                        wordsDictionary.Add(word, count);
                    }
                    else
                    {
                        wordsDictionary[word] += count;
                    }
                }
            }
        }
        using (StreamWriter writer=new StreamWriter(resultFile))
        {

            foreach (var kvp in wordsDictionary.OrderByDescending(x => x.Value))
            {
                writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}

