//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
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
void ThirdDigitOfNumber(int num)
{
    if (num < 100)
        Console.Write(num + " -> No third digit");
    if (num > 99 && num < 1000)
    {
        int num1 = num % 10;
        Console.Write(num + " -> " + num1);
    }
    if (num > 999)
    {
        int count = 0;
        Console.Write(num);
        while (num > 999)
        {
            num /= 10;
            if (num < 999)
            {
                int num2 = num % 10;
                Console.Write(" -> " + num2);
                break;
            }
            count++;
        }
    }
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigitOfNumber(number);
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