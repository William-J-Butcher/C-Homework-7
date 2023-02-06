// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> такого числа в массиве нет
// [1,1] -> 9


int[,] myArray = new int[new Random().Next(10), new Random().Next(10)];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
            Console.Write($"{array[i, j],5}");           
        }
        Console.WriteLine();
    }
}

PrintArray(myArray);
Console.Write("Введите номер строки массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца мвссива: ");
int n = Convert.ToInt32(Console.ReadLine());

void Search(int[,] array)
{
    if(m > array.GetLength(0) || n > array.GetLength(1)) Console.WriteLine($"[{m}, {n}] Такого элемента в массиве нет!");
    else Console.WriteLine($"[{m}, {n}] -> {array[m, n]}");
}

Search(myArray);