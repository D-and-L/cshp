// Напишите программу, которая принимает 
// 1. на вход три числа и 
// 2. выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numderD = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if(numberA>max) max = numberA; 
if(numberB>max) max = numberB; 
if(numberD>max) max = numberD; 

Console.WriteLine($"max = {max}");
