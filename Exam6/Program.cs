namespace Exam6;

internal static class Program
{
    static int[] Tribonacci(int[] start, int count)
    {
        List<int> result = new List<int>();

        if (count == 0)
        {
            return result.ToArray();
        }

        for (int i = 0; i < start.Length && result.Count < count; i++)
        {
            result.Add(start[i]);
        }

        while (result.Count < count)
        {
            int sum = 0;

            for (int i = result.Count - 1;
                 i >= 0 && i >= result.Count - 3;
                 i--)
            {
                sum += result[i];
            }

            result.Add(sum);
        }

        return result.ToArray();
    }

    static void Main()
    {
        Console.Write("Start values (คั่นด้วย comma): ");
        string input = Console.ReadLine() ?? "";

        string[] parts;

        if (input.Trim() == "")
        {
            parts = new string[0];
        }
        else
        {
            parts = input.Split(',');
        }

        int[] start = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            start[i] = int.Parse(parts[i].Trim());
        }

        Console.Write("Count: ");
        int count = int.Parse(Console.ReadLine() ?? "0");

        int[] result = Tribonacci(start, count);

        Console.Write("Result: [");

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);

            if (i < result.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("]");
    }
}
