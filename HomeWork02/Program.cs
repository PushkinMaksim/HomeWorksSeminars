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



/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int CutNumber( int number)
{
    while(number >= 1000)
    {
        number = number/10;
    }
return number;
}

int num = new Random().Next(1555, 10000);

if(num < 100)
{
    Console.WriteLine("Третьей цыфры нет");
}
int result = CutNumber(num);
int first= result%10;
Console.WriteLine($"случайное число {num}");
Console.WriteLine($"трех значное число {result}");
Console.WriteLine($"третье число {first}");
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool Week(int number)
{
    if(number == 6 ||number == 7)
    {
    return true;
    }
    else
    {
        return false;
    }
}

int num = new Random().Next(1, 8);
bool result = Week(num);
Console.WriteLine($"День недели: {num}");
Console.WriteLine(result);
*/

/*
Console.Write("Введите число number: ");
int num = Convert.ToInt32(Console.ReadLine());

    while(num >= 1000)
    {
        num = num/10;
    }
 Console.WriteLine(num);
 */
