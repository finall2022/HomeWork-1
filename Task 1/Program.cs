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
if(a > b)
{
    Console.WriteLine($"Число a = {a} больше числа b = {b}");
}
else
{
    Console.WriteLine($"Число b = {b} больше числа a = {a}");
}