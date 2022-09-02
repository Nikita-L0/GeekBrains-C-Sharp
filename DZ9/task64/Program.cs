// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
void Sum (int numberM, int numberN)
{
    Console.Write($"Натуральные числа из диапазона от {numberM} до {numberN} это ");
    for (int i=numberM; i <= numberN; i++) 
    {
        Console.Write($"{i} "); 
    }
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Sum(M, N);

