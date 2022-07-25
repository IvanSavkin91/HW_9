﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\

void Task66()
{
Console.WriteLine("введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp = 0);

void PrintSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum}");
    return;
  }
  PrintSum(m, n - 1, sum);
}

}
Task66();