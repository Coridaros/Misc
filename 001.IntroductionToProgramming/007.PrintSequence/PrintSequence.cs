//Chapter 001, Task 007
//20.05.2025, 00:28

public class PrintSequence
{
    static void Main()
    {
        for(int i = 2; i <= 102; i++)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine($"-{i}");
            }
        }
    }
}