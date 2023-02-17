// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositive(double[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result += 1;
        }
    }
    return result;
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите {M} чисел: ");
double[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);


Console.WriteLine($"Количество положительных чисел: {CountPositive(numbers)}");


