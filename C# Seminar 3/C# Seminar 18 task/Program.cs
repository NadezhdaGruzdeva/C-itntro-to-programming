﻿//Напишите программу, которая по задонномму номеру четверти, показывает диапозон
//возможных координат

Console.WriteLine("Введите номер четверти");
int n = int.Parse(Console.ReadLine());
if (n == 1)
{
    Console.WriteLine("X>0, Y>0");
}
else
if (n == 2)
{
    Console.WriteLine("X<0, Y>0");
}
else
if (n == 3)
{
    Console.WriteLine("X<0, Y<0");
}
else
if (n == 4)
{
    Console.WriteLine("X>0, Y<0");
}
else
{
    Console.WriteLine("Вы ввели некорректное значение");
}



