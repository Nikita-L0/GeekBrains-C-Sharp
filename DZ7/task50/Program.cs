// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchArray (int [,] matrix, int SearchValue)
{
    bool FoundValue = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == SearchValue) 
            {
                Console.WriteLine($"Данное число найдено в {i+1} строке и {j+1} столбце в данном массиве");
                FoundValue = true;
            }
            
        }
    }
    if (FoundValue == false) Console.WriteLine("Данное значение в массиве отсутствует");
}

int[,] RandomMatrix = FillArray (m, n, Min, Max);

Console.WriteLine($"Cгенерированнный массив случайных чисел из {m} строк и {n} столбцов со значениями от {Min} до {Max} это");

PrintArray (RandomMatrix);

Console.Write("Введите число, которое хотите найти - ");

int SearchValue = Convert.ToInt32(Console.ReadLine());

SearchArray(RandomMatrix, SearchValue);