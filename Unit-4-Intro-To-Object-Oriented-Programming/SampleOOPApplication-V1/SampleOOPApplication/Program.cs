namespace SampleOOPApplication;

class Program
{
    // Application program will define and mainpulate objects
    static void Main(string[] args)
    {
        Console.WriteLine("------ Start of Sample Object Oriented Application Made From Scratch -------");

        Person aPerson = new Person("John", 78, 250.6, 69, "Male");
        Console.WriteLine(aPerson);


        Console.WriteLine("------ End of Sample Object Oriented Application Made From Scratch -------");
    } // End of Main()

}

//if (aPerson.Equals(aPerson2)) // This will call the Equals method
//{
   // Console.WriteLine("aPerson and aPerson2 are the same object");
//}
//else
//{
   // Console.WriteLine("aPerson and aPerson2 are different objects");
//}