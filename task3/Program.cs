// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

using static System.Console;

WriteLine("Введите число ");
int num = Convert.ToInt32(ReadLine());

if (num % 2 == 0)
{
    WriteLine($"{num} -> чётное");
}
if (num % 2 != 0)
{
     WriteLine($"{num} -> нечётное");
}