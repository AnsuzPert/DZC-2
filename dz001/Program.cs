//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5  782 -> 8  918 -> 1
Console.WriteLine("ВВедите трехзначное число ");
int x = Convert.ToInt32(Console.ReadLine());
if ((x/100 < 1)^(x/100 >=10)) Console.WriteLine("Ошибка, введите трехзначное число");
else
{
    x = x%100;
    x = x/10;
    Console.WriteLine($"Вторая цифра числа это {x}");
}