// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов мвссива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = new double[m, n];

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // array[i, j] = Math.Round((new Random().Next(-90, 100)* 0.1),2);
            array[i, j] = Math.Round((new Random().NextDouble()*20.0 - 10.0),1);
            Console.Write($"{array[i, j],5}");
        }
        Console.WriteLine();
    }
}

PrintArray(myArray);