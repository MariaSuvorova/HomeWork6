/* Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод!");
        }
    }
    return resultNumber;
}

(double, double) IntersectionPoint(int k1, int b1, int k2, int b2)
{
    double x = (double)(b2-b1)/(k1-k2);
    double y = (double)(k2*x + b2);
    return (x, y);
}

int k1 = GetNumber("Введите параметр k1 уравнения y = k1 * x + b1");
int b1 = GetNumber("Введите параметр b1 уравнения y = k1 * x + b1");
int k2 = GetNumber("Введите параметр k2 уравнения y = k2 * x + b2");
int b2 = GetNumber("Введите параметр b2 уравнения y = k2 * x + b2");

(double x, double y) = IntersectionPoint(k1, b1, k2, b2);
Console.WriteLine($"точка пересечения имеет координаты ({x};{y})");