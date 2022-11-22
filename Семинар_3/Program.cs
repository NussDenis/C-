// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число");
    double a = Convert.ToInt32(Console.ReadLine());
    if (a > 99999 || a < 10000) Console.Write("Веденное некорректное число");
    else if (a / 10000 == a % 10 && (a / 1000) % 10 == (a % 100) / 10) Console.Write("Веденное число является палиндромом");
    else Console.Write("Веденное число НЕ палиндром");
}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Zadacha21()
{
    Console.WriteLine("Введите три координаты точки А");
    double x1 = Convert.ToInt32(Console.ReadLine());
    double y1 = Convert.ToInt32(Console.ReadLine());
    double z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите три координаты точки B");
    double x2 = Convert.ToInt32(Console.ReadLine());
    double y2 = Convert.ToInt32(Console.ReadLine());
    double z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Расстояние между точками - {Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))), 4)}");
}

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Zadacha23()
{
    Random rand = new Random();
    int number = rand.Next(1, 15);
    Console.WriteLine("Введено число - " + number);
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

// Zadacha19();
// Zadacha21();
// Zadacha23();