// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число - ");

int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Числа от " + -N + " до "  + N + " это");

for (int count = -N; count <= N; count++)
{
    Console.Write(" " + count);
    
}
