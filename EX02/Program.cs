// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите значения:");
double b1 = Input("b1 = ");
double k1 = Input("k1 = ");
double b2 = Input("b2 = ");
double k2 = Input("k2 = ");

// y = k1*x + b1 - y - k2*x - b2
// 0 = k1 * x + b1 - k2*x - b2
// b2-b1 = (k1+k2)*x 

if (k1 != k2)
{
double x = (b1-b2) / (k1-k2);
double y = (k2*x+b2);
Console.WriteLine("Точка пересечения двух прямых имеет координаты (x,y): " + x + ", " + y);
}
else Console.WriteLine ("Данные прямые не пересекаются, т.е. - параллельны друг-другу.");

double Input(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}
