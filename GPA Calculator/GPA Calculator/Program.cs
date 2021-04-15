using System;
using System.Collections.Generic;


namespace GPA_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Creating Object of GPA class and calling of methods used
            GPA studentGPA = new GPA();
            //Handling Errors that will interfere with the code
            try
            {
                studentGPA.getStudentName();
                studentGPA.getStudentInput();
                studentGPA.getStudentGrades();
                studentGPA.totalQualityPoint();
                studentGPA.createTable();
                studentGPA.getGPA();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }

    }
    
}   
