// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double GetNum(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double[] CrossPoint(double K1, double B1, double K2, double B2)
{

    double[] point = new double[2];
    double x = Math.Round((B2 - B1) / (K1 - K2), 3);
    point[0] = x;
    point[1] = Math.Round((x * K1 + B1), 3);
    return point;
}

string PrintArray(double[] array)
{
    return "(" + string.Join(", ", array) + ")";
}

double K1 = GetNum("Введите значение K1: ");
double B1 = GetNum("Введите значение B1: ");
double K2 = GetNum("Введите значение K2: ");
double B2 = GetNum("Введите значение B2: ");
if (K1 == K2) 
{
    if (B1 == B2)
    {
        Console.WriteLine("Эти прямые совпадают!");
    }
    else
    {
        Console.WriteLine("Эти прямые не пересекаются!");
    }
}
else
{
double[] crossArray = CrossPoint(K1, B1, K2, B2);
Console.Write($"Координаты точки пересечения прямых: " + PrintArray(crossArray));
}


