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


/*
// Домашняя работа 5 Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Write("Input numbers: ");
int num = Convert.ToInt32(Console.ReadLine());

int[,] spiralNumbers = new int[num, num];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralNumbers.GetLength(0) * spiralNumbers.GetLength(1))
{
  spiralNumbers[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralNumbers.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralNumbers.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralNumbers.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralNumbers);

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] / 10 <= 0)
      Console.Write($" {array[i, j]} ");

      else Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
*/


/*
// Домашняя работа 1 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, col];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Initially:");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
  for (int j = 0; j < numbers.GetLength(1) - 1; j++)
  {
    if (numbers[i, j] < numbers[i, j + 1])
    {
      int temp = 0;
      temp = numbers[i, j];
      numbers[i, j] = numbers[i, j + 1];
      numbers[i, j + 1] = temp;
    }
  }
}
Console.WriteLine();
Console.WriteLine("Sorting done:");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = new Random().Next(minValue, maxValue);
      }
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write(array[i, j] + ", ");
      }
    Console.Write("\b\b] ");
    Console.WriteLine("");
  }
}
*/


/*
// Домашняя работа 2 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of colums: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] table = new int[rows, col];


void NumberRowMinSumElements(int[,] array)
{
    int minRows = 0;
    int minSumRows = 0;
    int sumRows = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRows += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRows += table[i, j];
        if (sumRows < minRows)
        {
            minRows = sumRows;
            minSumRows = i;
        }
        sumRows = 0;
    }
    Console.Write($"Row with minimum value {minSumRows + 1}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.Write("\b\b] ");
        Console.WriteLine();
    }
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}

FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);
*/