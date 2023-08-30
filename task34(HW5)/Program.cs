// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int arrayLength1)
{
    int[] array = new int[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(99, 999);
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{   
    int count = 0;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
        if (arrayToPrint[i] % 2 == 0)
        {
            count += 1;
        }
        if (i < arrayToPrint.Length - 1)
        {
        Console.Write (", ");
        }
    }
    Console.Write($"] положительные числа в кол-ве - {count} шт");
}

int[] genArray = GetRandomArray(4);
PrintArray(genArray);