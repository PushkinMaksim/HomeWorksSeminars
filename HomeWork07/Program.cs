//Урок 7. Как не нужно писать код. Часть 1
/*
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//Объявление массива

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)         //переход по строкам
    {
        for(int j = 0; j < columns; j++)  //переход по столбцам
        {
            array[i, j] = new Random().Next(minValue, maxValue); //замена целочисленных элементов на вещественные
            double num1 = new Random().NextDouble();
            double num2 = Math.Round(num1, 1);
            array[i, j] = array[i, j] + num2;
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
*/

/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Генерация двухмерного массива случ числами

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)         //переход по строкам
    {
        for(int j = 0; j < columns; j++)  //переход по столбцам
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine();
Show2dArray(myArray);

void Element(int [,] array, int g, int k)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(g == i && k == j) Console.Write($"element value: {array[i, j]}");
if(g > array.GetLength(0) || k > array.GetLength(1))
                Console.WriteLine("No element");
}

Console.WriteLine();
Console.Write("Input index rows i: ");
int g = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index columns j: ");
int k = Convert.ToInt32(Console.ReadLine());
Element(myArray, g, k);
*/

/*
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)         
    {
        for(int j = 0; j < columns; j++)  
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possible: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possible: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

double[,] ArithmeticMean(int[,] array)
{
    double[,] newArray = new double[array.GetLength(1), array.GetLength(0)];
    double result = 0;
    int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i, j];
                result = sum / array.GetLength(0);
            } 
            Console.Write(result + " ");
            sum = 0;
            result = 0;
        }
    return newArray;       
}

Console.WriteLine();
ArithmeticMean(myArray);
*/