using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos" , Comentarios.Executar },
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferencia - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},

            }) ;

            central.SelecionarEExecutar();
        }
    }
}
