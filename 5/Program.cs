// Задача 31: Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

void Zadacha31()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    FindSumPos(numbers);
    FindSumNeg(numbers);
}
// Zadacha31();

void FindSumPos(int[] nums)
{
    int sum = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++) if (nums[i] > 0) sum += nums[i];
    Console.WriteLine("Сумма положительных элементов: " + sum);
}

void FindSumNeg(int[] nums)
{
    int sum = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++) if (nums[i] < 0) sum += nums[i];
    Console.WriteLine("Сумма отрицательных элементов: " + sum);
}



// Задача 32: Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void Zadacha32()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) numbers[i] = numbers[i] * -1;
        else if (numbers[i] > 0) numbers[i] = numbers[i] * -1;
    }
    PrintArray(numbers);
}
// Zadacha32();

// Задача 33: Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void Zadacha33()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 9);
    PrintArray(numbers);

    Console.Write("Введите число - ");
    int x = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    for (int i = 0; i < numbers.Length && !flag; i++)
    {
        if (numbers[i] == x) flag = true;
    }
    if (flag) Console.WriteLine("В массиве присутствует введенная цифра");
    else Console.WriteLine("В массиве отсутствует введенная цифра");
}
// Zadacha33();


// Задача 35: Задайте одномерный массив из 10 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10,99]. 
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void Zadacha35()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 150);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 9 && numbers[i] < 100) count++;
    }
    Console.WriteLine("Количество элементов в массиве - " + count);
}
// Zadacha35();

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void Zadacha37()
{
    int size = 9;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    int res = size / 2;
    int[] result = new int[res + size % 2];
    int maxIndex = size - 1;
    for (int i = 0; i < res; i++)
    {
        result[i] = numbers[i] * numbers[maxIndex - i];
    }
    if (size % 2 == 1) result[res] = numbers[res];
    PrintArray(result);
}
// Zadacha37();


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
void PrintArray(int[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine("\n");
}

// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

void Zadacha39()
{
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];
    FillArray(numbers, 0, 50);
    PrintArray(numbers);
    int maxIndex = size - 1;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[maxIndex - i] = numbers[i];
    }
    PrintArray(result);
    // второй способ
    for (int i = 0; i < size / 2; i++)
    {
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
    PrintArray(numbers);
}
// Zadacha39();

// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник со сторонами такой длины.

void Zadacha40()
{
    int size = 3;
    int[] number = new int[size];
    int[] numberA = new int[size];
    FillArray(number, 0, 100);
    PrintArray(number);
    numberA[0] = number[1] + number[2];
    numberA[1] = number[0] + number[2];
    numberA[2] = number[0] + number[1];
    bool result = false;
    for (int i = 0; i < size; i++)
    {
        if (number[i] < numberA[i]) result = true;
    }
    if (result) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник не существуют");
}
// Zadacha40();

// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

void Zadacha42()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    int bias = 1;
    while (a > 0)
    {
        result += (a % 2) * bias;
        bias *= 10;
        a /= 2;
    }
    Console.WriteLine(result);
}
// Zadacha42();

// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Zadacha44()
{
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    double a = 0;
    double b = 1;
    for (int i = 1; i <= n; i++)
    {
        Console.Write(a + " ");
        double temp = b;
        b = b + a;
        a = temp;
    }
    Console.WriteLine();
}
// Zadacha44();

void Zadacha45()
{
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];
    FillArray(numbers, 0, 50);
    PrintArray(numbers);
    int[] result = new int[size];
    CopyArray(numbers, result);
    PrintArray(result);
}
Zadacha45();

void CopyArray(int[] firstArray, int[] secondArray)
{
    int size = firstArray.Length;
    for (int i = 0; i < size; i++)
    {
        secondArray[i] = firstArray[i];
    }
}