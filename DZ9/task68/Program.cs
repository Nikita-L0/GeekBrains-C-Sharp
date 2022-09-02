// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman (int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n ==0) return Akkerman (m-1, 1);
    else if (m >0 && n>0) return Akkerman (m-1, Akkerman(m,n-1));
    return Akkerman(m,n);
}
Console.WriteLine($"Значение функции Акермана для чисел {M} и {N}: A({M},{N}) = {Akkerman(M,N)}");