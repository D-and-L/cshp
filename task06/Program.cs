// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 2) == 0)
{
     Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}
