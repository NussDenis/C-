// Задача 25
// Используя определение степени числа, напишите цикл, который принимает на вход два
// натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Zadacha25()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа");
    int b = Convert.ToInt32(Console.ReadLine());
    if (b == 0) Console.WriteLine($"Число {a} в степени {b} = {a}");
    else if (a > 0) Console.WriteLine($"Число {a} в степени {b} = {Math.Pow(a, b)}");
    else Console.WriteLine("Вы ввели не натуральное число");
}

// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Zadacha27()
{
    Console.Write("Введите число - ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.Write("Сумма всех цифр в введенном числе = " + (sum + number));
}

// Задача 29
// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
// -2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
// 6, 1, -33 -> [1, 6, -33]

void Zadacha29()
{
    int size = 8;
    Random rand = new Random();
    int[] array = new int[size];
    Console.Write("Массив из 8-ми случайных чисел: ");
    for (int i = 0; i < size; i++) Console.Write(" " + (array[i] = rand.Next(-100, 100)));
    Console.WriteLine();
    Console.Write("Массив отсортированный по модулю: ");
    for (int i = 0; i < size - 1; i++)
    {
        int Min = i;
        for (int j = i + 1; j < size; j++) if (Math.Abs(array[j]) < Math.Abs(array[Min])) Min = j;
        int position = array[i];
        array[i] = array[Min];
        array[Min] = position;
    }
    for (int i = 0; i < size; i++) Console.Write(array[i] + " ");
}

Zadacha25();
// Zadacha27();
// Zadacha29();