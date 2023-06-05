using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] medidasX = LerMedidasTriangulo("X"); // Lê as medidas do triângulo X
            double[] medidasY = LerMedidasTriangulo("Y"); // Lê as medidas do triângulo Y

            double areaX = CalcularAreaTriangulo(medidasX); // Calcula a área do triângulo X
            double areaY = CalcularAreaTriangulo(medidasY); // Calcula a área do triângulo Y

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

        public static double[] LerMedidasTriangulo(string nomeTriangulo)
        {
            double[] medidas = new double[3]; // Cria um array para armazenar as medidas do triângulo

            Console.WriteLine("Entre com as medidas do triângulo " + nomeTriangulo + ":"); // Solicita ao usuário que entre com as medidas do triângulo

            for (int i = 0; i < 3; i++)
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê e armazena cada medida no array
            }

            return medidas; // Retorna o array com as medidas lidas
        }

        public static double CalcularAreaTriangulo(double[] medidas)
        {
            double a = medidas[0]; // Atribui a primeira medida ao lado a do triângulo
            double b = medidas[1]; // Atribui a segunda medida ao lado b do triângulo
            double c = medidas[2]; // Atribui a terceira medida ao lado c do triângulo

            double p = (a + b + c) / 2.0; // Calcula o semiperímetro do triângulo
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Calcula a área do triângulo usando a fórmula de Heron

            return area; // Retorna a área calculada
        }
    }
}
