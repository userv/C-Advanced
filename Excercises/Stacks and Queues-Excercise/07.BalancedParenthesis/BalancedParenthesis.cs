using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParenthesis
{
    public class BalancedParenthesis
    {
        public static void Main()
        {
            string expression = Console.ReadLine();
            char[] parenthesis = new char[] { '(', '{', '[' };
            Stack<char> parenthesisSequence = new Stack<char>();
            foreach (var ch in expression)
            {
                if (parenthesis.Contains(ch))
                {
                    parenthesisSequence.Push(ch);
                }
                
                if (parenthesisSequence.Count==0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else if (ch == ')' && parenthesisSequence.Pop() != '(')
                {
                    Console.WriteLine("NO");
                    return;
                }
                else if (ch == '}' && parenthesisSequence.Pop() != '{')
                {
                    Console.WriteLine("NO");
                    return;
                }
                else if (ch == ']' && parenthesisSequence.Pop() != '[')
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            if (parenthesisSequence.Count==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
