// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter the number: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number: ");
int b = int.Parse(Console.ReadLine()!);
 
int max = a; int min = a;

if (b > max) max = b;  
{
  Console.Write("max =  ");
  Console.WriteLine(max); 
}
if (b < min) min = b;
{
  Console.Write("min =  ");
  Console.WriteLine(min);
}
