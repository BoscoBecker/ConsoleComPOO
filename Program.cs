using Entidade.Triangulo;
using System.Globalization;
// See https://aka.ms/new-console-template for more information

Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X: ");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Entre com as medidas do triângulo Y: ");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x.A + x.B + x.C) / 2.0;
double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
Console.WriteLine("A área do triângulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));

p = (y.A + y.B + y.C) / 2.0;
double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
Console.WriteLine("A área do triângulo y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
  Console.WriteLine("O triângulo com a área maior é :" + areaX);
else
  Console.WriteLine("O triângulo com a área maior é :" + areaY);