//Chapter 004, Task 004
//29.06.2025, 17:14

public class GreaterNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(firstNumber, secondNumber));
    }
}