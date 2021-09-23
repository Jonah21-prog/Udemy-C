using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Estudo Básico do C# aqui:
            Console.Write("Hello World");
            Console.ReadLine(); // Espera que o usuário digite uma tecla para fechar a execução

            var cor_favorita = "Vermelho"; // forma preguiçosa de declarar um type

            dynamic carro = "Wolks"; // Variavel dinamica, pois o seu tipo pode mudar

            const float PI = 3.14f; // Conts deixa a varavel constante, não é possível mudar seu tipo dps

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);
            Console.ReadLine();
            // Função para receber dados do usuário 

           
        }
        static void  valor(String[] args)
        {
            // GerarPreco(60); //Chamei a função GerarPreco e declarei o seu valor aqui
            string valor = Console.ReadLine();
            Console.WriteLine(valor); // Exemplo de retorno
            Console.ReadLine();

            string[] produtos = new string[4]//Exemplo de Array
            {
                "banana", // 0
                "Maçã", // 01
                "Abacaxi", // 02
                "Melão" // 03
            };
            Console.WriteLine(produtos[0]);
        }
        static void Exibirmsg()
        {
            Console.WriteLine("Escrevi aqui uma função");
            Console.WriteLine("Funções são bem úteis pelo visto");
        }

        static void GerarPreco(int preco) // Passei um parâmetro para a minha função ( ele só existe dentro dessa minha função)
        {
            // Variáveis criadas dentro de uma função, só podem ser acessadas dentro da função
            Console.WriteLine(preco);
        }

        static void condicao()
        {
            // Etrutura condicional 
            if (10 > 2)
            {
                Console.WriteLine("É verdade");
            }
            else if (10 == 10) // Posso ter quantos quiser e deve aparecer sempre antes do Else
            {
                Console.WriteLine("Excecutou o Else If");
            }
            else
            {
                Console.WriteLine("É mentira");
            }
            Console.ReadLine();

            // && (E / And) -- || (Ou/Or)



            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine()); //.Parse transforma a string em Int 

            if (idade > 0 && idade < 11)
            {
                Console.WriteLine("Você é uma criança");
            }
            else if (idade > 11 && idade < 18)
            {
                Console.WriteLine("Você é um adolescente");
            }
            else
            {
                Console.WriteLine("Você é um adulto");
            }
            Console.ReadLine();

            // Posso ainda usar o Switch ( que trabalha apenas com == mas deixa o código mais limpo)
            string cor = "Azul";
            switch (cor) // Não consigo trabalhar com valores comparacionais 
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;
                case "Verde":
                    Console.WriteLine("Sua cor favorita é Verde!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amearelo!");
                    break;
                default: // Equeivalente a "esle"
                    Console.WriteLine("Sua cor favorita eu não sei");
                    break;
            }

            int contador = 0;
            while (contador < 10) //Enquanto for verdade... 
            {
                Console.WriteLine("Rodando o While!");
                contador = contador + 1;
            }
            Console.WriteLine("Fim da Linha");
            Console.ReadLine();

            for (int conta = 0; conta < 10; conta++) //Mais prático para trabalhar com Arrays, mesma coisa do While
            {
                Console.WriteLine("For rodando");
            }
        }
    }
}
