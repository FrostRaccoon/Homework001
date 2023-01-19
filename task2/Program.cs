//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
using static System.Console;

WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(ReadLine());

if (num1 > num2)
{
    WriteLine($"max -> {num1}, min -> {num2}");
}
else
{
    WriteLine($"max -> {num2}, min -> {num1}");
}