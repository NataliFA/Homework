// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void CreateRandom2DArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1) + Math.Round(new Random().NextDouble(), 1);
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimum number of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum number of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

CreateRandom2DArray(rows, cols, minValue, maxValue);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

string FindElement(int pos1, int pos2, int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == pos1 && j == pos2) return $"Element is {arr[i, j]}";
        }
    }
    return "This element is not in the array.";
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, cols);

Console.Write("Input the position of the element - № rows: ");
int rowsNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the position of the element - № columns: ");
int colsNum = Convert.ToInt32(Console.ReadLine());

Console.Write(FindElement(rowsNum, colsNum, myArray));
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void ArithmeticMeanElColumn(int[,] arr)
{
    Console.WriteLine();
    double avg = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int i = 0;
        double sum = 0;

        while (i < arr.GetLength(0))
        {
            sum = sum + arr[i, j];
            i++;
        }
        avg = Math.Round(sum / arr.GetLength(0), 2);
        Console.Write(avg + "; ");
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, cols);

Console.Write("Arithmetic mean of each column: ");
ArithmeticMeanElColumn(myArray);
*/