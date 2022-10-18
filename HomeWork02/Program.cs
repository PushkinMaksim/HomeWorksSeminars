/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int CutNumber(int number)
{
    int n1 = number/10;
    int n2 = n1%10;
    return n2;
}
int num = new Random().Next(100, 1000);
int result = CutNumber(num);
Console.WriteLine($"Вторая цыфра числа: {num} = {result}");
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int CutNumber( int number)
{
    while(number > 100 & number < 1000)
    {
        number = number / 10;
    }
    return number;
}

int num = new Random().Next(1000, 10000);
int result = CutNumber(num);
int first= result%10;
Console.WriteLine(num);
Console.WriteLine(result);
Console.WriteLine(first);

if(num < 100)
{
    Console.WriteLine("Третьей цыфры нет");

}

