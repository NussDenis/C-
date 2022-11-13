//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Function()
{
    Console.Write("Введите день недели: ");
    int result = Convert.ToInt32(Console.ReadLine());
    if (result == 1 || result < 6)
    {
        Console.WriteLine("Это будний день");
    }
     else if (result == 6 || result == 7)
    {
        Console.WriteLine("Это выходной день");
    }
       else
    {
        Console.WriteLine("неверный ввод!");
    }
}
Function();