// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа от {m} до {n}:");
        PrintNaturalNumbers(m, n);

        Console.ReadLine(); // Ждем, чтобы консольное окно не закрылось сразу
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNaturalNumbers(start + 1, end);
        }
    }
}

