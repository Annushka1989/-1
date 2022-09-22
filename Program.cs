/*
Напишите программу, которая на вход принимает 
2 числа и проверяет евяляется ли первое 
число квадратом второго
*/



Console.Write("Введите число А:");
int numberA = Convert.ToInt32(Console.ReadLine( ));

Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine( ));

int square = numberB * numberB;

if (square == numberA)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}