namespace Staw_wuz;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // You can add simple test cases here if needed
    }

    public static int AddStarWarsCharacters(string[] characters)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (characters[i] == "Yoda")
            {
                return i;
            }
        }
        return -1;
    }

    public static string DeathStarCombat(Dictionary<string, int> characters)
    {
        string bestJedi = "";
        int highestAttack = int.MinValue;

        foreach (var character in characters)
        {
            if (character.Value > highestAttack)
            {
                highestAttack = character.Value;
                bestJedi = character.Key;
            }
        }

        return bestJedi;
    }

    public static List<string> ConvertPlanets(string[] planets)
    {
        List<string> reversedPlanets = new List<string>();

        for (int i = planets.Length - 1; i >= 0; i--)
        {
            reversedPlanets.Add(planets[i]);
        }

        return reversedPlanets;
    }

    public static double AverageDroids(List<int> droids)
    {
        List<int> evenDroids = new List<int>();

        
        
        foreach (int droid in droids)
        {
            if (droid % 2 == 0)
            {
                evenDroids.Add(droid);
            }
        }

        if (evenDroids.Count == 0)
        {
            return 0;
        }

        double sum = 0;
        foreach (int droid in evenDroids)
        {
            sum += droid;
        }

        return sum / evenDroids.Count;
    }

    public static string TryToCatchDarthVader(string input)
    {
        try
        {
            int result = int.Parse(input);
            return "Vader Was Captured!";
        }
        catch (FormatException)
        {
            return "Vader Got Away!";
        }
    }
}
