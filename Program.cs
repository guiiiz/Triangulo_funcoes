using System;
using System.Globalization;

namespace Course
{
    public class Triangulo
    {
        public double A { get; set; } // Representa o lado A do triângulo
        public double B { get; set; } // Representa o lado B do triângulo
        public double C { get; set; } // Representa o lado C do triângulo

        public double CalcularArea()
        {
            double p = (A + B + C) / 2.0; // Calcula o semiperímetro do triângulo
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Calcula a área do triângulo usando a fórmula de Heron
            return area; // Retorna a área calculada
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo x = LerTriangulo("X"); // Lê as medidas do triângulo X
            Triangulo y = LerTriangulo("Y"); // Lê as medidas do triângulo Y

            double areaX = x.CalcularArea(); // Calcula a área do triângulo X
            double areaY = y.CalcularArea(); // Calcula a área do triângulo Y

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture)); // Imprime a área do triângulo X com 4 casas decimais
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture)); // Imprime a área do triângulo Y com 4 casas decimais

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X"); // Imprime que o triângulo X tem a maior área
            }
            else
            {
                Console.WriteLine("Maior área: Y"); // Imprime que o triângulo Y tem a maior área
            }
        }

        public static Triangulo LerTriangulo(string nomeTriangulo)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":"); // Solicita ao usuário que entre com as medidas do triângulo
            triangulo.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê e armazena a medida do lado A do triângulo
            triangulo.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê e armazena a medida do lado B do triângulo
            triangulo.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê e armazena a medida do lado C do triângulo
            return triangulo; // Retorna o triângulo com as medidas lidas
        }
    }
}

