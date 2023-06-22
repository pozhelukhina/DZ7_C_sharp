// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[row, cols];

void FillArray(int row, int cols)
{
    for (int i = 0; i < randomArray.GetLength(0); i++)
        for (int j = 0; j < randomArray.GetLength(1); j++)
            randomArray[i, j] = new Random().Next(-30, 31);
}

void PrintArray(int row, int cols)
{
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            Console.Write(randomArray[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void avgcols(int row, int cols)
{
    int i;
    int j;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (j = 0; j < cols; j++)
    {
        double sum = 0;
        for (i = 0; i < row; i++)
        {
            sum = sum + randomArray[i, j];
        }
        Console.Write($"{sum / (i):F1}; ");
    }
}
FillArray(row, cols);
PrintArray(row, cols);
avgcols(row, cols);