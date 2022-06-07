//Задача 2: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите число а: ");
string ia = Console.ReadLine();
int a = int.Parse(ia);
Console.Write("Введите число b: ");
string ib = Console.ReadLine();
int b = int.Parse(ib);
Console.Write("Введите число c: ");
string ic = Console.ReadLine();
int c = int.Parse(ic);
int max = a;
if(max < b)
{
    max = b;
}
if(max < c)
{
    max = c;
}
Console.Write($"Максимальное число {max}");