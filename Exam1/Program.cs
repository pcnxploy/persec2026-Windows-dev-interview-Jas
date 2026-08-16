namespace Exam1;

internal static class Program
{
    private static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine() ?? "";

        Console.Write("Result: " + IsValid(input));
    }

    static bool IsValid(string input)
    {
        string oldInput;

        do
        {
            oldInput = input;

            input = input.Replace("()", "")
                         .Replace("[]", "")
                         .Replace("{}", "");

        } while (input != oldInput);

        return input.Length == 0;
    }
}
