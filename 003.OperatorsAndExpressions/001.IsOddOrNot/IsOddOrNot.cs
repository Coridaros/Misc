//Chapter 003, Task 001
//29.06.2025, 13:10

public class IsOddOrNot
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isOdd = number % 2 != 0;

        if(isOdd)
        {
            Console.WriteLine($"Числото {number} е нечетно.");
        }
        else
        {
            Console.WriteLine($"Числото {number} е четно.");
        }
    }
}