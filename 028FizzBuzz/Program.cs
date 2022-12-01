Console.WriteLine("How high should the program count?");
int maxNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine("The multiples of the number you enter will be substituted with (Fizz)!");
int fizz = int.Parse(Console.ReadLine()!);

Console.WriteLine("The multiples of the number you enter will be substituted with (Buzz)!");
int buzz = int.Parse(Console.ReadLine()!);

Console.WriteLine();

for (int i = 1; i <= maxNumber; i++)
{
    if (i % fizz == 0 && i % buzz == 0)
    {
        Console.Write("FizzBuzz");
    }
    else if (i % fizz == 0 && i % buzz != 0)
    {
        Console.Write("Fizz");
    }
    else if (i % fizz != 0 && i % buzz == 0)
    {
        Console.Write("Buzz");
    }
    else
    {
        Console.Write(i);
    }
    Console.Write(" ");
}
