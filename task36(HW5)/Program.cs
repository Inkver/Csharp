// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{   
    int sum = 0;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {   if (i % 2 != 0)
        {
            sum += arrayToPrint[i];
        }
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
        Console.Write (", ");
        }
    }
    Console.Write($"] сумма элементов, стоящих на нечётных позициях - {sum} ");
}

System.Console.WriteLine("Введи число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int start = Convert.ToInt32(Console.ReadLine());
int stop = Convert.ToInt32(Console.ReadLine());


int[] genArray = GetRandomArray(arrayL, start, stop);
PrintArray(genArray);