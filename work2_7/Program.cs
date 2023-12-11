// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// A(m, n) = n + 1, если m = 0
// A(m, n) = A(m - 1, 1), если m > 0 и n = 0
// A(m, n) = A(m - 1, A(m, n - 1)), если m > 0 и n > 0

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine()!);
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Результат: {Ackermann(m, n)}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

