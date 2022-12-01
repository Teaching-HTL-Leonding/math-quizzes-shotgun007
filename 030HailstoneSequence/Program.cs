Console.WriteLine("Enter the first number.");
int number1 = int.Parse(Console.ReadLine()!);

while (number1 < 1)
{
    Console.WriteLine("Enter the first number.");
    number1 = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Enter the second number.");
int number2 = int.Parse(Console.ReadLine()!);

while (number2 < 1)
{
    Console.WriteLine("Enter the second number.");
    number2 = int.Parse(Console.ReadLine()!);
}
int i = 0;
for (;number1 != 1; i++)
{
    if (number1 % 2 == 0)
    {
        number1 = number1 / 2;
    }
    else if (number1 % 2 == 1)
    {
        number1 = (3 * number1) + 1;
    }
}
int j = 0;
for (; number2 != 1; j++)
{
    if (number2 % 2 == 0)
    {
        number2 = number2 / 2;
    }
    else if (number2 % 2 == 1)
    {
        number2 = (3 * number2) + 1;
    }
}
Console.WriteLine();
Console.Write("The length of the Hailstone sequence for number 1 is");
Console.Write(" ");
Console.WriteLine(i);
Console.Write("The length of the Hailstone sequence for number 2 is");
Console.Write(" ");
Console.WriteLine(j);
if (i < j)
{
    Console.WriteLine("The Hailstone sequence for number 1 is shorter than the for number 2!");
}
if (j < i)
{
    Console.WriteLine("The Hailstone sequence for number 2 is shorter than the for number 1!");
}
if (i == j)
{
    Console.WriteLine("The length of both Hailstone sequences is equal!");
}