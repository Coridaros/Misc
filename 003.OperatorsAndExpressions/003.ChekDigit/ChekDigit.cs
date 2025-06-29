//Chapter 003, Task 003
//29.06.2025, 13:24

public class ChekDigit
{
    static void Main()
    {
        Console.Write("Number = ");

        int number = int.Parse(Console.ReadLine());

        int d = number / 100;
        int digit = number % 10;

        if (digit == 7)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}