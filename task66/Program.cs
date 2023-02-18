// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("--> M ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("--> N ");
int n = Convert.ToInt32(Console.ReadLine());

int NumSum(int m, int n)
{
if (m == n)
return n;
return n + NumSum(m, n - 1);
}

Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {NumSum(m, n)}");
