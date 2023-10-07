// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] matrix = new double[3, 4];
// void FillArray(double[,] matr)
// {
//     double min = -10.0;
//     double max = 10.0;

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().NextDouble() * (max - min) + min;
//         }
//     }
// }
// void PrdoubleArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(string.Format("{0:F2}", matr[i, j]));
//             Console.Write(" ");
//         }
//         Console.WriteLine();
//     }
// }
// PrdoubleArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrdoubleArray(matrix);
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Console.Write("Введите индекс строки: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите индекс столбца: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[3, 4];

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// FillArray(numbers);
// PrintArray(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine($"Число с индексом ({rows},{colums}) равно {numbers[rows, colums]}");
// else Console.WriteLine($"Числа с индексом ({rows}:{colums}) в массиве нет");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] numbers = new int[3, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArithmeticMean(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        Console.WriteLine($"{result/array.GetLength(0)} ");
    }
    Console.WriteLine();
}

FillArray(numbers);
PrintArray(numbers);
ArithmeticMean(numbers);