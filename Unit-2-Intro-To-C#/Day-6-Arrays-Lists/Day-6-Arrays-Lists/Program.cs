namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
 static void Main(string[] args)
 {
  // Define an array to hold 5 numbers
  int[] numbers = new int[5]; // numbers.Length =3; 2 is the largest allowable index


  // Define a variable to hold the sum of the numbers
  int sum = 0;

  Console.WriteLine("--- Starting program ---");

  //Normally we process an array from beginning to end
  // (From the first element to the last element, one at a time)
  //
  // a for-loop will loop through a process counting as it does so
  // a for-loop is an excellent tool for processing an array from start to end

  // standard syntax: for(i=0; i < arrayName.length; i++)
  //
  // arrayName.length is the number of elements in the array


  //index loop as
  //start long as the index increment the
  // at 0 is not outside array index for each loop

  int i;
  for (i = 0; i < numbers.Length; i++) // i=0, 1, 2 inside loop and 3 when exit loop
  {
   Console.WriteLine("Please enter a number:  "); // Asking for the number
   numbers[i] = int.Parse(Console.ReadLine()); // Get a line from the keyboard //convert it to an int //store it in numbers [i]


   for (i = 0; i < numbers.Length; i++)
   {
    Console.WriteLine("Element #" + i +  "is: " + numbers[i]);
    sum = sum + numbers[i]; // Add the number to the sum
   }
   // Ask for the numbers one at time using the C# Console object
   //     which represents the keyboard and screen
   // Console.ReadLine() returns a string from keyboard - cannot store in an int
   

   // int.Parse(string) will convert a string to an int
   // number1 = int.Parse(theResponse);

   // Console.WriteLine("Please enter a number:  ");
   //  theResponse = Console.ReadLine(); // Reuse theResponse define above
   // number2 = int.Parse(theResponse);

   //  Console.WriteLine("Please enter a number:  ");
   // theResponse = Console.ReadLine(); // Reuse theResponse define above
   // number3 = int.Parse(theResponse);

   //Console.WriteLine("Please enter a number:  ");
   // theResponse = Console.ReadLine(); // Reuse theResponse define above
   // number4 = int.Parse(theResponse);


   // Console.WriteLine("Please enter a number:  ");
   //theResponse = Console.ReadLine(); // Reuse theResponse define above
   // number5 = int.Parse(theResponse);



   // Add the numbers together create a sum/total
   //sum = number1 + number2 + number3 + number4 + number5;

   // Tell the requester the sum/total (display)
   Console.WriteLine("The sum is: " + sum);

   Console. WriteLine(" The average of the numbers is: " + (double) (sum / numbers.Length));
   
   Console.WriteLine("--- Ending program ---");
  }
 }
}