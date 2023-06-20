//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число ");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;

if (Length == 3)
{
    int result = (Value / 10) % 10;
    Console.Write($"Вторая цифра - {result}");
}
else
{
    Console.Write("Это не трехзначное число ");
}