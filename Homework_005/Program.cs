// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Exponentiation(int A, int B)
{
    double result = 1;

    if (B < 0)
    {
        B = B * (-1);
        for (int i = 0; i < B; i++)
        {
            result = result / A;
        }
    }
    else
    {
        for (int i = 0; i < B; i++)
        {
            result = result * A;
        }
    }
    return result;
}

Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Number {a} to the power {b} = ");
double res = Exponentiation(a, b);
Console.Write(res);
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigitInNumber(int num)
{
    int sum = 0;

    while (num % 10 != 0)
    {
        int ost = num % 10;
        sum = sum + ost;
        num /= 10;
    }
    return sum;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"The sum of the digits in a number {number} = ");
int res = SumDigitInNumber(number);
Console.Write(res);
*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void RandomArray8El()
{
    int[] array8 = new int[8];

    for (int i = 0; i < array8.Length; i++)
    {
        array8[i] = new Random().Next(0, 20);
        Console.Write(array8[i] + " ");
    }
}
RandomArray8El();
*/