﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());


void AkkFunc(int m, int n)
{
    Console.Write(Akk(m, n)); 
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}

AkkFunc(m,n);