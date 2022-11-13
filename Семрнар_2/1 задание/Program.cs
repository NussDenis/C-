// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Function()
{
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine($"Случайное число: {number}");
    int firstnumber = number / 10;
    Console.WriteLine($"Вторая цифра случайного числа: {firstnumber % 10}");
}
Function();