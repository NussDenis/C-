// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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
    double length = nums.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine("\n");
}


void Zadacha41()
{
    int size = 15;
    int[] numbers = new int[size];
    FillArray(numbers, -50, 50);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < size; i++) if (numbers[i] > 0)
        {
            count++;
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
    Console.WriteLine("Колличество числе больше 0, введенных пользователем - " + count);
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Zadacha43()
{
    Console.Write("Введите значение b1 - ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k1 - ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b2 - ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2 - ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
    double y = Math.Round((k2 * x + b2), 2);
    Console.WriteLine($"Точка пересечения 2-х прямых: ( {x}; {y} )");



}

// Zadacha43();
// Zadacha41();

