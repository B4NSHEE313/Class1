namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence (series of words separated by whitespace - space, tab, something you can't see)
        
        
        Console.WriteLine("Please enter a sentence:");
        string sentence = Console.ReadLine();   // Get what they type and put it in a string.
        
        string[]  splitSentence = sentence.Split("A sentence, i love food"); // Split the sentence into an array of words using whitespace as the delimiter.

        for (int i = 0; i < splitSentence.Length; i++)
       
            Console.WriteLine ("Word #: " + (i+1)+ " is: " + splitSentence[i]);
            
            
        Console.WriteLine(splitSentence[0]);
        
        
        Console.WriteLine("Now let's use a For-Each Loop to print each word in the sentence:");
        
        
        
        
        {
          foreach (string aword in splitSentence)
            {
                Console.WriteLine(aword);
            }



            int currentElementNumber = 0;
            
            
        }
        }
    }
