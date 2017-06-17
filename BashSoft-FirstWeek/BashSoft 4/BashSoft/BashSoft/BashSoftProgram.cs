using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleJudge;

namespace BashSoft
{
    public static class BashSoftProgram
    {
        public static void Main()
        {
            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(20);
            //Tester.CompareContent(@"m:\work\labs\actdual.txt", @"m:\work\labs\expected.txt");
            //IOManager.CreateDirectoryInCurrentFolder("*2");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");
            IOManager.ChangeCurrentDirectoryRealative("..");

        }
    }
}
