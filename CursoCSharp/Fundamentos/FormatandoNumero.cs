using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero 
     {
        public static void Executar(){
            double valor = 15.175;

            //Formata o valor numerico
            Console.WriteLine(valor.ToString("F1"));

            //coloca em valor monetario
            Console.WriteLine(valor.ToString("C"));

            //Valor em Percentual
            Console.WriteLine(valor.ToString("P"));

            //Coloca o valor com casas decimais
            Console.WriteLine(valor.ToString("#.##"));

        }
    }
}
