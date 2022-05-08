// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();

double GetValue(string text)
{
    Console.Write($"{text}: ");
    string getValueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getValueStr);
    return value;
}

double x = GetValue("Введите x");
double y = GetValue("Введите y");

    if (x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть плоскости");
    }
    
    if (x > 0 && y < 0)
    {
        Console.WriteLine("4 четверть плоскости");
    }
   
     if (x < 0 && y > 0) 
    {
        Console.WriteLine("2 четверть плоскости");
    }

    if (x < 0 && y < 0) 
    {
        Console.WriteLine("3 четверть плоскости");
    }
