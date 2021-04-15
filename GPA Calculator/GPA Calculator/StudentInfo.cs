using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GPA_Calculator
{
    public class StudentInfo
    {
        // Declaration of Class Fields
        public string Name { get; set; }
        public List<string> courseCode { get; set; }
        public List<int> courseUnit { get; set; }
        List<int> courseScore { get; set; }
        public List<char> grades { get; set; }
        public List<int> gradeUnit { get; set; }
        


        public void getStudentName() // Student Name
        {
            Console.Write("Enter your Name: ");
            Name = Console.ReadLine();
        }
        // Getting Student's Course codes, units, scores, Grades and Grade units 
        public void getStudentInput() 
        {
            courseCode = new List<string>();
            courseUnit = new List<int>();
            courseScore = new List<int>();
            // Collecting number of courses
            Console.Write("How many Courses are you Recording??  "); 
            var Courses = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Courses; i++)
            {
                // Collecting course code and validating the code
                Console.Write("Enter Course Name and Code (i.e MTH101): "); 
                var course = Console.ReadLine().ToUpper();
                string code = @"^[A-Z]{3}[0-9]{3}$"; //A course name and code can only contain 3 letters and 3 numbers with no whitespace
                Regex codex = new Regex(code);
                if (codex.IsMatch(course)) //Checks for correct input of course code
                {
                    if (!courseCode.Contains(course)) // Checks for course already recorded
                    {
                        courseCode.Add(course);
                    }
                    else
                    {
                        do
                            {
                            Console.WriteLine("Course has already been recorded");
                            Console.Write("Enter Course Name and Code: ");
                            course = Console.ReadLine().ToUpper();
                            continue;
                        } while (!codex.IsMatch(course));
                        courseCode.Add(course);
                    }
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Invalid Course");
                        Console.Write("Enter Course Name and Code: ");
                        course = Console.ReadLine().ToUpper();
                        continue;
                    } while (!codex.IsMatch(course));
                    courseCode.Add(course);
                }
                // Collecting Course Unit and Validating the unit
                Console.Write("Enter Course Unit: "); 
                var unit = Convert.ToInt32(Console.ReadLine());
                if (unit >= 1 && unit <= 5)
                {
                    courseUnit.Add(unit);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Invalid unit");
                        Console.Write("Enter Course Unit: ");
                        unit = Convert.ToInt32(Console.ReadLine());
                        continue;
                    } while (unit < 1 || unit > 5);
                    courseUnit.Add(unit);
                }
                // Collecting Course Score and Validating the Score
                Console.Write("Enter Course Score: ");  
                var score = Convert.ToInt32(Console.ReadLine());
                if (score >= 0 && score <= 100)
                {
                    courseScore.Add(score);
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Invalid Score");
                        Console.Write("Enter Course Score: ");
                        score = Convert.ToInt32(Console.ReadLine());
                        continue;
                    } while (score < 0 || score > 100);
                    courseScore.Add(score);
                }
            }
    }
               
        public void getStudentGrades()
        {
            //Assigning Grades
            grades = new List<char>();
            foreach (int course in courseScore) 
            {
                if (course >= 70)
                {
                    grades.Add('A');
                }
                else if (course >= 60)
                {
                    grades.Add('B');
                }
                else if (course >= 50)
                {
                    grades.Add('C');
                }
                else if (course >= 45)
                {
                    grades.Add('D');
                }
                else if (course >= 40)
                {
                    grades.Add('E');
                }
                else
                {
                    grades.Add('F');
                }
            }
            // Assigning Grades units
            gradeUnit = new List<int>();
            foreach (char grade in grades) 
            {
                switch (grade)
                {
                    case 'A':
                        gradeUnit.Add(5);
                        break;
                    case 'B':
                        gradeUnit.Add(4);
                        break;
                    case 'C':
                        gradeUnit.Add(3);
                        break;
                    case 'D':
                        gradeUnit.Add(2);
                        break;
                    case 'E':
                        gradeUnit.Add(1);
                        break;
                    default:
                        gradeUnit.Add(0);
                        break;
                }
            }
        }
    }
}
