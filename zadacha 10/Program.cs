// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Ведите трех значное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int a = x/10;
int b = a%10;

if (x > 99 && x <1000)
{
    Console.WriteLine($"Ваше число: {b} ");
}
else
{
    Console.WriteLine("Вы вели не трехзначное число ");
}