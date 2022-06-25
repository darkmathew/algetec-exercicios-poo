using System;


public class Jogador : Pessoa {

    private string posicao;
    private int numeroCamisa;

    public string Posicao {
        get { return this.posicao; }
        set { this.posicao = value; }
    }

    public int NumeroCamisa {
        get { return this.numeroCamisa; }
        set { this.numeroCamisa = value; }
    }	

}