namespace Offical_Assement_2;

using System;
using System.Collections.Generic;

class Program







                    {

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my second assessment!");

        // 1. CreateStringArray
        Console.WriteLine("\n--- CreateStringArray ---");
        Console.Write("Enter first string: ");
        string first = Console.ReadLine();
        Console.Write("Enter second string: ");
        string second = Console.ReadLine();
        Console.Write("Enter third string: ");
        string third = Console.ReadLine();
        string[] stringArray = CreateStringArray(first, second, third);
        Console.WriteLine("Your array:");
        foreach (string str in stringArray)
        {
            Console.WriteLine(str);
            }

        
        
        
        // 2. SumArray
           Console.WriteLine("\n--- SumArray ---");
        int[] numbers = new int[3];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int total = SumArray(numbers);
        
        
          Console.WriteLine($"Sum of numbers: {total}");

       
          
          // 3. RemoveNum
        Console.WriteLine("\n--- RemoveNum ---");
       
        
        List<int> numberList = new List<int>() { 1, 2, 3, 4, 5 };
        Console.WriteLine("Current list: 1, 2, 3, 4, 5");
        Console.Write("Enter a number to remove from the list: ");
        int numToRemove = int.Parse(Console.ReadLine());
        RemoveNum(numberList, numToRemove);
        Console.WriteLine("list Updated!:");
        foreach (int n in numberList)
        
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        // 4. AddToList
        Console.WriteLine("\n--- AddToList ---");
        Console.Write("Enter a fruit to add: ");
        string fruit = Console.ReadLine();
        List<string> fruitList = AddToList(fruit);
        Console.WriteLine("Updated fruit list:");
        foreach (string f in fruitList)
        {
            Console.WriteLine(f);
        }

        // 5. TryMe
        
        Console.WriteLine("\n--- TryMe ---");
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        int result = TryMe(firstNum, secondNum);
        Console.WriteLine($"Result of division (or 9 if error): {result}");

        Console.WriteLine("\nThank you for using my assessment!");
        
    }

    public static string[] CreateStringArray(string str1, string str2, string str3)
    {
        string[] result = new string[3];
        result[0] = str1;
        result[1] = str2;
        result[2] = str3;
        return result;
    }

    public static int SumArray(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    public static void RemoveNum(List<int> numbers, int num)
    {
        // Grand Circus / Subsidiary of Dexian
        if (numbers.Contains(num))
        {
            numbers.Remove(num);
        }
    }

    public static List<string> AddToList(string item)
    {
        List<string> list = new List<string>();
        list.Add("grapes");
        list.Add("oranges");
        list.Add(item);
        return list;
    }

    public static int TryMe(int num1, int num2)
    {
        try
        {
            int result = num1 / num2;
            return result;
        }
        catch (DivideByZeroException)
        {
            return 9;
        }
    }
}
