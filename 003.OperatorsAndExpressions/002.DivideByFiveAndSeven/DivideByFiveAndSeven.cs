//Chapter 002, Task 002
//29.06.2025, 13:19

public class DivideByFiveAndSeven
{
    static void Main()
    {
        Console.Write("Въведете число: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivide = number % 5 == 0 && number % 7 == 0;

        if(isDivide)
        {
            Console.WriteLine("Числото се дели едновременно на 5 и 7 без остатък.");
        }
        else
        {
            Console.WriteLine("Числото не се дели на 5 и 7 без остатък.");
        }
    }
}