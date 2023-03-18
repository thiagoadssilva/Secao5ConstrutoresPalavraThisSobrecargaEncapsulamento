using System;

namespace ExercicioTreinamento01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clientes Pessoa1;            
            Produtos Produto1;
            Pedidos Pedido1;

            Pessoa1 = new Clientes();
            Produto1 = new Produtos();
            Pedido1 = new Pedidos();

            // ************BLOCO CLIENTE*****************//

            Console.WriteLine("Olá vamos treinar programação");
            Console.WriteLine("*****************************");

            Console.WriteLine("Por favor informe seu Id");
            Pessoa1.Id= int.Parse(Console.ReadLine());
            
            Console.WriteLine("Por favor informe seu Nome");
            Pessoa1.Nome = Console.ReadLine();           

            Console.WriteLine("Por favor informe seu Telefone");
            Pessoa1.Telefone = Console.ReadLine();

            Console.WriteLine("Por favor informe sua Rua");
            Pessoa1.Rua = Console.ReadLine();

            Console.WriteLine("Por favor informe seu Bairro");
            Pessoa1.Bairro = Console.ReadLine();

            Console.WriteLine("Por favor informe um Ponto de Referência");
            Pessoa1.PontoReferencia = Console.ReadLine();

            // ************BLOCO PRODUTO*****************//

            Console.WriteLine("Informe o id do Produto");
            Produto1.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do Produto");
            Produto1.Nome = Console.ReadLine();

            Console.WriteLine("Informe o valor do Produto");
            Produto1.Valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do quantidadeProduto");
            Produto1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o id do Produto");
            Produto1.Descricao = Console.ReadLine();

            // ************BLOCO PEDIDO*****************//

            Console.WriteLine("Informe o numero do pedido:");
            Pedido1.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero do produto:");
            Pedido1.FkProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero do cliente:");
            Pedido1.FkCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o numero do forma de pagamento:");
            Pedido1.FormaPagamento = Console.ReadLine();

            Console.WriteLine("Informe o numero do forma de troco:");
            Pedido1.Troco = Console.ReadLine();

            // ************BLOCO MENSAGEM*****************//

            Console.WriteLine(Pessoa1.mesagem() 
                + Produto1.mesagem()
                + Pedido1.mensagem());

         
        }
    }
}