
using System;
using System.Collections.Generic;


namespace exercicio02
{
    class Program
    {
        static void Main()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Alan Tiringa";
            cliente.Cpf = "123.456.789-00";
            cliente.Idade = 46;
            
            cliente.Endereco = new Endereco();
            cliente.Endereco.Rua = "Rua sem fim";
            cliente.Endereco.Numero = 568;
            cliente.Endereco.Cep = "12345-678";
            cliente.Endereco.Cidade = "Salvador";
                        
            Jogo jogo1 = new Jogo();
            jogo1.Titulo = "PUBG";
            jogo1.Valor = 35;
            jogo1.Genero = "Battle Royale";

            Jogo jogo2 = new Jogo();
            jogo2.Titulo = "Fifa 22";
            jogo2.Valor = 50;
            jogo2.Genero = "Futebol";

            Jogo jogo3 = new Jogo();
            jogo3.Titulo = "Call of Duty Modern Warfare";
            jogo3.Valor = 60;
            jogo3.Genero = "FPS";

            Pedido pedido = new Pedido();
            pedido.NumeroPedido = 1;
            pedido.Cliente = cliente;
            pedido.Jogos = new List<Jogo>();
            pedido.Jogos.Add(jogo1);
            pedido.Jogos.Add(jogo2);
            pedido.Jogos.Add(jogo3);

            Console.WriteLine("Pedido: " + pedido.NumeroPedido);
            Console.WriteLine("Cliente: " + pedido.Cliente.Nome);
            Console.WriteLine("Nome: " +  pedido.Cliente.Nome);
            Console.WriteLine("CPF: " +  pedido.Cliente.Cpf);
            Console.WriteLine("Idade: " +  pedido.Cliente.Idade);
            Console.WriteLine("Endereço: " +  pedido.Cliente.Endereco.Rua + ", " +  pedido.Cliente.Endereco.Numero + ", " +  pedido.Cliente.Endereco.Cep + ", " +  pedido.Cliente.Endereco.Cidade);            

            pedido.ExibirJogosDoCarrinho();

            double valorTotalPedido = pedido.ValorPedido();
            Console.WriteLine("Valor total do pedido: R$" + valorTotalPedido);

            pedido.JogoMaisCaro();

        }
    }
}