// Задача 43: Напишите программу, которая 
// 1)найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2)значения b1, k1, b2 и k2 задаются пользователем.



Console.WriteLine("Введите значение k1");
double numberK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double numberB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double numberK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double numberB2 = Convert.ToInt32(Console.ReadLine());

double x = (numberB2 - numberB1)/ (numberK1 - numberK2);
double y = numberK2 * x + numberB2;

Console.WriteLine($"Точка пересения прямых ({x}, {y})");
