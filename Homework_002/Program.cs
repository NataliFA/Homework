﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void SecondDigit()
{
    Console.Write("Enter a three-digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100 || num > 999)
        Console.Write("Error, enter a three-digit number");
    else 
    {
        int num1 = num / 10;
        int secDig = num1 % 10;
        Console.Write(num + " -> " + secDig);
    }
}
SecondDigit();
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThirdDigitOfNumber()
{
    
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
 
    
        Console.Write("no third digit");
}
ThirdDigitOfNumber();
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Dayofweek()
{
    Console.Write("Enter the day of the week: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 0 && num < 6)
        Console.Write("It's a workday");
    else 
        if (num == 6 || num == 7)
        Console.Write("It's a day off");
        else 
        Console.Write("Incorrect number");
}
Dayofweek();
*/