﻿// 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

void NaturalNum(int num, int start = 1)
{
    if (start <= num)
    {
        Console.Write(start+", ");
        NaturalNum(num, start + 1);
    }
}

NaturalNum(5);