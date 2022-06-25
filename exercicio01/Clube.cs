using System;
using System.Collections.Generic;

public class Clube {

    private string nome;
    private Treinador treinador;
    private List<Jogador> jogadores;
    private float custoSalario;

    public string Nome {
        get { return this.nome; }
        set { this.nome = value; }
    }

    public Treinador Treinador {
        get { return this.treinador; }
        set { this.treinador = value; }
    }

    public List<Jogador> Jogadores {
        get { return this.jogadores; }
        set { this.jogadores = value; }
    }

    public float CalculoFolhaPagamento() {
        
        this.custoSalario = 0;
        
        foreach (Jogador jogador in this.jogadores) {
            this.custoSalario += jogador.Salario;
        }                
        this.custoSalario = this.custoSalario + this.treinador.Salario;
        return this.custoSalario;
    }

    public float VerificarMaiorSalario(){
        
        float maiorSalario = 0;
        
        foreach (Jogador jogador in this.jogadores) {
            if (jogador.Salario > maiorSalario) {
                maiorSalario = jogador.Salario;
            }
        }
        return maiorSalario;
    }

    public float VerificarMenorSalario(){
        
        float menorSalario = this.jogadores[0].Salario;
        
        foreach (Jogador jogador in this.jogadores) {
            if (jogador.Salario < menorSalario) {
                menorSalario = jogador.Salario;
            }
        }
        return menorSalario;
    }

    public void MostrarPlantel() {

        foreach (Jogador jogador in this.jogadores) {
            Console.WriteLine("Jogador: " + jogador.Nome + " - " + "( n° "+ jogador.NumeroCamisa + " ) " + jogador.Posicao + " - R$ " + jogador.Salario);
        }
    }

}
