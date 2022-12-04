// Задача 2: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число ");
string InpA = Console.ReadLine();
double A = Convert.ToDouble(InpA);

Console.Write("Введите второе число ");
string InpB = Console.ReadLine();
double B = Convert.ToDouble(InpB);

Console.Write("Введите третье число ");
string InpC = Console.ReadLine();
double C = Convert.ToDouble(InpC);

double max = A;

if(B > max)
{
    max = B;
}
if(C > max)
{
    max = C;
}

Console.Write("Максимальное число = " + max);