/*Задача 3: Напишите программу, которая на вход принимает 
число и выдаёт, является ли число чётным (делится ли оно 
на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Write("Введите число: ");
string ia = Console.ReadLine();
int a = int.Parse(ia);
if (a%2 == 0)
{
    Console.WriteLine($"Число {a} четное");
}
else
{
    Console.WriteLine($"Число {a} нечетное");
}