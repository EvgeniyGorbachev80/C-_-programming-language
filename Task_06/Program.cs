﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter the number: ");
int a = int.Parse(Console.ReadLine()!);

if (a%2 == 0)
{
  Console.WriteLine("Yes. Entered number is even");
    
}
else
{
  Console.WriteLine("No. Entered number is odd"); 
}