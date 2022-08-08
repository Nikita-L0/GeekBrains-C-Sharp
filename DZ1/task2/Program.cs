// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число - ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a == b ) 
{
    Console.WriteLine("Первое число " + a + " равно второму числу " + b);
}
else 
{
    if (a > b)
    {
        Console.WriteLine("Первое число " + a + " больше чем второе число " + b);
    }
    else
    {
        Console.WriteLine("Первое число " + a + " меньше чем второе число " + b);
    }
}