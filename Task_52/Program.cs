// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов мвссива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = new int[m, n];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

void Sum(int[,] array)
{
    for (int j = 0; j < n; j++)
    {
        double sumCol = 0;
        for (int i = 0; i < m; i++)
        {
            sumCol += array[i, j];            
        }
        Console.WriteLine($"Среднее арифметическое колонки {j} -> {Math.Round(sumCol / m, 1)}");    
    }
}

PrintArray(myArray);
Sum(myArray);