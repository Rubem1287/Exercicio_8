using System;
using System.Globalization;
namespace Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, menor, maior, media, f, m;
            soma = 0;
            menor = 0;
            maior = 0;
            media = 0;
            f = 0;
            m = 0;
            double[] altura;
            char[] genero;

            int n = int.Parse(Console.ReadLine());

            altura = new double[n];
            genero = new char[n];

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                genero[i] = char.Parse(vetor[1]);

                if (genero[i] == 'F')
                {
                    soma += altura[i];
                    f++;
                }
                else
                {
                    m++;
                }

                if (menor == 0)
                {
                    menor = altura[i];
                }
                else if (menor > altura[i])
                {
                    menor = altura[i];
                }

                if (maior == 0)
                {
                    maior = altura[i];
                }
                else if (maior < altura[i])
                {
                    maior = altura[i];
                }

            }

            media = soma / f;

            Console.WriteLine();
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Altura média das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Numero de Homens = " + m);
        }
    }
}
