//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 1; // Измените значение M здесь
        int n = 15; // Измените значение N здесь

        int sum = CalculateSum(m, n);
        Console.WriteLine(sum);

        Console.ReadLine();
    }

    static int CalculateSum(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }

        return m + CalculateSum(m + 1, n);
    }
}