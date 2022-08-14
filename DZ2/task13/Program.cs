// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число - ");

double N = Convert.ToDouble(Console.ReadLine());

if (Math.Floor(Math.Log10(N)) > 1) 
{

    double digits_num = Math.Floor(Math.Log10(N) + 1);
    Console.WriteLine ("Количество цифр во введенном числе - " + digits_num);
    if (digits_num > 3) 
    {
        Console.Write ("Третья цифра во введенном числе - " + Math.Floor(N % Math.Pow(10, (digits_num - 2)) / Math.Pow (10, (digits_num - 3))));
    }
    else
    {
        Console. Write ("Третья цифра во введенном числе - " + N % 10);
    }

    
}
else 
{
    Console.Write("Вы ввели не трехзначное число, поэтому третьей цифры в нем нет");
}
