// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());   

int SumOfNumber(int num)
{   
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine(SumOfNumber(userNumber));