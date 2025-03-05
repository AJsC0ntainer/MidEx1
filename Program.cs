using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace MidEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MidEx1 Creae a program takes numeric scores and convert 0-100 and convert to a letter grade
            
            double userInputGrade = 0;
            string gradeLetter = "";

            Console.WriteLine("Welcome to Grade Convertor");
            Console.Write("Please enter numeric Grade (0-100):");
            userInputGrade = Convert.ToDouble(Console.ReadLine());

            if (userInputGrade >= 89.5 && userInputGrade <= 100)
            {
                gradeLetter = "A";
            }
            else if (userInputGrade >= 79.5 && userInputGrade <= 89.5)
            {
                gradeLetter = "B";
            }
            else if (userInputGrade >= 69.5 && userInputGrade <= 79.5)
            {
                gradeLetter = "C";
            }
            else if (userInputGrade >= 59.5 && userInputGrade <= 69.5)
            {
                gradeLetter = "D";
            }
            else
            { 
                gradeLetter = "F";
            }

            switch (gradeLetter)
            {
                case "A":
                    Console.WriteLine("Your Grade is \"A\"");
                    break;
                case "B":
                    Console.WriteLine("Your Grade is \"B\"");
                    break;
                case "C":
                    Console.WriteLine("Your Grade is \"C\"");
                    break;
                case "D":
                    Console.WriteLine("Your Grade is \"D\"");
                    break;
                case "F":
                    Console.WriteLine("Your Grade is \"E\"");
                    break;
            }
            Console.WriteLine("Press Any Key To Exit...");
            Console.Read();

            //Pushed to Midx1 GitHub Repo
        }
    }
}
