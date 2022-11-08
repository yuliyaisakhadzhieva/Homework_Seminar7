// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10


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
            array[i, j] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] mas = FillArray(m, n);
PrintArray(mas);

int[] NewArray = new int[m * n];
int k = 0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        NewArray[k] = mas[i, j];
        k++;
    }
}

// void SelectionSort (int [] NewArray [k])
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array [j] < array [minPosition]) minPosition = j;
//         }
//         int temprorary = array [i];
//         array [i] = array [minPosition];
//         array [minPosition] = temprorary;
//     }
// }
// PrintArray (arr);
// SelectionSort (arr);

// PrintArray (arr);

