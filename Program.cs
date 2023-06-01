// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] result = new int[rows, columns];

void GetArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}
// Метод для вывода массива на экран
void PrintArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Сортируем каждую строку массива в порядке убывания
void ChangeRows()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = j + 1; k < result.GetLength(1); k++)
            {
                if (result[i, j] < result[i, k])
                {
                    int temp = result[i, j];
                    result[i, j] = result[i, k];
                    result[i, k] = temp;
                }
            }
        }
    }
}
GetArray();
// Выводим отсортированный массив на экран
Console.WriteLine("Исходный массив:");
PrintArray();
ChangeRows();
// Выводим отсортированный массив на экран
Console.WriteLine("Отсортированный массив:");
PrintArray();
 
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int columns = rows;
int[,] result = new int[rows, columns];

void Getresult()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}
// Метод для вывода массива на экран
void Printresult()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод для нахождения строки с наименьшей суммой элементов
void SumRows()
{
    int minSumIndex = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            sum += result[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumIndex = i;
        }
    }

    // Выводим результат на экран
    Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumIndex + 1));
}
Getresult();
Console.WriteLine("Исходный массив:");
Printresult();
SumRows();


 
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[n, n];
int[,] array2 = new int[n, n];
int[,] result = new int[n, n];
// Заполняем рандомными числами массив№1
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        array1[i, j] = new Random().Next(0, 10);
    }
}
// Выводим заполненный массив №1
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(array1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
// Заполняем рандомными числами массив№2
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(0, 10);
    }
}
// Выводим заполненный массив №2
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(array2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
//  Находим произведение массивов
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            result[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
// Выводим заполненный результирующий массив
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}

 
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int columns = rows;

int pages = rows;

// int[,] result = new int[rows, columns];

// Объявляем трёхмерный массив
int[,,] array = new int[rows, columns, pages];

// Заполняем массив неповторяющимися двузначными числами
int number = 10;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = number++;
        }
    }
}

// Выводим массив построчно, добавляя индексы каждого элемента
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i, j, k]}[{i}, {j}, {k}] ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



