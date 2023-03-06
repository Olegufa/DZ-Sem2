// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Ведите день недели: ");
int namber = Convert.ToInt32(Console.ReadLine());;

if( namber == 1 )
{
    Console.Write("Нет");
}
else if( namber == 2 )
{
    Console.Write("Нет");
}
else if( namber == 3 )
{
    Console.Write("Нет");
}
else if( namber == 4 )
{
    Console.Write("Нет");
}
else if( namber == 5 )
{
    Console.Write("Нет");
}
else if( namber == 6 )
{
    Console.Write("Да");
}
else if( namber == 7 )
{
    Console.Write("Да");
}
else
{
    Console.Write("Такого дня недели нет");
}