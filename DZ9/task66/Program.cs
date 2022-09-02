// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N..

Console.Clear();
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if ( M < N)
{
    void GapNumberSum (int numberM, int numberN, int sum)
    {
        if (numberM > numberN) 
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
            return;
        }
        sum = sum + (numberM++);
        GapNumberSum(numberM, numberN, sum);
    }
    GapNumberSum(M, N, 0);
}
else
{
    Console.WriteLine ($"Ошибка, {M} больше или равно {N}");
}
