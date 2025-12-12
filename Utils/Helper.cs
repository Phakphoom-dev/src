public static class Helper
{
    public static int GetNumberInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result) && result >= min && result <= max)
            {
                return result;
            }

            Console.WriteLine($"Please enter a number between {min} and {max}!");
        }
    }

    public static int CalculateCanonDamage(int round)
    {
        if (round % 3 == 0 && round % 5 == 0)
        {
            return 10;
        }
        else if (round % 3 == 0 || round % 5 == 0)
        {
            return 3;
        }
        else
        {
            return 1;
        }
    }
}