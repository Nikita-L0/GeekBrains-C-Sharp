// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число N - ");

int N = Convert.ToInt32(Console.ReadLine());

Console.Write ("Кубические значения чисел от 1 до " + N + " это ");

for (int i = 1; i <= N; i++)
{
    Console.Write (Math.Pow(i,3) + " ");
}