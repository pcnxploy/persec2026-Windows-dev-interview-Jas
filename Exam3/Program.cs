using System;
using System.Collections.Generic;

class Program
{
    static string[] Autocomplete(string search, string[] items, int maxResult)
    {
        List<string> startList = new List<string>();
        List<string> middleList = new List<string>();
        List<string> endList = new List<string>();

        foreach (string item in items)
        {
           
            int index = item.IndexOf(search, StringComparison.OrdinalIgnoreCase);

           
            if (index == -1)
                continue;
            if (item.StartsWith(search, StringComparison.OrdinalIgnoreCase))
            {
                startList.Add(item);
            }
            else if (item.EndsWith(search, StringComparison.OrdinalIgnoreCase))
            {
                endList.Add(item);
            }
            else
            {
                middleList.Add(item);
            }
        }

        List<string> result = new List<string>();

        AddResult(result, startList, maxResult);
        AddResult(result, middleList, maxResult);
        AddResult(result, endList, maxResult);

        return result.ToArray();
    }

    static void AddResult(
        List<string> result,
        List<string> items,
        int maxResult)
    {
        foreach (string item in items)
        {
            if (result.Count >= maxResult)
                break;

            result.Add(item);
        }
    }

    static void Main()
    {
        Console.Write("Search: ");
        string search = Console.ReadLine() ?? "";

        Console.Write("Items (คั่นด้วย comma): ");
        string input = Console.ReadLine() ?? "";

        string[] items = input.Split(',');

        // ตัดช่องว่าง
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = items[i].Trim();
        }

        Console.Write("Max Result: ");
        int maxResult = int.Parse(Console.ReadLine() ?? "0");

        string[] result = Autocomplete(search, items, maxResult);

        Console.WriteLine("Result:");

        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }
}