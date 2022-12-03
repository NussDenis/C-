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


// Задача 48:
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: A = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void Zadacha48()
{
    int rows = 8;
    int columns = 8;
    int[,] numbers = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
// Zadacha48();


// Задача 49:
// Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их 
// квадраты.

void Zadacha49()
{
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                numbers[i, j] = (numbers[i, j]) * (numbers[i, j]);
                Console.Write($"{numbers[i, j]}\t");
            }
            else Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Zadacha49();

// Задача 51:
// Задайте двумерный массив. Найдите сумму 
// элементов, находящихся на главной диагонали (с индексами (0,0); 
// (1;1) и т.д.

void Zadacha51()
{
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum += numbers[i, j];
            }
        }
    }
    Console.WriteLine("Сумма элементов по диагонале = " + sum);
}
// Zadacha51();

void Zadacha51_2()
{
    int rows = 8;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    int min = Math.Min(rows, columns);
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < min; i++)
    {
        {
            sum += numbers[i,i];
        }
    }
Console.WriteLine("Сумма элементов по диагонале = " + sum);
}
Zadacha51_2();