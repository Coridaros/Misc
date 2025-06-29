//Chapter 003, Task 004
//29.06.2025, 13:28

public class ChekDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isThree = (number & 8) != 0;

        if(isThree)
        {
            Console.WriteLine(1);
        }
        else
        {

            Console.WriteLine(0);
        }
    }
}