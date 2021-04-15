using System;
using System.Collections.Generic;
using System.Text;

namespace GPA_Calculator
{
    public class GPA : StudentInfo // Inheriting StudentInfo Class
    {
        decimal qualityPoint { get; set; }
        decimal gradePoint { get; set; }

        public void totalQualityPoint()
        {
            // Quality Point Calculation
            qualityPoint = 0.00m;
            for (int i = 0; i < courseUnit.Count; i++)
            {
                for (int j = 0; j < gradeUnit.Count; j++)
                {
                    if (i == j)
                    {
                        qualityPoint += decimal.Round(courseUnit[i] * gradeUnit[j], 2);
                    }
                }
            }
            //Grade Point Calculation
            gradePoint = 0.00m;
            for (int i = 0; i < courseUnit.Count; i++)
            {
                gradePoint += decimal.Round(courseUnit[i], 2);
            }

        }
        //Creating Table for the Result
        public void createTable() 
        {
            Console.WriteLine("|======================= RESULTS ========================|");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Name of Student: {Name}");
            Console.ResetColor(); ;
            Console.WriteLine("|------------------|--------------|---------|------------|");
            Console.WriteLine("|    COURSE CODE   |  COURSE UNIT |  GRADE  | GRADE UNIT |");
            Console.WriteLine("|------------------|--------------|---------|------------|");
            for (int i = 0; i < courseUnit.Count; i++)
            {
                Console.WriteLine($"| {courseCode[i]}           | {courseUnit[i]}            | {grades[i]}       | {gradeUnit[i]}          |");
            }
            Console.WriteLine("|------------------|--------------|---------|------------|");
        }
        // GPA calculation and Validation
        public void getGPA() 
        {
            decimal gradePointAverage = decimal.Round(qualityPoint / gradePoint, 2);
            if (gradePointAverage <= 2.40m)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your GPA is {gradePointAverage} to 2 decimal places");
                Console.ResetColor();
            }
            else if (gradePointAverage >= 2.49m && gradePointAverage <= 3.99m)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Your GPA is {gradePointAverage} to 2 decimal places");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Your GPA is {gradePointAverage} to 2 decimal places");
                Console.ResetColor();
            }
        }

    }
}