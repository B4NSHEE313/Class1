namespace Day_1_student_class_example;

class Program
{

    // This is an application program
    // it instantiates and uses objects to perform processing



    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<int> scores = new List<int>();
        scores.Add(90);
        scores.Add(85);
        scores.Add(85);

        Student aStudent = new Student("John Doe", scores);
    }
}