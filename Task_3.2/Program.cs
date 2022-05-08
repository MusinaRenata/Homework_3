// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

double GetValue(string text)
{
    Console.Write($"{text}: ");
    string getValueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getValueStr);
    return value;
}

double interval(double xa, double ya, double xb, double yb)
{
    return Math.Sqrt((xb - xa) * (xb - xa) + Math.Pow(yb - ya,2));
}

double xa = 3;
double ya = 6;
double xb = 2;
double yb = 1;

double s = interval(xa, ya, xb, yb);

Console.WriteLine(Math.Round(s,2));

