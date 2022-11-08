﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-99, 101)) / 10;
        }
    }
    return array;
}

void PrintArray(double[,] arrayNew)
{
    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            Console.Write($"{arrayNew[i, j]} \t");
        }
        Console.WriteLine();
    }
}

double[,] mas = FillArray(m, n);
PrintArray(mas);


