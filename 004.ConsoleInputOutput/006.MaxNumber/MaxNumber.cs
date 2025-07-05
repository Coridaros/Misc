//Chapter 004, Task 006
//29.06.2025, 17:21

public class MaxNumber
{
    static void Main()
    {
        int max = int.MinValue;

        for(int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());

            max = Math.Max(max, number);
        }

        Console.WriteLine(max);
    }
}