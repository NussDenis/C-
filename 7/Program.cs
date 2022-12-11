// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.


void Zadacha63()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());


    int counter = 1;
    // while (counter <= number)
    // {
    //     Console.Write($"{counter} ");
    //     counter++;
    // }
    Recursion63(number, counter);
}

void Recursion63(int number, int counter)
{
    if (counter > number) return;
    Console.Write($"{counter} ");
    counter++;
    Recursion63(number, counter);
}


// Zadacha63();

// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 6, 7, 8"

void Zadacha65()
{
    Console.WriteLine("Введите число M:");
    int counter = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N:");
    int number = Convert.ToInt32(Console.ReadLine());

    Recursion65(number, counter);
}


void Recursion65(int number, int counter = 1)
{
    if (counter > number) return;
    Console.Write($"{counter} ");
    counter++;
    Recursion65(number, counter);
}

// Zadacha65();


// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
void Zadacha67()
{
    Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    // Recursion67(number); //1 способ
    Console.WriteLine($"Сумма цифр введенного числа равна - {Recursion67(number)}");
}

int Recursion67(int number)
{
    // 1 способ "VOID"
    // if (number == 0)
    // {
    //     Console.WriteLine($"Сумма цифр введенного числа равна - {sum}");
    //     return;
    // }
    // sum += number % 10;
    // number /= 10;
    // Recursion67(number, sum);
    // 2 способ "INT"
    if (number == 0) return 0;
    return number % 10 + Recursion67(number / 10);

}

// Zadacha67();

// Задача 69: Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень
// B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

void Zadacha69()
{
    Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число:");
    int b = Convert.ToInt32(Console.ReadLine());
    // Recursion67(number); //1 способ
    Recursion69(a,b);
}

void Recursion69(int a, int b, int result = 1)
{
    if (b == 0)
    {
        Console.WriteLine($"Ответ - {result}");
        return;
    }
    result *= a;
    b--;
    Recursion69(a, b, result);
}
Zadacha69();