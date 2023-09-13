// // 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int temp = 0;
// void NaturalNum(int num, int start = 1)
// {   
//     if (start <= num)
//     {
//         temp += start;
//         NaturalNum(num, start + 1);
//     }
// }

// NaturalNum(5);
// Console.WriteLine(temp);

// // void NaturalNum(int num)
// // {   
// //     int sum = 0;

// //     for (int i = 0; i <= num; i++)
// //     {
// //         sum += i;
// //     }
// //     Console.Write(sum);
// // }

// // NaturalNum(5);

/* 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/
int result = SumNumber(246);

int SumNumber (int n)
{
if (n==0)
return 0;
else
return n%10+SumNumber(n/10);
}
System.Console.WriteLine(result);