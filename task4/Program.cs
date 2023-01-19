// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

using static System.Console;

WriteLine("Введите число ");
int num = Convert.ToInt32(ReadLine());

int i = 1;
bool not = true;

WriteLine($"Чётные числа от 1 до {num}");
while (i <= num)
{
    if (i % 2 !=1)
    {
        Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}
