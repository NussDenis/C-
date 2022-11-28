void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}
void FillArrayDouble(double[] nums)
{
    Random rand = new Random();
    double length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = Convert.ToDouble(rand.Next(-500, 500)/100.0) ;
    }
}
void PrintArray(int[] nums)
{
    double length = nums.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
void PrintArrayDouble(double[] nums)
{
    double length = nums.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Zadacha34()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.WriteLine("Колличество чётных числе в массиве - " + count);
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Zadacha36()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 20);
    PrintArray(numbers);
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum += numbers[i];
    }
    Console.WriteLine("Сумма элементов с нечётными индексами в массиве - " + sum);
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95


void Zadacha38()
{
    int size = 5;
    double[] numbers = new double[size];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    double min = 0;
    double max = 0;
    double result = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] < min) min = numbers[i];
    }
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > max) max = numbers[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами масcива = {result = max - min}");
}


// Zadacha34();
// Zadacha36();
// Zadacha38();