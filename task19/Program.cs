// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432-> да
// 12821-> да

Console.Write("Введите число для проверки его на палиндром: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int memory = 0;
int cycleSum = 0;
int originNum = numberN;
while (numberN > 0)
{
memory = numberN % 10;
cycleSum = (cycleSum * 10) + memory;
numberN = numberN / 10; 
}
if (originNum == cycleSum)
{
Console.WriteLine($"Число {originNum} палиндром.");
}
else
{
Console.WriteLine($"Число {originNum} не палиндром");
}

