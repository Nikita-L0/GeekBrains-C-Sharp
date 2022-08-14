﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число - ");

int N = Convert.ToInt32(Console.ReadLine());

if (N >= 10000 && N <= 99999 )
{
    if ( (N % 10 == N / 10000) && (N % 100 / 10 == N / 1000 % 10) ) 
    {
        Console.Write("Введенное число - " + N + " это паллиндром");
    }
    else
    {
        Console.Write("Введенное число - " + N + " это не паллиндром");
    }
}
else
{
    Console.Write("Введенное число - " + N + " не является пятизначным");
}