﻿using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;

            //Formata o valor numerico
            Console.WriteLine(valor.ToString("F1"));

            //coloca em valor monetario
            Console.WriteLine(valor.ToString("C"));

            //Valor em Percentual
            Console.WriteLine(valor.ToString("P"));

            //Coloca o valor com casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            //Formatação para país que eu definir
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            //D10 = 0 a esquerda.
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
