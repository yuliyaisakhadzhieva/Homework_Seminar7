﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[,] arrayNew)
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

int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();


void avArray(int[,] mas)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            average = (average + mas[i, j]);
        }
        average = average / n;
        Console.WriteLine($"Среднее арифметическое столбца равно:{Math.Round(average, 2)}");

    }
}
avArray(mas);

