using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
