﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

Console.WriteLine("Введите число-a: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число-b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
if (numberA < numberB)
{
    Console.WriteLine($"max = {numberB}");
}