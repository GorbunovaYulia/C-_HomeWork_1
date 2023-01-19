//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int numberС = int.Parse(Console.ReadLine()!);
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
else 
{
    max = numberA;
}
if (max < numberС)
{
    max = numberС;
}
else
{
    Console.WriteLine($"max={max}");
}
Console.WriteLine($"max={max}");