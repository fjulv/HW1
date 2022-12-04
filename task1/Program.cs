// Задача 1: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
string InpNum1 = Console.ReadLine();
double Num1 = Convert.ToDouble(InpNum1);

Console.Write("Введите второе число ");
string InpNum2 = Console.ReadLine();
double Num2 = Convert.ToDouble(InpNum2);

if (Num1 == Num2)
{
    Console.Write("числа равны");
}
else if (Num1 > Num2)
{
    Console.Write("max= " + Num1 + " min= " + Num2);
}
else
{
    Console.Write("max= " + Num2 + " min= " + Num1);
}