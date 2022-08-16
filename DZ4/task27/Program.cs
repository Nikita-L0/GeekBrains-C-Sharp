// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число - ");

double N = Convert.ToDouble(Console.ReadLine());

double digits_num = Math.Floor(Math.Log10(N) + 1);
int chislo = Convert.ToInt32(N);
int result = 0;
for (int i=1; i <= digits_num; i++)
{
    result = result + chislo % 10;
    chislo = chislo / 10;
}

Console.WriteLine("Сумма цифр в введенном числе равна " + result);