
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int A = 32679;

if(A > 0 && A < 100)
{
    Console.WriteLine ("третьей цифры нет ");
}
else if (A > 100 && A < 1000)
{
    A = A%10;
    Console.WriteLine ($"{A}");
}
else if (A > 1000 && A < 10000)
{
    A = A/10;
    A = A%10;
    Console.WriteLine ($"{A}");
}
else if (A > 10000 && A < 100000)
{
    A = A/100;
    A = A%10;
    Console.WriteLine ($"{A}");
}