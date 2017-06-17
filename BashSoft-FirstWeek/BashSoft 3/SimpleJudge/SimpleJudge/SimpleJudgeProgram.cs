using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft;

namespace SimpleJudge
{
    public class SimpleJudgeProgram
    {
        public static void Main()
        {
            //  Tester.CompareContent(@"e:\Work\Labs\test2.txt", @"e:\Work\Labs\test3.txt");
            // IOManager.CreateDirectoryInCurrentFolder("pesho");
            IOManager.TraverseDirectory(0);
            IOManager.ChangeCurrentDirectoyAbsolute("R:\\");
            Console.ReadLine();
        }
    }
}
