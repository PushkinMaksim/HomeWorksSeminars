/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Stepen(int a, int b)
{
    int current = 0;
    int proisv = 1;
    while(current < b)
    {
        proisv = proisv * a;
        current ++;
    }
    return proisv;
}
Console.WriteLine("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"result stepen is {Stepen(a, b)}");
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Summe(int a)
{
    int sum = 0;
    while(a > 0)
    {
        int number = a%10;
        sum = sum + number;
        a = a/10;
    }   
    return sum; 
}   
Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"namber {num} result summe is {Summe(num)}");
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);
*/