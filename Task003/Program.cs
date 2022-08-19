// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

if(numberA % 2 == 0)
{
    System.Console.WriteLine("ДА, число делится на 2 без остатка!");
}
else
{
    System.Console.WriteLine("НЕТ, число не делится на 2 без остатка!");
}


