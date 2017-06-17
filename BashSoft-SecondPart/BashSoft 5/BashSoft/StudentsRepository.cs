﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class StudentsRepository
    {
        public static bool isDataInitialized = false;
        //Dictionary <course_name, Dictionary <student_name, List<scoreOnTasks>>>
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public static void InitalizeData()
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData();
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }
        public static void InitalizeData(string fileName)
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }
        private static void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;
            string[] allInputLines = File.ReadAllLines(path);
            // string input = Console.ReadLine();
            for (int line = 0; line < allInputLines.Length; line++)
            {
                if (!string.IsNullOrEmpty(allInputLines[line]))
                {
                    string[] tokens = allInputLines[line].Split(' ');
                    string course = tokens[0];
                    string student = tokens[1];
                    int mark = int.Parse(tokens[2]);
                    if (!studentsByCourse.ContainsKey(course))
                    {
                        studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                    }
                    if (!studentsByCourse[course].ContainsKey(student))
                    {
                        studentsByCourse[course].Add(student, new List<int>());
                    }
                    studentsByCourse[course][student].Add(mark);
                    // input = Console.ReadLine();
                }
            }
            
            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private static void ReadData()
        {
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                string[] tokens = input.Split(' ');
                string course = tokens[0];
                string student = tokens[1];
                int mark = int.Parse(tokens[2]);
                if (!studentsByCourse.ContainsKey(course))
                {
                    studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                }
                if (!studentsByCourse[course].ContainsKey(student))
                {
                    studentsByCourse[course].Add(student, new List<int>());
                }
                studentsByCourse[course][student].Add(mark);
                input = Console.ReadLine();
            }
            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }
            return false;
        }
        private static bool IsQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
            }
            return false;
        }

        public static void GetStudentScoreFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossible(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
            }
        }

        public static void GetAllStudentsFromCourse(string coursename)
        {
            if (IsQueryForCoursePossible(coursename))
            {
                OutputWriter.WriteMessageOnNewLine($"{coursename}:");
                foreach (var studentMarkEntry in studentsByCourse[coursename])
                {
                    OutputWriter.PrintStudent(studentMarkEntry);
                }
            }
        }
    }
}
