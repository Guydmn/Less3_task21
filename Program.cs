// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите первую координату 1й точки ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату 1й точки ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату 1й точки ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первую координату 2й точки ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату 2й точки ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату 2й точки ");
double z2 = Convert.ToInt32(Console.ReadLine());

double a = x1 - x2;
double b = y1 - y2;
double c = z1 - z2;

double S = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));

Console.Write(S);