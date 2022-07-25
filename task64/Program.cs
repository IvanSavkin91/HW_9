// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.

void Task64()
{

Console.WriteLine("введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
AllNumber(m, n);

void AllNumber(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 3 == 0)
    {
        Console.Write(m + "\t");
    }
    m++;
    AllNumber(m, n);

}
}
Task64();