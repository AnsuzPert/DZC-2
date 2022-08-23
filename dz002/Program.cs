//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
if (x>99)
{
    while (x>99)
    {
        if (x/100<10) 
        {Console.WriteLine($"Третья цифра {x%10}");
        x = x/10;
        }
        else x = x/10;
    }
}
else Console.WriteLine("Третьей цифры нет");