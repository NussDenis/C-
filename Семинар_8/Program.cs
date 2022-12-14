internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray(int[,] nums, int minValue, int maxValue)
        {
            maxValue++;
            Random rand = new Random();
            int rows = nums.GetLength(0);
            int columns = nums.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nums[i, j] = rand.Next(minValue, maxValue);
                }
            }
        }
        void FillArray58(int[,] nums)
        {
            int rows = nums.GetLength(0);
            int columns = nums.GetLength(1);
            int N = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nums[i, j] = N;
                    N++;
                }
            }
        }

        void PrintArray(int[,] nums)
        {
            int rows = nums.GetLength(0);
            int columns = nums.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nums[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

        void Zadacha54()
        {
            int rows = 4;
            int columns = 4;
            int[,] numbers = new int[rows, columns];
            FillArray(numbers, 0, 50);
            PrintArray(numbers);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int maxNumber = j;
                    for (int k = j + 1; k < columns; k++)
                    {
                        if (numbers[i, k] > numbers[i, maxNumber])
                        {
                            maxNumber = k;
                        }
                    }
                    int temp = numbers[i, j];
                    numbers[i, j] = numbers[i, maxNumber];
                    numbers[i, maxNumber] = temp;
                }
            }
            PrintArray(numbers);
        }

        // Задача 56. Задайте прямоугольный двумерный массив.
        // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

        void Zadacha56()
        {
            int rows = 5;
            int columns = 10;
            int[,] numbers = new int[rows, columns];
            int[] sumRows = new int[rows];
            int minSumRows = rows - 1;
            FillArray(numbers, 0, 15);
            PrintArray(numbers);
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += numbers[i, j];
                    sumRows[i] = sum;
                }
                Console.WriteLine($"Сумма элементов {i + 1} строки - {sum}");
            }
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                if (sumRows[i] < sumRows[minSumRows]) minSumRows = i;
            }
            Console.WriteLine($"Наименьшая сумма элементов в строке № {minSumRows + 1}");
        }


        // Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.

        // 01 02 03 04
        // 12 13 14 05
        // 11 16 15 06
        // 10 09 08 07

        void Zadacha58()
        {
            int rows = 4;
            int columns = 4;
            int[,] numbers = new int[rows, columns];
            FillArray58(numbers);
            PrintArray(numbers);
            (numbers[1, 0], numbers[1, 3]) = (numbers[1, 3], numbers[1, 0]);
            (numbers[1, 1], numbers[2, 3]) = (numbers[2, 3], numbers[1, 1]);
            (numbers[1, 2], numbers[3, 3]) = (numbers[3, 3], numbers[1, 2]);
            (numbers[1, 0], numbers[3, 2]) = (numbers[3, 2], numbers[1, 0]);
            (numbers[2, 0], numbers[3, 1]) = (numbers[3, 1], numbers[2, 0]);
            (numbers[2, 1], numbers[3, 0]) = (numbers[3, 0], numbers[2, 1]);
            (numbers[2, 2], numbers[2, 0]) = (numbers[2, 0], numbers[2, 2]);
            (numbers[1, 1], numbers[1, 0]) = (numbers[1, 0], numbers[1, 1]);
            (numbers[2, 1], numbers[1, 1]) = (numbers[1, 1], numbers[2, 1]);
            (numbers[2, 2], numbers[1, 2]) = (numbers[1, 2], numbers[2, 2]);
            (numbers[2, 1], numbers[2, 2]) = (numbers[2, 2], numbers[2, 1]);
            PrintArray(numbers);
        }

        // Задача 61: Задайте две матрицы. Напишите 
        // программу, которая будет находить произведение 
        // двух матриц.
        void Zadacha61()
        {
            int rows1 = 2;
            int columns1 = 3;
            int[,] numbers1 = new int[rows1, columns1];
            FillArray(numbers1, -10, 15);
            Console.WriteLine("Матрица А");
            PrintArray(numbers1);
            Console.WriteLine();
            Console.WriteLine("Матрица  B");
            int rows2 = 3;
            int columns2 = 3;
            int[,] numbers2 = new int[rows2, columns2];
            FillArray(numbers2, -10, 15);
            PrintArray(numbers2);


        }
        // Zadacha54();
        // Zadacha56();
        // Zadacha58();
        Zadacha61();
    }
}
