using System;
using System.Collections.Generic;  // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/
                
            // Ask the user for a name and a grade
            // Store them in a Dictionary
            
            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
            Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();
            
            // Lets add students and grades until the user indicates that they're done.
            // Loop until the user satifies a condition instead of a specific # of times
            // Replace the for loop with either a while-loop or do-while()

            string userResponse = "";
            do
            {

                // Ask the user for the student name and grade
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                Console.Write("Enter grade: ");
                double grade = Double.Parse(Console.ReadLine()); // Get student grade

                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeBook[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception


             
             {
                Console.WriteLine("Are You Done? (y/n)");
                userResponse = Console.ReadLine().ToLower(); // Get user response and convert to lower case
                if (userResponse != "y" && userResponse != "n")

                {
                    Console.WriteLine("Invalid response, please enter y or n");
                }

            } while (userResponse != "y" && userResponse != "n");

            {
                   
                {
                    
                }
            } while (userResponse != "y"); // Loop until the user is not done = "n")
           
            {
                
            }
           
            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, double> anEntry in gradeBook)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
            }
            
            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    
