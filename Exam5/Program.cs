namespace Exam5;

internal static class Program
{
     static int SortNumberDescending(int number)
    {
        char[] digits = number.ToString().ToCharArray();

        // sort จากมากไปน้อย
        for (int i = 0; i < digits.Length - 1; i++)
        {
            for (int j = i + 1; j < digits.Length; j++)
            {
                if (digits[i] < digits[j])
                {
                    char temp = digits[i];
                    digits[i] = digits[j];
                    digits[j] = temp;
                }
            }
        }

        string result = new string(digits);

        return int.Parse(result);
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine() ?? "0");

        int result = SortNumberDescending(number);

        Console.WriteLine("Result = " + result);
    }
}
