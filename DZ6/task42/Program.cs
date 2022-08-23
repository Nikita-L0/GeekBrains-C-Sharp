// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Введите десятичное число - ");

int number = Convert.ToInt32(Console.ReadLine());

int BitsNumber = 0;

while ( number >= Math.Pow(2,BitsNumber) ) BitsNumber++;

int[] array = new int[BitsNumber];

Console.Write ("Десятичному числу " + number + " соответствует двоичное число - ");
for (int i = 0; i < BitsNumber; i++)
{
    if (number - Convert.ToInt32(Math.Pow (2, BitsNumber-1-i)) >=0 ) 
    {
        array[i] = 1;
        number = number - Convert.ToInt32(Math.Pow (2, BitsNumber-1-i));
    }
    else array[i] = 0;
    Console.Write(array[i]);
}

