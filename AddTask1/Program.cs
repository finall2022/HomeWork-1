/* *. Напишите программу вычисления модуля числа.
    2 -> 2
    -3 -> 3
    -7 -> 7 */
Console.Write("Программа для определения модуля числа");
Console.Write("Введите число: ");
string s = Console.ReadLine();
int n = int.Parse(s);
int m = 0;
if (n > 0)
{
    Console.Write($"Модуль числа {n} равен {n}");
}
else
{
    m = n * -1;
    Console.Write($"Модуль числа {n} равен {m}");
}