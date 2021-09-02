using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos 
       {
        public static void Executar() {
            //Preço com desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;
                            //soma
            double total = preco + imposto;
                                   //operação de subtração e multiplicação
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O Preço final é {0}", totalComDesconto);

            // IMC
            // Divisão
            double peso = 91.2;
            double altura = 1.82;
                                //(altura * altura)
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // Número Par/Impar
            // Operador modulo que é o resto da divisão
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
