//Chapter 003, Task 005
//29.06.2025, 13:32

public class TrapeziodArea
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2.0;

        Console.WriteLine($"Area = {area}");
    }
}