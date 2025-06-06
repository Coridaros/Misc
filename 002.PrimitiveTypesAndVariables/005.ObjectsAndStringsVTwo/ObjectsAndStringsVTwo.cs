//Chapter 002, Task 008
//07.06.2025, 00:18

public class ObjectsAndStrings
{
    static void Main()
    {
        string strOne = "Hello";
        string strTwo = "World";
        object obj = strOne + " " + strTwo;
        string cast = obj.ToString();

        Console.WriteLine(cast);
    }
}