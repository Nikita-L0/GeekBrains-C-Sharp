// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array1 = new int[8];

Random rnd = new Random();

Console.Write("Случайный массив из 8 чисел - ");

for (int i=0; i < 8; i++)
{
    array1[i] = rnd.Next();
    Console.Write (array1[i] + " ");
}