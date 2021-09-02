using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes
     {
        public static void Executar() {

            //conversão implicita = quando não ha perigo de haver perda de informação.
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //nota truncada = ele tira as casas decimais
            //conversão numerica explicita = usando cast = quando ha possibilidade de perder informação
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("nota truncada: {0}", notaTruncada);

            //conversão de string para numero
            Console.WriteLine("Digite sua idade:  ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade Inserida: {0}", idadeInteiro);

            //Outra possibilidade e usando a classe convert
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            //Forma mais segura de fazer conversão de string para valor inteiro
            Console.Write("Digite o primeiro numero:");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado1: {0}", numero1);

            Console.WriteLine("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado: {0}", numero2);






        }
    }
}
