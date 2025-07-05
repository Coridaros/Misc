//Chapter 004, Task 001
//29.06.2025, 17:06

public class SumThreeNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine(sum);
    }
}