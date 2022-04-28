// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int A = 2;
int B = 4;
int result = 1;
for (int i = 0; i < B; i++)
{
    result = result * A;
}
Console.Write(result);
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int num = 8526925;
int sum = 0;
while (num % 10 != 0)
{
    int ost = num % 10;
    sum = sum + ost;
    num /= 10;
}
Console.Write(sum);
*/
// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] array8 = new int[8];
for (int i = 0; i < array8.Length; i++)
{
    array8[i] = new Random().Next(0, 20);
    Console.Write(array8[i] + " ");
}
*/
