//Chapter 002, Task 013
//07.06.2025, 00:23

public class SwapValues
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("Първоначалните стойности");
        Console.WriteLine(first);
        Console.WriteLine(second);

        int temp = first;
        first = second;
        second = temp;

        Console.WriteLine("След размяната");
        Console.WriteLine(first);
        Console.WriteLine(second);
    }
}