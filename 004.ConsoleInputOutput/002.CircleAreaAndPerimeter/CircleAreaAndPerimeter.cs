//Chapter 004, Task 002
//29.06.2025, 17:08

public class CircleAreaAndPerimeter
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}