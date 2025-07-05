//Chapter 004, Task 005
//29.06.2025, 17:16

public class ValidNumberAndSum
{
    static void Main()
    {
        int sum = 0;
        //bool isValid = false;
        int number;

        for(int i = 0; i < 5; i++)
        {
            if(int.TryParse(Console.ReadLine(), out number) != true)
            {
                i--;
                Console.WriteLine("Невалидно число!");
            }

            sum += number;
        }

        Console.WriteLine(sum);
    }
}