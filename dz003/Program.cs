//Задача15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.WriteLine("ВВедите номер дня недели");
int x = Convert.ToInt32(Console.ReadLine());
if (x<1^x>7) Console.WriteLine("Ошибка, число должно быть от 1 до 7");
else
{
    if (x>5) Console.WriteLine("Сейчас выходной");
    else Console.WriteLine("Сейчас будний день");
}