// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] GetRandomArray(int arrayLength1, int start, int end)
{
    double[] array = new double[arrayLength1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end) + new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] arrayToPrint)
{   
    double min = arrayToPrint[0];
    double max = 0.0;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {   
        if (Math.Round(arrayToPrint[i], 2) > max)
        {
            max = Math.Round(arrayToPrint[i], 2);
        }
        if (Math.Round(arrayToPrint[i], 2) < min)
        {
            min = Math.Round(arrayToPrint[i], 2);
        }
        Console.Write(Math.Round(arrayToPrint[i], 2));
        if (i < arrayToPrint.Length - 1)
        {
        Console.Write (", ");
        }
    }
    Console.Write($"]{max} - {min} = {Math.Round(max - min, 2)}");
}

System.Console.WriteLine("Введи число: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int start = Convert.ToInt32(Console.ReadLine());
int stop = Convert.ToInt32(Console.ReadLine());


double[] genArray = GetRandomArray(arrayL, start, stop);
PrintArray(genArray);