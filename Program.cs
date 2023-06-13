using System;
using System.Globalization;

namespace Course{
    public class Program { //colocando o nome da classe
        public static void Main(string[] args) //abrindo o bloco principal
        {
            double[] medidasX = LerMedidasTriangulo("X"); //colocando a variavel com array e chamando uma função
            double[] medidasY = LerMedidasTriangulo("Y"); //colocando a variavel com array e chamando uma função

            double areaX = CalcularAreaTriangulo(medidasX); //colcoando a variavel e chamando uma função
            double areaY = CalcularAreaTriangulo(medidasY); //colocando a variavel e chamando uma função

            Console.WriteLine("Area de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture)); //imprimindo o resultado da area para o usuario
            Console.WriteLine("Area de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture)); //imprimindo o resultado da area para o usuario

            if (areaX > areaY) // se x for maior
            {
                Console.WriteLine("A area de X é Maior"); //imprimindo para o usuario
            }
            else //se não
            {
                Console.WriteLine("A area de Y é Maior"); //imprimindo para o usuario
            }

        }
        public static double[] LerMedidasTriangulo(string nomemedidas) //colocandoo a função e pedindo uma string
        {
            double[] medidas = new double[3]; //colocando um array

            Console.WriteLine("Entre com a area do triangulo " + nomemedidas); //pedindo para o usuario
            for (int i = 0; i < 3; i++) //enquanto i for menor que 3 faça
            {
                medidas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //o usuario precisa colocar o valor dos arrays
            }
            return medidas; //retorne o valor
        }

        public static double CalcularAreaTriangulo(double[] medidas) //abrindo a função para o calculo pedindo um array
        { 
            double a = medidas[0]; //colcoando as variaveis para o calculo
            double b = medidas[1];  //colocando as variaveis para o calculo
            double c = medidas[2]; //colocando as variaveis para o calculo

            double p = (a + b + c) / 2.0; //calculo
            double area = Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c)); //usando raiz quadrada

            return area; //retorne o resultado
        }
    }
}
