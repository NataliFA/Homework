// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет 12821 -> да
/*
void Palindrome(int num)
{
    if (num < 9999 || num > 99999) Console.Write("Error, input a five-digit number!");
    else
    {
        int num1 = num / 10000;
        int num2 = (num / 1000) % 10;
        int num3 = (num / 10) % 10;
        int num4 = num % 10;

        Console.Write($"Is the {num} a palindrome? -> ");

        if (num1 == num4 && num2 == num3)
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84
/*
double Distance2dot3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
    Console.Write($"A ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}) -> ");
    return Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
}

Console.Write("Введите координату X 1 точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y 1 точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z 1 точки: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X 2 точки: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y 2 точки: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z 2 точки: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Distance2dot3D(x1, y1, z1, x2, y2, z2));
*/
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27
/*
void CubeTable(int num)
{
    if (num > 0)
    {
        int count = 1;
        Console.Write(num + " -> ");
        while (count <= num)
        {
            Console.Write(count * count * count + " ");
            count++;
        }
    }
    else
    {
        int count = 1;
        Console.Write(num + " -> ");
        num = num * (-1);
        while (count <= num)
        {
            Console.Write("-" + count * count * count + " ");
            count++;
        }
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeTable(number);
*/
