﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */
Console.WriteLine("Введите число, что бы узнать, четное оно или нет");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine($"число {number1} четное");   
}
else
{
    Console.WriteLine($"число {number1} нечетное"); 
}