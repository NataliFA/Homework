// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Nert(0, 10);
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
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] > arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

Console.Write("Input number of r: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(r, c);
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
            array[i, j] = new Random().Nert(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int[] SumElOfr(int[,] arr)
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

Console.Write("Input number of r: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(r, c);
int[] newArraySum = SumElOfr(myArray);

ShowArray(newArraySum); // Метод ShowArray для вывода одномерного массива, который представляет из себя сумму каждой строки двумерного массива. Для проверки
MinSum(newArraySum);
*/

// Задача 62: Заполните спирально массив 4 на 4.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    int num = 1;

    for (int j = 0; j < n; j++)
    {
        array[0, j] = num;
        num++;
    }
    for (int i = 1; i < m; i++)
    {
        array[i, n - 1] = num;
        num++;
    }
    for (int k = n - 2; k >= 0; k--)
    {
        array[m - 1, k] = num;
        num++;
    }
    for (int l = m - 2; l >= 1; l--)
    {
        array[l, 0] = num;
        num++;
    }

    int r = 1, c = 1;

    while (num < m * n)
    {
        while (array[r, c + 1] == 0)
        {
            array[r, c] = num;
            num++;
            c++;
        }
        while (array[r + 1, c] == 0)
        {
            array[r, c] = num;
            num++;
            r++;
        }
        while (array[r, c - 1] == 0)
        {
            array[r, c] = num;
            num++;
            c--;
        }
        while (array[r - 1, c] == 0)
        {
            array[r, c] = num;
            num++;
            r--;
        }
        if (array[r, c] == 0) array[r, c] = m * n;
    }
    return array;
}

void Print2DArray(int[,] newArr)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            Console.Write(newArr[i, j] + "\t");
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
*/

