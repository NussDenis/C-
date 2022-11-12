/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("Введите любое число");
int result = Convert.ToInt32(Console.ReadLine());
if(result%2 == 0){
    Console.WriteLine("Вы ввели чётное число");
}
else{
    Console.WriteLine("Вы ввели нечётное число");
}