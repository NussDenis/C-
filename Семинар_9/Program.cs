internal class Program
{
    private static void Main(string[] args)
    {

        void Zadacha64()
        {
            // Задача 64: Задайте значения M и N. Напишите рекурсивный метод,
            // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            // M = 1; N = 9. -> "3, 6, 9"
            // M = 13; N = 20. -> "15, 18"

            Console.Write("Введите начальную точку M: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите начальную точку N: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (b <= 2) Console.WriteLine("Числа кратные 3-ём в промежутке от M до N отсутствуют");
            else Console.Write("Числа кратные 3-ём в промежутке от M до N:  ");
            Recursion64(a, b);
        }

        void Recursion64(int a, int b)
        {
            if (a > b) return;
            if (a % 3 == 0) Console.Write(a + " ");
            a++;
            Recursion64(a, b);
        }


        void Zadacha66()
        {
            // Задача 66: Задайте значения M и N.Напишите рекурсивный метод, который
            // найдёт сумму натуральных элементов в промежутке от M до N.
            // M = 1; N = 15-> 120
            // M = 4; N = 8. -> 30

            Console.Write("Введите значение M: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение N: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Recursion66(a, b);
        }

        void Recursion66(int a, int b, int sum = 0)
        {
            if (a == b + 1)
            {
                Console.WriteLine("Cумма натуральных элементов в промежутке от M до N = " + sum);
                return;
            }
            sum += a;
            a++;
            Recursion66(a, b, sum);
        }


        void Zadacha68()
        {
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
            // Даны два неотрицательных числа m и n.
            // m = 2, n = 3 -> A(m,n) = 9
            // m = 3, n = 2 -> A(m,n) = 29

            int m = 2;
            int n = 3;
            Console.Write(A(m, n));
        }

        int A(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return A(m - 1, 1);
            }
            else
            {
                return A(m - 1, A(m, n - 1));
            }

        }


        Zadacha64();
        // Zadacha66();
        // Zadacha68();
    }

}
