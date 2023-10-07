// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int EnterParam(string msg)
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out var number))
    {
        Console.Write("Ошибка ввода!");
        Environment.Exit(0);
    }
    return number;
}

void IntersectionPoint(int k1, int b1, int k2, int b2)
{
    if (k1 != k2)
    {
        double x = (double)(b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.Write($"Точка пересечения прямых: x = {x}, y = {y}");
    }
    else Console.WriteLine("Эти прямые не пересекаются!");
}

Console.WriteLine("Задайте параметры уравнения для первой прямой:");
int k1 = EnterParam($"Введите коэффициент k1 для первой прямой: ");
int b1 = EnterParam($"Введите коэффициент b1 для первой прямой: ");
Console.WriteLine("");
Console.WriteLine("Задайте параметры уравнения для второй прямой:");
int k2 = EnterParam($"Введите коэффициент k2 для второй прямой: ");
int b2 = EnterParam($"Введите коэффициент b2 для второй прямой: ");

IntersectionPoint(k1, b1, k2, b2);