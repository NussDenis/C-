// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Function()
{
    Console.WriteLine("Введите любое число");
    int a = Convert.ToInt32(Console.ReadLine());
      if (a < 100)
    {
        Console.WriteLine("Третья цифра в числе отсутствует");
    }
    else while (a > 1000)
        {
            a = a / 10;
        }
    if (a > 99)
    {
        Console.WriteLine($"Третья цифра введенного числа: {a % 10}");
    }
}
Function();

