// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

Console.Write("Введите число N - ");
int N = Convert.ToInt32(Console.ReadLine());

double[] Fibonacci = new double[N];

Fibonacci[0] = 0;
Console.WriteLine( 1 + " число Фибоначчи равно - " + Fibonacci[0]);
Fibonacci[1] = 1;
Console.WriteLine( 2 + " число Фибоначчи равно - " + Fibonacci[1]);

for (int i = 2; i < N; i++)
{
    Fibonacci[i] = Fibonacci [i-1] + Fibonacci [i-2];
    Console.WriteLine( i+1 + " число Фибоначчи равно - " + Fibonacci[i]);
}

