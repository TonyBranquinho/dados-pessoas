using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_pessoas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i;
            double maior, menor, soma, media, homens, mulheres;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];
            char[] generos = new char[n];

            for (i = 0; i < n; i++) {
                Console.Write("Altura da " + (i + 1) + "a pessoa: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Genero da " + (i + 1) + "a pessoa: ");
                generos[i] = char.Parse(Console.ReadLine());
            }

            menor = alturas[0];
            for (i = 0; i < n; i++) {//////////////////////// MENOR ALTURA
                if (alturas[i] < menor) {
                    menor = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CI));

            maior = alturas[0];
            for (i = 0; i < n; i++) {/////////////////////// MAIOR ALTURA
                if (alturas[i] > maior) {
                    maior = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CI));

            soma = 0;
            mulheres = 0;
            for (i = 0; i < n; i++) {////////////////////// MEDIA MULHERES
                if (generos[i] == 'f') {
                    soma = soma + alturas[i];
                    mulheres = mulheres + 1;
                }
            }
            media = soma / mulheres;
            Console.WriteLine("Media da altura das mulheres = " + media.ToString("F2", CI));

            homens = n - mulheres;
            Console.WriteLine("Numero de homens = " + homens);
        }
    }
}

        
    

