/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите 3 любых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = b;
int min = c;
if(a > max){
    max = a;
    min = b;
}
else{
    max = b;
    min = a;
}
if(c > max)
{
    max = c;
}
else if(c < min){
    min = c;
}
Console.WriteLine($"{max} = max");
Console.WriteLine($"{min} = min");