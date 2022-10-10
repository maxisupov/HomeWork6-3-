// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
/*if ((x=0) && (x != y))
{
    Console.WriteLine($"Прямые параллельны!");
}*/
// Попытался допилить, но пишет,
// что Оператор "&&" невозможно применить к операнду типа "double" и "bool".
// Моих знаний не хватает))

Console.WriteLine($"Две прямые пересекутся в точке с координатами  ({x}, {y})");
