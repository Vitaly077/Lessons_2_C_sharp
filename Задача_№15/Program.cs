﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("введите цифру дня недели");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 0 && x < 6)
{
Console.Write("Нет");
}

if (x > 5 && x < 8)
{
Console.Write("Да");
}

if (x < 1 || x > 7)
{
Console.Write("Ввели не корректный день недели");
}
