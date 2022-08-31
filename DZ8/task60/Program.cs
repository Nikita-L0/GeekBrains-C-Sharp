// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] Create3DMatrix (int Xsize, int Ysize, int Zsize, int MinValue, int MaxValue)      
{
    int[,,] matrix = new int[Xsize,Ysize,Zsize];
    int size = MaxValue-MinValue+1;
    int[] RangeArray = new int [size];
    for (int count = 0; count < size; count++)
    {
        RangeArray[count] = MinValue;
        MinValue++;
    }
    Random value = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k=0; k<matrix.GetLength(2); k++)
            {
                int Position = value.Next(0,size);
                do 
                {
                    Position = value.Next(0,size);
                } 
                while (RangeArray[Position] == 0);
                matrix[i,j,k] = RangeArray[Position];
                RangeArray[Position] = 0;
            }
        }
    }
    return matrix;    
}

void PrintMatrix (int[,,] matrix)      
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k=0; k< matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы по оси X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер матрицы по оси Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер матрицы по оси Z: ");
int Z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix1 = Create3DMatrix(X,Y,Z, 10, 99);
Console.WriteLine($"Сгенерированная матрица из неповторяющихся двухзначных чисел размерностью {X}x{Y}x{Z} это:");
PrintMatrix (matrix1);
