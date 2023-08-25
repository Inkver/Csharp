// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число 1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());   

Console.WriteLine("Введите число 2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num1, int num2)
{
    
    double result = Math.Pow(num1,num2);
    return Convert.ToInt32(result);
}

Console.WriteLine(Exponentiation(userNumber1, userNumber2));