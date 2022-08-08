// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Вариант №1
// 
// Console.Write("Введите число - ");
// int N = Convert.ToInt32(Console.ReadLine());
// 
// int count = 2;
// 
// Console.Write("Четные числа от 1 до " + N + " это - ");
// 
// while (count <= N)
    // {
        // Console.Write(" " + count);
        // count = count + 2;
    // }
    
// Вариант №2

Console.Write("Введите число - ");

int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Четные числа от 1 до " + N + " это - ");

for (int count = 1; count <= N; count++)
{
    if (count % 2 ==0) Console.Write(" " + count);
    
}