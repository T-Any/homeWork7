// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Массив в обратном порядке:");
        PrintArrayReverse(arr, 0);
    }

    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < arr.Length)
        {
            PrintArrayReverse(arr, index + 1);
            Console.Write(arr[index] + " ");
        }
    }
}
