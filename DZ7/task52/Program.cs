// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

int[,] RandomMatrix = FillArray (m, n, Min, Max);
Console.WriteLine($"Cгенерированнный массив случайных чисел из {m} строк и {n} столбцов со значениями от {Min} до {Max} это");
PrintArray (RandomMatrix);
Console.Write($"Cреднее арифметическое элементов в каждом столбце массива равно - ");

for (int j = 0; j < RandomMatrix.GetLength(1); j++)
{
    double SumValue = 0;
    for (int i = 0; i < RandomMatrix.GetLength(0); i++)
        {
            SumValue += RandomMatrix[i,j];
        }
    SumValue = SumValue/RandomMatrix.GetLength(1);
    Console.Write(SumValue.ToString("F" + 3) + " | ");            
}