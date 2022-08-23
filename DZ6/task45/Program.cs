// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyToNewArray (int[] source, int size)
{
    int[] DestinationArray = new int[size];
        for (int i=0; i< size; i++)
        {
            DestinationArray[i] = source [i];   
        }
    return DestinationArray;
}

void PrintArray (int [] ArrayForPrinting)
{
    Console.Write ("Значения элементов массива равны - ");
    for (int i=0; i < ArrayForPrinting.Length; i++) Console.Write(ArrayForPrinting[i] + " ");
}

int [] SourceArray = new int[] {1,2,3,4,5,6,7,8};

int [] dst = CopyToNewArray (SourceArray, SourceArray.Length);

PrintArray(dst);