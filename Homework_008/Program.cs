// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/* доделать
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

void Print2DArray(int[,] newArr)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            Console.Write(newArr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] AscendingOrder(int[,] arr)
{
    Console.WriteLine();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int j = 0;

        while (j < arr.GetLength(1))
        {
            int min = arr[0,0];

            if (arr[i, j] > min)
            {
                min = arr[i, j];
                int temp = min;
                min = arr[i, j];
                arr[i, j] = temp;
                j++;
            }
            else j++;
        }
    }
    return arr;
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, cols);
int[,] newArray = AscendingOrder(myArray);

Print2DArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* проверить, убрать лишнее
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

int[] SumElOfRows(int[,] arr)
{
    Console.WriteLine();
    int[] nas = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int j = 0;
        int sum = 0;
        while (j < arr.GetLength(1))
        {
            sum = sum + arr[i, j];
            j++;
        }
        nas[i] = sum;

    }
    return nas;
}

void MinSum(int[] ar)
{
    int i = 0;
    int minPosition = 0;
    int min = ar[0];

    while (i < ar.Length)
    {
        if (ar[i] < min)
        {
            min = ar[i];
            minPosition = i;
        }
        i++;

    }
    Console.Write($"Строка с наименьшей суммой элементов - {minPosition + 1}");
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, cols);
int[] newarraysum = SumElOfRows(myArray);

ShowArray(newarraysum);
MinSum(newarraysum);
*/

// Задача 62: Заполните спирально массив 4 на 4.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j + 1;
        }
    }
    return array;
}


void CreateRandom2DArray2(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = m - 1; i == 1; i--)
    {
        for (int j = n - 2; j == 1; j--)
        {
            array[i, j] = i + j + 3;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

void Print2DArray(int[,] newArr)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            Console.Write(newArr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

//int[,] myArray = 
CreateRandom2DArray2(rows, cols);

//Print2DArray(myArray);
