namespace Exam4;

internal static class Program
{
    static string IntToRoman(int number)
    {
        int[] values =
        {
            1000, 900, 500, 400,
            100, 90, 50, 40,
            10, 9, 5, 4, 1
        };

        string[] symbols =
        {
            "M", "CM", "D", "CD",
            "C", "XC", "L", "XL",
            "X", "IX", "V", "IV", "I"
        };

        string result = "";

        for (int i = 0; i < values.Length; i++)
        {
            while (number >= values[i])
            {
                result += symbols[i];
                number -= values[i];
            }
        }

        return result;
    }


    static int RomanToInt(string roman)
    {
        int total = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            int current = GetValue(roman[i]);

            if (i + 1 < roman.Length)
            {
                int next = GetValue(roman[i + 1]);

                if (current < next)
                {
                    total -= current;
                }
                else
                {
                    total += current;
                }
            }
            else
            {
                total += current;
            }
        }

        return total;
    }


    static int GetValue(char roman)
    {
        if (roman == 'I') return 1;
        if (roman == 'V') return 5;
        if (roman == 'X') return 10;
        if (roman == 'L') return 50;
        if (roman == 'C') return 100;
        if (roman == 'D') return 500;
        if (roman == 'M') return 1000;

        return 0;
    }


    static void Main()
    {
        Console.WriteLine("1. Int to Roman");
        Console.WriteLine("2. Roman to Int");
        Console.Write("Select: ");

        string choice = Console.ReadLine() ?? "";

        if (choice == "1")
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine() ?? "0");

            string result = IntToRoman(number);

            Console.WriteLine("Roman = " + result);
        }
        else if (choice == "2")
        {
            Console.Write("Enter Roman: ");
            string roman = Console.ReadLine() ?? "";

            roman = roman.ToUpper();

            int result = RomanToInt(roman);

            Console.WriteLine("Number = " + result);
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
