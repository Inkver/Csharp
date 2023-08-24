// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём Х*0иУ*0и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.WriteLine("Введите X и Y вашей точки: ");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());

if(userX > 0 && userY > 0)
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся в первой четверти");
}

else if(userX < 0 && userY > 0)
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся второй четверти");
}

else if(userX < 0 && userY < 0)
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся в третьей четверти");
}

else
{
    System.Console.WriteLine($"Точка {userX} : {userY} находятся в четвертой четверти");
}