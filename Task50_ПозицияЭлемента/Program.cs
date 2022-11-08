// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 10);
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

Console.WriteLine("Введите значение элемента X: ");
int x = Convert.ToInt32(Console.ReadLine());

void positionArray(int[,] mas)

{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] == x) Console.WriteLine($"Индекс числа {x} равен [{i},{j}]");
            // else Console.WriteLine("Такого числа в массиве нет")
        }
    }
}
positionArray(mas);



// Вопрос по несуществующему элементу, как отразить?

