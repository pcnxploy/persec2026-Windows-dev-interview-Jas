using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{

    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine() ?? "";

        string[] arr = input.Split(',');

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i].Trim();
        }

        string[] result = SortArray(arr);

        Console.WriteLine(string.Join(", ", result));
    }
    static string[] SortArray(string[] input)
    {
        return input
            .OrderBy(x => GetPrefix(x))
            .ThenBy(x => GetNumber(x))
            .ToArray();
    }

    static string GetPrefix(string value)
    {
        Match match = Regex.Match(value, @"^[A-Za-z]+");

        return match.Value;
    }

    static int GetNumber(string value)
    {
        Match match = Regex.Match(value, @"\d+");

        return int.Parse(match.Value);
    }


}