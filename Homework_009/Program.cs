// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumNaturalNum(int m, int n)
{
    if (n > m) n += SumNaturalNum(m, n - 1);
    return n;
}

Console.Write("Input number m: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number n: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) Console.Write("Input m < n!");
else Console.Write(SumNaturalNum(M, N));
*/

//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    int sum = 0;

    if (num % 10 != 0) sum += num % 10 + SumOfDigits(num /= 10);
    return sum;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(SumOfDigits(number));
*/