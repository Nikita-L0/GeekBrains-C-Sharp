// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
Console.Write("Введите минимальное значение элемента массива - ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива - ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array2 = CreateRandomArray(size, min, max);

int result = 0;

Console.Write("Сгенерированный массив из " + size + " элементов в диападоне от " + min + " и до " + max + " - ");

for (int i = 0; i < size; i++)
{
    Console.Write(array2[i] + " ");
    if ((i+1) % 2 == 0) result += array2[i];
}

Console.WriteLine("");

Console.Write ("Сумма элементов, стоящих на нечётных позициях равна - " + result);