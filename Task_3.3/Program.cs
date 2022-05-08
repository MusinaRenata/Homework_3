// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

int GetValue(string text)
{
    Console.Write($"{text}: ");
    string getValueStr = Console.ReadLine()!;
    int value = Convert.ToInt32(getValueStr);
    return value;
}

int Square(int number)
{
    return number * number;
}

int n = GetValue("N");

for (int i = 1; i <= n; i++)
{
    int s = Square(i);
    Console.WriteLine(s);
}
