// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите коэффициент k1 - ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b1 - ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k2 - ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b2 - ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) Console.WriteLine ("Прямые " + k1 + "*x + " + b1 + " и " + k2 + "*x + " + b2 + "параллельны");
else
{
    int x = (b2 - b1) / (k1-k2);
    int y = k1*x + b1;
    Console.WriteLine ("Прямые " + k1 + "*x + " + b1 + " и " + k2 + "*x + " + b2 + $" пересекаются в координатах [{x};{y}]");
}