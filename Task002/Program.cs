// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите 3 числа: ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberС = int.Parse(Console.ReadLine());

int max = Math.Max(numberA, Math.Max(numberB, numberС));
Console.WriteLine("max = " +max);