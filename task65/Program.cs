// 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void NaturalNum(int m, int num)
{
    if (m <= num)
    {
        Console.Write(m+", ");
        NaturalNum(m + 1, num);
    }
}

NaturalNum(1, 10);