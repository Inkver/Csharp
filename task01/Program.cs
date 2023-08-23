/*’Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
а = 25; b = 5 -> да а = 2 b = 10 -> нет а = 9; b = -3 -> да а = -3 b = 9 -> нет
*/
Console.WriteLine("vvedite 2 chisla");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Yavlayetsya");
}
else
{
   Console.WriteLine("Ne Yavlayetsya");
}
