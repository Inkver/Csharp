// 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
System.Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());
if (quarter == 1)
{
    Console.WriteLine("Все x больше 0, Все y больше 0");
}

else if (quarter == 2)
{
    Console.WriteLine("Все x меньше 0, Все y меньше 0");
}

else if (quarter == 3)
{
    Console.WriteLine("Все x больше 0, Все y меньше 0");
}

else if (quarter == 4)
{
    Console.WriteLine("Все x больше 0, Все y меньше 0");
}

else
{
    Console.WriteLine("Нет такой четверти");
}