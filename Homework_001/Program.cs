// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* 
Console.Write("Imput first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("max = " + num2);
}
*/

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Imput first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("max = " + num1);
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine("max = " + num2);
    }
    else 
    {
        Console.WriteLine("max = " + num3);
    }
}
