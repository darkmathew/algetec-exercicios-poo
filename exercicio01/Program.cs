using System;
using System.Collections.Generic;

namespace exercicio01
{
    class Program
    {
        static void Main()
        {
            
            Jogador jogador1 = new Jogador();
            Jogador jogador2 = new Jogador();
            Jogador jogador3 = new Jogador();
            Jogador jogador4 = new Jogador();
            Jogador jogador5 = new Jogador();

            jogador1.Nome = "Hugo Rodallega";
            jogador1.Cpf = "123.456.789-00";
            jogador1.Salario = 9000;
            jogador1.Posicao = "Atacante";
            jogador1.NumeroCamisa = 13;

            jogador2.Nome = "Lucas Mugni";
            jogador2.Cpf = "627.174.8261-00";
            jogador2.Salario = 2000;
            jogador2.Posicao = "Meio-campo";
            jogador2.NumeroCamisa = 19;

            jogador3.Nome = "Danielzinho";
            jogador3.Cpf = "932.897.628-00";
            jogador3.Salario = 3200;
            jogador3.Posicao = "Meio-campo";
            jogador3.NumeroCamisa = 10;

            jogador4.Nome = "Douglas Borel";
            jogador4.Cpf = "982.234.089-00";
            jogador4.Salario = 1500;
            jogador4.Posicao = "Lateral";
            jogador4.NumeroCamisa = 2;

            jogador5.Nome = "Danilo Fernandes";
            jogador5.Cpf = "679.424.689-00";
            jogador5.Salario = 7800;
            jogador5.Posicao = "Goleiro";
            jogador5.NumeroCamisa = 1;

            Treinador treinador = new Treinador();
            treinador.Nome = "Guto Ferreira";
            treinador.Cpf = "987.654.321-00";
            treinador.Salario = 6000;
            treinador.LicencaCBF = "CBF PRO";   
            treinador.AnosExperiencia = 20;

            Clube clube = new Clube();
            clube.Nome = "EC Bahia";
            clube.Treinador = treinador;

            clube.Jogadores = new List<Jogador>();
            clube.Jogadores.Add(jogador1);
            clube.Jogadores.Add(jogador2);
            clube.Jogadores.Add(jogador3);
            clube.Jogadores.Add(jogador4);
            clube.Jogadores.Add(jogador5);


            float folhaSalarialClube = clube.CalculoFolhaPagamento();

            Console.WriteLine("Clube: "+ clube.Nome);
            Console.WriteLine("Treinador: " + treinador.Nome);
            
            clube.MostrarPlantel();
        
            Console.WriteLine("Folha Salarial do Clube: R$ " + folhaSalarialClube);

            float menorSalario = clube.VerificarMenorSalario();
            float maiorSalario = clube.VerificarMaiorSalario();

            Console.WriteLine("Menor salário do clube: R$ "+ menorSalario);
            Console.WriteLine("Maior salário do clube:  R$ "+ maiorSalario);

        }
    }
}
