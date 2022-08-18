// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] CreateRandomArray(int size, double min, double max)
{
    double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)
{
    var random = new Random();
    var rDouble = random.NextDouble();
    var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
    return rRangeDouble;
}
    double[] array1 = new double[size];
    for (int i = 0; i < size; i++)
    {
        array1[i] = GetPseudoDoubleWithinRange(min, max);
    }
    return array1;
}

Console.Write("Введите размер желаемого массива - ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива (вещественное) - ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива (вещественное) - ");
double max = Convert.ToDouble(Console.ReadLine());

double[] array2 = CreateRandomArray(size, min, max);

double min_array = array2[0];
double max_array = array2[0];

Console.Write("Сгенерированный массив из " + size + " элементов в диападоне от " + min + " до " + max + " - ");

for (int i = 0; i < size; i++)
{
    Console.Write(array2[i] + " ");
    if (min_array > array2[i]) min_array = array2[i];  
    if (max_array < array2[i]) max_array = array2[i];
}
Console.WriteLine("");
Console.WriteLine("минимальный элемент - " + min_array);
Console.WriteLine("максимальный элемент - " + max_array);
Console.WriteLine ("Разница между максимальным и минимальным элементом массива равна - " + (max_array - min_array));