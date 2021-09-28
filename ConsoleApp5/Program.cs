using System;
string figure; double a; double b; double h; double area; double r;

Console.WriteLine("figure: ");
figure = Console.ReadLine();
if (figure == "trapezoid")
{
    Console.Write("a = ");
    a = double.Parse(Console.ReadLine());
    Console.Write("b = ");
    b = double.Parse(Console.ReadLine());
    Console.Write("h = ");
    h = double.Parse(Console.ReadLine());
    area = ((a + b) / 2) * h;
    Console.WriteLine(area);
    Console.ReadLine();
}
else if (figure == "rectangle")
{
    Console.Write("a = ");
    a = double.Parse(Console.ReadLine());
    Console.Write("b = ");
    b = double.Parse(Console.ReadLine());
    area = a * b;
    Console.WriteLine(area);
    Console.ReadLine();
}
else if (figure == "circle")
{
    Console.Write("r = ");
    r = double.Parse(Console.ReadLine());
    double sqr = Math.Pow(r, 2);
    area = sqr * Math.PI;
    Console.WriteLine(area);
    Console.ReadLine();
}
else
{
    Console.WriteLine("Not supported figure");
    Console.ReadLine();
}