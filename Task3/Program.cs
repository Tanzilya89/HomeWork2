﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

Console.Write("Введите день недели");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <= 7)
{
    if (Day >= 6)
    {
        Console.Write("Выходной");
    }
    else
    {
        Console.Write("Будний день");
    }
}
else
{
    Console.Write("Введите день от 1 до 7");
}
