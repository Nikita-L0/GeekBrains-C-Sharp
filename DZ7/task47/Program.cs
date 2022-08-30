// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.Write("Введите количество строк в массиве - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве - ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] FillArray (int numLine, int numColumns)      
{
    Random value = new Random();
    double[,] matrix = new double[numLine, numColumns];   
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = value.NextDouble();      
        }
    }
    return matrix;    
}

void PrintArray(double[,] matrix)      
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,9:F4}",matrix[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] RandomMatrix = FillArray (m,n);
Console.WriteLine($"Cгенерированнный массив случайных вещественных чисел из {m} строк и {n} столбцов это");
PrintArray (RandomMatrix);