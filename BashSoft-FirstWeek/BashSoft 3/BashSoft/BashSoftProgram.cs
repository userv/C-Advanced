using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class BashSoftProgram
    {
        public static void Main()
        {
            //IOManager.TraverseDirectory(@"L:\Filmi");
            StudentsRepository.InitalizeData();
            StudentsRepository.GetAllStudentsFromCourse("Unity");
        }
    }
}
