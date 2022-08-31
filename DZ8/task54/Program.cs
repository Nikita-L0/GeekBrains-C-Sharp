// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;

Console.Clear();
Console.Write("Введите количество строк в массиве - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве - ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента в массиве - ");
int Min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента в массиве - ");
int Max = Convert.ToInt32(Console.ReadLine());

int[,] FillArray (int numLine, int numColumns, int MinValue, int MaxValue)      
{
    Random value = new Random();
    int[,] matrix = new int[numLine, numColumns];   
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = value.Next(MinValue,MaxValue+1);      
        }
    }
    return matrix;    
}

void PrintArray(int[,] matrix)      
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int [,] SortArray (int[,] matrix)
{
    int[] TempArray = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            TempArray[j] = matrix [i,j];
        }
        Array.Sort(TempArray);
        Array.Reverse(TempArray);
        
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            matrix[i,j] = TempArray[j];
        }
    }
    return matrix;
}

int[,] RandomMatrix = FillArray (m, n, Min, Max);
Console.WriteLine($"Cгенерированнный массив случайных чисел из {m} строк и {n} столбцов со значениями от {Min} до {Max} это");
PrintArray (RandomMatrix);
Console.WriteLine($"Отсортированный по строкам массив - ");
PrintArray (SortArray(RandomMatrix));

