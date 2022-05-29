// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] newArr)
{
    Console.WriteLine();
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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int j = 0;

        while (j != arr.GetLength(1) - 1)
        {
            int min = arr[i, j];

            if (min < arr[i, j + 1])
            {
                min = arr[i, j + 1];
            }
            else
            {
                min = arr[i, j];
            }

            int temp = arr[i, arr.GetLength(1) - 1];
            arr[i, arr.GetLength(1) - 1] = arr[i, j];
            arr[i, j] = temp;
            j++;
        }
    }
    return arr;
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, cols);
Print2DArray(myArray);

int[,] newArray = AscendingOrder(myArray);
Print2DArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] SumElOfRows(int[,] arr)
{
    Console.WriteLine();
    int[] sumArray = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

void MinSum(int[] ar)
{
    int minPosition = 0;
    int min = ar[0];

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] < min)
        {
            min = ar[i];
            minPosition = i;
        }
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
int[] newArraySum = SumElOfRows(myArray);

ShowArray(newArraySum); // Метод ShowArray для вывода одномерного массива, который представляет из себя сумму каждой строки двумерного массива. Для проверки
MinSum(newArraySum);
*/
// Задача 62: Заполните спирально массив 4 на 4.

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[0, j] = i + j + 1;

            for (int k = m - 1; k != 0; k--)
            {
                for (int l = n - 2; l != 0; l--)
                {
                    array[k, l] = array[i, j] + k - l;

                    array[i, 0] = array[k, l] + 1;
                }
            }
        }
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

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(rows, cols);
Print2DArray(myArray);


