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
// void Zadacha()
// {
//     Console.WriteLine("Введите первое число");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите второе число");
//     int b = Convert.ToInt32(Console.ReadLine());

//     if (a * a == b || b * b == a)
//     {
//         Console.WriteLine("Число является квадратом введеного числа");
//     }
//     else
//     {
//         Console.WriteLine("Число не является квадратом введеного числа");
//     }
// }
// Zadacha();

// void Zadacha17()
// {
//     Random rand = new Random();
//     int x = rand.Next(-10, 11);
//     int y = rand.Next(-10, 11);
//     Console.WriteLine($"A {x}, {y})");

//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("1-я четверть");
//     }
//     else if (x < 0 && y > 0)
//     {
//         Console.WriteLine("2-я четверть");
//     }
//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("3-я четверть");
//     }
//     else if (x > 0 && y < 0)
//     {
//         Console.WriteLine("4-я четверть");
//     }
//     else
//     {
//         Console.WriteLine("Точка лежит на координатной прямой");
//     }
// }
// Zadacha17();

// void Zadacha18()
// {
//     Console.WriteLine("Введите номер четверти");
//     int a = Convert.ToInt32(Console.ReadLine());

//     if (a == 1)
//     {
//         Console.WriteLine("В данной четверти Х>0 и Y>0");
//     }
//     else if (a == 2)
//     {
//         Console.WriteLine("В данной четверти Х<0 и Y>0");
//     }
//     else if (a == 3)
//     {
//         Console.WriteLine("В данной четверти Х<0 и Y<0");
//     }
//     else if (a == 4)
//     {
//         Console.WriteLine("В данной четверти Х>0 и Y<0");
//     }
//     else
//     {
//         Console.WriteLine("Неверно введенная четверть!!!");
//     }
// }
// Zadacha18();

// void Zadacha21()
// {
//     Console.WriteLine("Введите координаты 1-ой точки");
//     double x1 = Convert.ToInt32(Console.ReadLine());
//     double y1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату 2-ой точки");
//     double x2 = Convert.ToInt32(Console.ReadLine());
//     double y2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Расстояние = {Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2))}");
// }
// Zadacha21();

// void Zadacha22()
// {
//     Console.WriteLine("Введите любое целое число");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int b = 1;
//     while (b <= a)
//     {
//         Console.WriteLine($"{b} * {b} = {(Math.Pow(b, 2))}");
//         b++;
//     }
// }
// Zadacha23();

// void Zadacha23()
// {

// }
// Zadacha23();

