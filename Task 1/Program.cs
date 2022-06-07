// Задача 1: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 ->  max = 7, min = 5
//a = -9 b = -3 -> max = -3, min = -9

Console.Write("Введите число а: ");
string ia = Console.ReadLine();
int a = int.Parse(ia);
Console.Write("Введите число b: ");
string ib = Console.ReadLine();
int b = int.Parse(ib);
if (a > b)
{
    Console.WriteLine($"Максимальное число a = {a}");
    Console.WriteLine($"Минимальное число b = {b}");
}
else
{
    Console.WriteLine($"Минимальное число a = {a}");
    Console.WriteLine($"Максимальное число b = {b}");
}