// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if(numberA>max) max = numberA; 
if(numberB>max) max = numberB; 

Console.WriteLine($"max = {max}");

