// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array1 = new int[size];
    for (int i = 0; i < size; i++)
    {
        array1[i] = new Random().Next(min, max + 1);
    }
    return array1;
}

Console.Write("Введите размер желаемого массива - ");

int size = Convert.ToInt32(Console.ReadLine());

int[] array2 = CreateRandomArray(size, 100, 999);

int count = 0;

Console.Write("Сгенерированный массив из " + size + " трехзначных чисел - ");

for (int i = 0; i < size; i++)
{
    Console.Write(array2[i] +" ");
    if (array2[i] % 2 == 0) count += 1;
}

Console.WriteLine("");

Console.Write ("Количество четных элементов в массиве равно " + count);
