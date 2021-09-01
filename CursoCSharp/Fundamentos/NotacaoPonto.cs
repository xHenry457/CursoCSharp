using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos 
 {
    class NotacaoPonto 
     {
        // ToUpper = palavra em maiúscula
        // Replace = Trocar a palavra
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            // nil = nulo delphin
            // Length = Quantidade de caracteres na string
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);

            //NotacaoPonto = Encadear varias chamadas uma atras da outra para fazer algum tipo de operação.
            // NotacaoPonto = Ter Acesso a varias funcionalidades, nesse caso da string ou de um valor numerico
            // ou mesmo de algo que você queira(data) ou crie (ex: quero criar um produto,
            // quero que o produto tenha uma funcionalidade ou tenha um atributo ou preço ou nome do produto,
            // eu quero q ele calcule o preço com desconto com o percentual de desconto que eu venha dar).
            

        }
    }
}
