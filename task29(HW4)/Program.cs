﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine("Введите границу чисел от: ");
// int startNum = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите границу чисел до: ");
// int endNum = Convert.ToInt32(Console.ReadLine()); 

// int[] GetRandomArray(int start, int end)
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(start, end);

//     }
//     return array;
// }
// int[] userArray = GetRandomArray(startNum, endNum);

// void PrintArray(int[] arrayToPrint)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arrayToPrint.Length; i++)
//     {
//         if (i != 7)
//         {
//             System.Console.Write($"{arrayToPrint[i]}, ");
//         }
//         else
//         {
//             System.Console.Write($"{arrayToPrint[i]}");
//         }
        
//     }
//     System.Console.Write("]");
// }

// PrintArray(userArray);


Console.WriteLine("Введите длину массива и границы рандомных чисел: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());


int[] GetRandomArray(int arrayLength1, int start, int end)
{
    int[] array = new int[arrayLength1];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

int[] userArray = GetRandomArray(arrayLength, min, max);

void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i=0; i<arrayToPrint.Length; i++)
    {
       Console.Write(arrayToPrint[i]);
       if (i<arrayToPrint.Length - 1)
       {
        Console.Write (", ");
       }
    }
    Console.Write("]");
}

PrintArray(userArray);