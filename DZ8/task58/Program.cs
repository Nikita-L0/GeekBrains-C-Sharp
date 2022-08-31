//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] CreateMatrix ()      
{
    
    int[,] matrix = new int[2, 2];   
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            Console.Write($"Введите элемент на позиции ({i},{j}) ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());      
        }
    }
    return matrix;    
}

void PrintMatrix (int[,] matrix)      
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

int[,] ProductMatrix (int[,]matrix1, int[,] matrix2)
{
    int[,] Product = new int [matrix1.GetLength(0),matrix2.GetLength(1)];
    if (matrix1.GetLength(0) != matrix2.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
    }
    else
    {
    for (int i1=0; i1< matrix1.GetLength(0); i1++)
    {
        for (int j2=0; j2 < matrix2.GetLength(1); j2++)
        {
            for (int i2=0; i2< matrix2.GetLength(0); i2++)            
            {
                Product[i1,j2] += matrix1 [i1,i2] * matrix2 [i2,j2];
            }
        }
    }
    }
    return Product;
}

Console.WriteLine("Введите данные для первой матрицы:");
int [,] matrix1 = CreateMatrix();
Console.WriteLine("Введите данные для второй матрицы:");
int [,] matrix2 = CreateMatrix();
Console.WriteLine("Введнные значения для 2 созданных матриц 2х2 это:");
PrintMatrix (matrix1);
Console.WriteLine();
PrintMatrix (matrix2);
Console.WriteLine("Произведение этих матриц равно:");
int[,] ResultMatrix = ProductMatrix (matrix1, matrix2);
PrintMatrix (ResultMatrix);