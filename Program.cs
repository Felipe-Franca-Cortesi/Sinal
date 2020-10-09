using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDigitado;
            string textoDigitado;
            bool numeroValido;

            Console.Clear();
            Console.WriteLine("--- Sinal\n");
            
            Console.Write("Digite um número: ");
            textoDigitado = Console.ReadLine();

            numeroValido = Double.TryParse(textoDigitado, out numeroDigitado);
            
            if (!numeroValido)
            {
                Console.WriteLine("Por favor digite somente número(s)");
            }
            else if (numeroDigitado == 0)
            {
                Console.WriteLine("zero");
            }
            else if (numeroDigitado > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if(numeroDigitado < 0)
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}
