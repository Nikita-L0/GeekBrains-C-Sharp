﻿// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
void FindMinSumRow  (int[,] matrix)
{
    int MinSumRowNumber = 0;
    int MinSumRow = matrix [0,0];
    int [] MinSum = new int[matrix.GetLength(0)];
    for (int j = 1; j< matrix.GetLength(1); j++)
    {
        MinSumRow += matrix[0,j];
    }
    MinSum[0] = MinSumRow;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int CurrentRowSum = matrix[i,0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            CurrentRowSum = CurrentRowSum + matrix [i,j];
        }
    MinSum[i] = CurrentRowSum;
    if (CurrentRowSum < MinSumRow) 
    {
        MinSumRow = CurrentRowSum;
        MinSumRowNumber = i;
    }
    }
Console.Write($"В данном массиве наименьшая сумма значений элементов равна {MinSumRow} и получается в строке № ");
    for (int i =0; i < matrix.GetLength(0); i++)
    {
        if (MinSum[i] == MinSumRow) Console.Write($"{i+1} ");
    }
}

int[,] RandomMatrix = FillArray (m, n, Min, Max);
Console.WriteLine($"Cгенерированнный массив случайных чисел из {m} строк и {n} столбцов со значениями от {Min} до {Max} это");
PrintArray (RandomMatrix);
FindMinSumRow (RandomMatrix);
