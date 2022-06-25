using System;
using System.Collections.Generic;


public class Pedido {
    private int numeroPedido;
    private Cliente cliente;
    private List<Jogo> jogos;
    private double valorPedido;

    public int NumeroPedido {
        get { return this.numeroPedido; }
        set { this.numeroPedido = value; }
    }

    public Cliente Cliente {
        get { return this.cliente; }
        set { this.cliente = value; }
    }

    public List<Jogo> Jogos {
        get { return this.jogos; }
        set { this.jogos = value; }
    }

    public double ValorPedido(){
        this.valorPedido = 0;
        foreach (Jogo jogo in this.jogos) {
            this.valorPedido += jogo.Valor;
        }
        return this.valorPedido;
    }

    public void JogoMaisCaro(){
        Jogo jogoMaisCaro = this.jogos[0];
        foreach (Jogo jogo in this.jogos) {
            if (jogo.Valor > jogoMaisCaro.Valor) {
                jogoMaisCaro = jogo;
            }
        }
        Console.WriteLine("Jogo mais caro: " + jogoMaisCaro.Titulo);
    }

    public void ExibirJogosDoCarrinho(){
        foreach (Jogo jogo in this.jogos) {
            Console.WriteLine("Jogo: " + jogo.Titulo + " - Valor: R$" + jogo.Valor);
        }
    }

}