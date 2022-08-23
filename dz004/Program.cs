//Сставить программу, которая будет подставлять соответствующую вариацию слова программисты в зависимости от их количества.
Console.WriteLine("Посчитайте прогррамисстов ");
int x= Convert.ToInt32(Console.ReadLine());
if (x%100/(10)==1) Console.WriteLine($"В комнате {x} программистов");
else
    {
    if (x%10==1) Console.WriteLine($"В комнате {x} программист");
    else
    {
        if ((x%10<5)&(x%10!=0)) Console.WriteLine($"В комнате {x} программиста");
        else Console.WriteLine($"В комнате {x} программистов");
    }
    }