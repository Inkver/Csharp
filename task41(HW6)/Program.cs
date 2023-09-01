// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write("Введите, какое количество чисел необходимо поситать: ");
int numbers = Convert.ToInt32(Console.ReadLine());

int[] FillUserArray(int num)
{   
    Console.Write("Введите по очереди заданное количество чисел: ");
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array [i] = Convert.ToInt32(Console.ReadLine());
      
    }
    return array;
}

void PrintArray(int[] arrayToPrint)
{   
    int posCount = 0;
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {   
        if (arrayToPrint[i] > 0)
        {
            posCount += 1;
        }
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
        Console.Write (", ");
        }
    }
    Console.Write($"] > количество цифр больше 0: {posCount}");
}

int[] conclusion = FillUserArray(numbers);
PrintArray(conclusion);