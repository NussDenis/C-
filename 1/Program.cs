// /*
// //Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// //Тип данных Имя переменной = значение переменной
// int number = 5;
// int numbersecond = 9;
// int result = number * number;
// Console.WriteLine($"{number} * {number} {result}");
// Console.WriteLine(numbersecond * numbersecond);

// int number = 20;
// if (number > 10)
// {
//     Console.WriteLine("Число больше 10");
// }
// else
// {
//     Console.WriteLine("Число не больше 10");
// }

// int number = 5;

// while (number < 10)
// {
//     Console.WriteLine(number);
//     number++;
// }

// int a = 2;
// int b = 10;
// int result = a * a;
// if(b == result)
// {
//     Console.WriteLine("Число а является квадратом числа b");
// }
// else
// {
//     Console.WriteLine("Число а НЕ является квадратом числа b");
// }

// Console.WriteLine("Введите число от 1 до 7");
// int result = Convert.ToInt32(Console.ReadLine());
// if(result == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(result == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(result == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if(result == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(result == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(result == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(result == 7)
// {
//     Console.WriteLine("Воскресень");
// }
// else
// {
//     Console.WriteLine("неверный ввод!");
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// PrintPower(number);

// void PrintPower(int number)
// {
//     Console.WriteLine($"{number} * {number} = {number * number}");

// }
// */
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// number = Math.Abs(number);
// int count = -number;
// while (count <= number)
// {
//     Console.Write(count + " ");
//     count++;
// }
// Console.WriteLine();

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);