// Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] Fillarray(int row, int col)
{
    int[,] matrix = new int [row,col];
    int PosX=0;
    int PosY=0;
    int NewPosX=0;
    int NewPosY=0;
    int Count = 0;
    int NewCount = 0;
    void MoveRight (int PosX, int PosY, int count, out int NewPosX, out int NewPosY, out int NewCount)
        {
            int j= PosY;
            do
            {
                
                matrix[PosX,j] = count;
                j++;
                count++;
            } 
            while (j < matrix.GetLength(1) && matrix[PosX,j] == 0);
            NewPosX = PosX;
            NewPosY = j-1;
            NewCount = count-1;
        }
    void MoveDown (int PosX, int PosY, int count, out int NewPosX, out int NewPosY, out int NewCount)
        {
            int i= PosX;
            do
            {
                
                matrix[i,PosY] = count;
                i++;
                count++;
            } 
            while (i < matrix.GetLength(0) && matrix[i,PosY] == 0);
            NewPosX = i-1;
            NewPosY = PosY;
            NewCount = count-1;
        }          
    void MoveLeft (int PosX, int PosY, int count, out int NewPosX, out int NewPosY, out int NewCount)
        {
            int j= PosY;
            do
            {
                
                matrix[PosX,j] = count;
                j--;
                count++;
            } 
            while (j >=0 && matrix[PosX,j] == 0);
            NewPosX = PosX;
            NewPosY = j+1;
            NewCount = count-1;
        }
    void MoveUp (int PosX, int PosY, int count, out int NewPosX, out int NewPosY, out int NewCount)
        {
            int i= PosX;
            do
            {
                
                matrix[i,PosY] = count;
                i--;
                count++;
            } 
            while (i >=0 && matrix[i,PosY] == 0);
            NewPosX = i+1;
            NewPosY = PosY;
            NewCount = count-1;
        }            
    MoveRight (0,0,1, out PosX, out PosY, out Count);
    MoveDown (PosX, PosY, Count, out NewPosX, out NewPosY, out NewCount);
    MoveLeft (NewPosX, NewPosY, NewCount, out PosX, out PosY, out Count);
    MoveUp (PosX, PosY, Count, out NewPosX, out NewPosY, out NewCount);
// Тут можно, наверное, было сделать какую-нибудь функцию и придумать рекурсию, но меня на это уже не хватило :) 
    MoveRight (NewPosX, NewPosY, NewCount, out PosX, out PosY, out Count);
    MoveDown (PosX, PosY, Count, out NewPosX, out NewPosY, out NewCount);
    MoveLeft (NewPosX, NewPosY, NewCount, out PosX, out PosY, out Count);
return matrix;
}


void PrintArray (int[,] matrix)      
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10) Console.Write($"{0:D1}{matrix[i, j]}\t");
            else
            {
            Console.Write($"{matrix[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы по оси X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер матрицы по оси Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = Fillarray(X,Y);
PrintArray(matrix1);