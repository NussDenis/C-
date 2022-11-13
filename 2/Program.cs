//void Zadacha()
//{
// Задача 1.
// Random rand = new Random ();
// int number = rand.Next(10,100);

// Console.WriteLine(number);
// int tens = number / 10;
// int ones = number % 10;

// Console.WriteLine("Наибольшая цифра числа");
// if (tens > ones)
// {
//     Console.WriteLine(tens);
// }
// else
// {
//     Console.WriteLine(ones);
// }

// Задача 2.
// Random rand = new Random();
// int number = rand.Next(100, 1000);
// Console.WriteLine("Случайное число: " + number);
// int a = number / 100;
// int b = number % 10;
// int c = a * 10 + b;
// Console.WriteLine("Новое число: " + c);

// Задача 3.
// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a % b == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine($"Не кратно, остаток от деления равен: {a % b}");
// }

// Задача 4.

// void Zadacha()
// {
    // Console.WriteLine("Введите число");
    // int a = Convert.ToInt32(Console.ReadLine());

    // if (a % 7 == 0 && a % 23 == 0)
    // {
    //     Console.WriteLine("Введенное число кратно 7 и 23");
    // }
    // else
    // {
    //     Console.WriteLine("Не кратно одному из числу");
    // }


    // Задача 5.
void Zadacha()
{
    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a * a == b || b * b == a)
    {
        Console.WriteLine("Число является квадратом введеного числа");
    }
    else
    {
        Console.WriteLine("Число не является квадратом введеного числа");
    }
}
Zadacha();