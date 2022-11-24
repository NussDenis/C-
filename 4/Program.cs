// int SumNumber(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number;

//     }
// }
// void Zadacha24()
// {
//     Random rand = new Random();
//     int number = rand.Next(1, 20);
//     Console.WriteLine("Введено число " + number);
//     int counter = 1;
//     int sum = 0;
//     while (sum <= number)
//     {
//         Console.Write($"{sum} + {counter} =  ");
//         sum = sum + counter;
//         Console.WriteLine(sum);
//         counter++;
//     }
// }
// Zadacha24();


// void Zadacha26()
// {
//     Random rand = new Random();
//     int number = rand.Next(1, 100000);
//     Console.WriteLine("Введено число - " + number);
//     int result = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         result++;
//     }
//     Console.Write("В веденном числе цифр - " + result);
// }
// Zadacha26();

// void Zadacha28()
// {
//     Random rand = new Random();
//     int number = rand.Next(1, 25);
//     Console.WriteLine("Введено число " + number);
//     int mult = 1;
//     int count = 1;
//     while (count <= number)
//     {
//         mult = mult * count;
//         Console.WriteLine(count);
//         count++;
//     }
//      Console.WriteLine($"Произведение равно {mult}");
// }
// Zadacha28();


void Zadacha30()
{
    int size = 8;
    Random rand = new Random();
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(0, 15);
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
}
Zadacha30();