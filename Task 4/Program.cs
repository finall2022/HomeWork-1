﻿/*Задача 4: Напишите программу, которая на вход принимает 
число (N), а на выходе показывает все чётные числа 
от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.Write("Введите число N: ");
string iN = Console.ReadLine();
int N = int.Parse(iN);
int i = 1;
Console.Write($"Четные числа от 1 до {N}: ");
while (i <= N)
{
    if (i % 2 == 0)
    {
       Console.Write(i + ", ");
    }
    i = ++i;
}
