namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is:  1 1.24 "Bob"
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware: Early versions of C# do not allow use of == with strings
         *
         *
         * a method() is a program that processes data in an object/variable
         *
         * C# provides several methods to operate on strings:
         *
         *    Hey) - compare the string to left of the . to string inside () for equals
         *     .CompareTo(string) - return a number indicating how the first string relates to the second
         *                          return a negative number if first string is less than the second
         *                          return a zero if first string is equal the second
         *                          return a positive number if first string is greater than the second
         ***************************************************************************************************/
        // if (condition) {
        //    What to do if condition is true
        // }
        // else {
        //    What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is: " + string1);
        Console.WriteLine("string2 is: " + string2);
        
        if (string1.CompareTo(string2) > 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) < 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }
        if (string1.CompareTo(string2) == 0) // if the first string is equal second string
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal string2");
        }
        
        // Some methods that process strings
        // to see a list of all methods available to an object - just type the object name and a dot: ObjectName.
        //.Length - returns the number of characters in the string
       // . Contains(string) - returns true if the string given is inside a string ()
        // .Substring(Start-index,Length) - extract charachters from a string starting at the start index for the numbers of characters indicated by the length
       // The start index starts at 0 not 1.
       // //whenever you see the word index - starts counting at 0
       // whenever you see the position of a character - starts counting at 1
        // .StartsWith(string) - returns true if the string starts with the specified chars/Characters (case sensitive)
       // .EndsWith(string) - returns true if the string ends with the specified chars/Characters (case sensitive)
       // .Trim() - removes leading and trailing spaces from a string
       
       //string1.
       
       
       string sentence = "      My name is david and i learn C#     "; //true if sentence contains David
        Console.WriteLine("There are"+ sentence.Length+ " characters in the sentence");
        
        bool contains = sentence.Contains("david");
        Console.WriteLine("Does sentence contain david:" + contains);

        string nameInSentence = sentence.Substring(17, 5);
Console.WriteLine("Name is: " + nameInSentence);
      Console.WriteLine("Does sentence start with My?" + sentence.StartsWith("My"));
      Console.WriteLine("Does sentence start with my?" + sentence.StartsWith("my"));
      Console.WriteLine("Does sentence end with C#?" + sentence.EndsWith("C#"));

      Console.WriteLine("Result when sentence.Trim() is used to remove leading and trailing spaces");
      Console.WriteLine("Does sentence start with My?" + sentence.Trim().StartsWith("My"));
      Console.WriteLine("Does sentence start with my?" + sentence.Trim().StartsWith("my"));
      Console.WriteLine("Does sentence end with C#?" + sentence.Trim().EndsWith("C#")); 
       

     
      
      // // When C# sees a statement with chained operations (operations separated by a dot)
      // C# Process the statement from left to right, one operation at a time
      // Uses the result of operation in the next one
      
      // sentence.trim().Endswith("C#")

      // 1. sentence.Trim() - returns a string with leading and trailing spaces removed
        // 2. results-from-step1 .EndsWith("C")
      
      
    } // End of Main()
}  // End of class Program