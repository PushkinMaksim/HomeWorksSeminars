/*//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Polindrom(int number)
{
    int numberx = number / 1000;
    int numbery = number % 100;
    int number1 = numberx / 10;
    int number2 = numberx % 10;
    int number4 = numbery / 10;
    int number5 = numbery % 10;
    if(number1 == number5 && number2 == number4)
    {
        return true;
    }    
    else
    {
        return false;
    }

}
Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Polindrom(num);
Console.WriteLine(result);
*/

/*Console.Write("Input num: ");
int number = Convert.ToInt32(Console.ReadLine());
*/

/*
//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distance(double numx1, double numy1, double numz1, double numx2, double numy2, double numz2)
{
    double first = numx2 - numx1;
    double squareFirst = Math.Pow(first, 2);
    double second = numy2 - numy1;
    double squareSecond = Math.Pow(second, 2);
    double third = numz2 - numz1;
    double squareThird = Math.Pow(third, 2);
    double segment = squareFirst + squareSecond + squareThird;
    segment = Math.Sqrt(segment);
    return segment;
}

Console.WriteLine("Введите координаты точки A: ");
Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);
*/

/*
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube(int n)
{
    int current = 1;
    while(current <=n)
    {
        Console.Write(current*current*current + " ");
        current ++;
    }
}
Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);
*/
