namespace gradebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //this is what I got, to be honest I'm lost at where to go from here. It prints out the lowest value correct, but the highest value it doesn't
    public class Program
    {
        //Logic = Will ask for student's name, if it's quit then will keep asking for a name.
        // Will then ask for the user's grades. Will ask for 3 grades;
        //

        private static string name;
        private static string grades;

        private static Dictionary<string, string> students = new Dictionary<string, string>();
        private static string[] arrayGrades;
        private static int[] intArrayGrades = new int[4];
        private static int lowestValue;
        private static int highestValue;
        private static double average;
        private static int averageCalc;

        public static void Main()
        {
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();

            while (name.ToLower() != "quit")
            {
                Console.WriteLine("What are your grades with spaces inbetween?");
                grades = Console.ReadLine();

                students.Add(name, grades);

                Console.WriteLine("What is your name? ");
                name = Console.ReadLine();
            }

            while (name.ToLower() == "quit")
            {
                foreach (var key in students.Keys)
                {
                    arrayGrades = students[key].Split(' ');

                    intArrayGrades = Array.ConvertAll(arrayGrades, int.Parse);
                    Array.Sort(intArrayGrades);
                    lowestValue = intArrayGrades[0];
                    highestValue = intArrayGrades[intArrayGrades.Length - 1];
                    average = intArrayGrades.Average();
                    foreach (var newKey in students.Keys)
                    {
                        Console.WriteLine("Name: {0} and GPA {1}, Highest Grade: {2} and Lowest Grade {3}", key, average, students[key], lowestValue, highestValue);
                        break;
                    }
                    break;
                }
            }
            Console.Read();
        }
    }
}