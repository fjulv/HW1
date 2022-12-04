// Задача 3: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число ");
string InpNumber = Console.ReadLine();
double Number = Convert.ToDouble(InpNumber);

if(Number%2==0)
{
    Console.Write("Число " + Number + " является четным");
}

else
{
    Console.Write("Число " + Number + " является нечетным");
}