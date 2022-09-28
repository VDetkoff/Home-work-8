/*
// Домашняя работа 1 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Random random = new Random();
double [,] arr = new double[rows, colums];
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(minValue, maxValue) + new Random().NextDouble();
        Console.Write(Math.Round(arr[i, j], 1) + ", ");
    }
    Console.Write("\b\b] ");
    Console.WriteLine();
}
Console.WriteLine();
*/

/*
// Домашнее задание 2 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the element string: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter the element column: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
Random random = new Random();
int[,] arr = new int[rows, colums];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(minValue, maxValue + 1);
            Console.Write("{0}, ", arr[i, j]);
        }
        Console.Write("\b\b]");
        Console.WriteLine();
    }
    Console.WriteLine();
if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("The element does not exist");
}
else
{
    Console.WriteLine("Value of the array element = {0}", arr[pos1, pos2]);
}
*/

/*
// Домашняя работа 3 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int[,] arr = new int[rows, colums];
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write("[");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(minValue, maxValue);
        Console.Write(arr[i, j] + ", ");
    }
    Console.Write("\b\b] ");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Arithmetic mean:");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
*/
