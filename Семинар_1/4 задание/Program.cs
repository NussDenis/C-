/* Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
while(result <= number){
    if(result%2 == 0){
        Console.Write(result +" ");
    }
result++;
}