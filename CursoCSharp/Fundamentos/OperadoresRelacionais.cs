﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {

            //double nota = 6.0;
            Console.WriteLine("Digite a nota");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota Inválida? {0} ",nota > 10.0);
            Console.WriteLine("Nota Invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhora? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado {0}", nota <= 3.0);


        }
    }
}
