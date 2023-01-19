//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int first_number=2;
int last_number=0;
int div=number%2;
if (div==0)
{
    last_number=number;
}
else
{
    last_number=number-1;
}
while(first_number<=last_number)
{
    Console.Write(first_number+" ");
    first_number=first_number+2;
}