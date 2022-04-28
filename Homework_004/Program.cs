// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

void AmountOfEvenNumbers(int[] array)
{
    Console.WriteLine();
    Console.Write("Количество четных элементов - ");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.Write(count);
}

int[] myarray = CreateRandomArray(10);
AmountOfEvenNumbers(myarray);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
    return array;
}

void SumOfOddPosition(int[] array)
{
    Console.WriteLine();
    Console.Write("Сумма элементов на нечетных позициях - ");
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    Console.Write(sum);
}

int[] myarray = CreateRandomArray(7, 0, 5);
SumOfOddPosition(myarray);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

double[] CreateRandomArray(int size, int min, int max)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
    return array;
}

void DifferenceMaxMinEl(double[] arr)
{
    Console.WriteLine();
    Console.Write("Разница между максимальным и минимальным элементом массива - ");


    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        else
        {
            if (arr[i] < min)
                min = arr[i];
        }
    }

    Console.Write($"{max} - {min} = ");
    double dif = max - min;
    Console.Write(dif);
}

double[] myarray = CreateRandomArray(10, -10, 20);
DifferenceMaxMinEl(myarray);
