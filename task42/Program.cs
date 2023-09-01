Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

string Division(int a)
{
    string result = string.Empty;
    int temp = 0;
    for (int i = a; i > 0; i/=2)
    {
        temp = i % 2;
        result = temp + result;
    }
return result;
}

string conclusion = Division(a);
Console.WriteLine(conclusion);