//Chapter 004, Task 003
//29.06.2025, 17:11

public class CntBetweenNumbers
{
    static void Main()
    {
        int cnt = 0;

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        for(int i = start; i <= end; i++)
        {
            if(i % 5 == 0)
            {
                cnt++;
            }
        }

        Console.WriteLine(cnt);
    }
}