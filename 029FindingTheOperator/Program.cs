Console.WriteLine("Which number should be the first operant?");
double operant1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Which number should be the second operant?");
double operant2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Which number should be the result?");
double result = double.Parse(Console.ReadLine()!);

double Exponentiation = Math.Pow(operant1, operant2);
double Exponentiation1 = Math.Pow(operant2, operant1);
if (operant1 + operant2 == result)
{
    Console.WriteLine("The operator is +!");
}
else if (operant1 - operant2 == result || operant2 - operant1 == result)
{
    Console.WriteLine("The operator is -!");
}
else if (operant1 * operant2 == result)
{
    Console.WriteLine("The operator is *!");
}
else if (operant1 / operant2 == result || operant2 / operant1 == result)
{
    Console.WriteLine("The operator is /!");
}
else if (operant1 % operant2 == result || operant2 % operant1 == result)
{
    Console.WriteLine("The operator is %!");
}
else if (Exponentiation == result || Exponentiation1 == result)
{
    Console.WriteLine("The operator is Exponentiation!");
}