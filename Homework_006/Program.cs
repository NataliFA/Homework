// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void AmountOfPositiveNumbers(int M)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Input {i + 1} number - ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
            count++;
    }
    Console.WriteLine("Amount of positive numbers = " + count);
}

Console.Write("How many numbers do you want to enter? ");
int m = Convert.ToInt32(Console.ReadLine());

AmountOfPositiveNumbers(m);
*/

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101, 3 -> 11
/*
int[] ConvertingDecimalToBinary(int size, int number)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = number % 2;
        number /= 2;
    }
    return arr;
}

int ArraySize(int number)
{
    int count = 0;

    while (number > 0)
    {
        number /= 2;
        count++;
    }
    return count;
}

void ReverseAndPrintArray(int[] ar)
{
    for (int j = ar.Length - 1; j >= 0; j--) Console.Write(ar[j]);
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int s = ArraySize(number);
int[] myArray = ConvertingDecimalToBinary(s, number);

ReverseAndPrintArray(myArray);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.Write($"Intersection point coordinate ({x}, {y})");
}

Console.Write("Input b1: ");
double B1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1: ");
double K1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
double B2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k2: ");
double K2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(B1, K1, B2, K2);
*/
