// Семинар 6, задание 43
// Найти точку пересечения двух прямых, заданных уравнениями (см. документацию)

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) {
    Console.WriteLine("Прямые параллельны");
 }
 else {
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точки пересечения прямых ({x},{y})");
    }
