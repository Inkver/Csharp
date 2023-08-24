/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int numberOne = number / 100;
Console.WriteLine(numberOne);

int numberTwo = number % 10;
Console.WriteLine(numberTwo);

string strNumberOne = Convert.ToString(numberOne);
string strNumberTwo = Convert.ToString(numberTwo);

string numberFinish = strNumberOne + strNumberTwo;
int intnumberFinish = Convert.ToInt32(numberFinish);
Console.WriteLine(intnumberFinish);