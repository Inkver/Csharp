﻿// 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 10:45
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

// {
//     int product = 1;
//     while (number != 0)
//     {
//         product *= number;
//         number --;
//     }
//     return product;
// }

// Console.WriteLine(ProductOfNumber(userNumber));
int MultOfNumber(int number)
{
int mult = 1;
for (int i = 1; i <= userNumber; i++)
{
mult *= i;
}
return mult;
}
Console.WriteLine(MultOfNumber(userNumber));