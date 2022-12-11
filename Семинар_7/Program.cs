void FillArray(int[,] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            nums[i, j] = rand.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] nums)
{
    int rows = nums.GetLength(0);
    int columns = nums.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{nums[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Zadacha47()
{
    int rows = 4;
    int columns = 4;
    double[,] numbers = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round((rand.NextDouble() * 100 - 50), 1);
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 3 -> 3

void Zadacha50()
{
    int rows = 5;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, -100, 100);
    PrintArray(numbers);
    Console.WriteLine();
    Console.Write("Введите значение строки - ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение столбца - ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (n < rows && m < columns)
    {
        Console.Write($"Значение выбранного элемента в массиве = {numbers[n, m]}");
    }
    else Console.WriteLine("В массиве такой элемент отсутствует");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

void Zadacha52()
{
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    double sum = 0;
    FillArray(numbers, 0, 20);
    PrintArray(numbers);
    Console.WriteLine();
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum += numbers[i, j];
        }
        Console.WriteLine($"Среднееарифметическое значение {j + 1} столбца = {sum / rows}");
        sum = 0;
    }
}


// Zadacha47();
// Zadacha50();
// Zadacha52();