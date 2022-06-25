using System;
using System.Collections.Generic;

public class Cliente {

    private string nome;
    private string cpf;
    private int idade;
    private Endereco endereco;

    public string Nome {
        get { return this.nome; }
        set { this.nome = value; }
    }

    public string Cpf {
        get { return this.cpf; }
        set { this.cpf = value; }
    }

    public int Idade {
        get { return this.idade; }
        set { this.idade = value; }
    }

    public Endereco Endereco {
        get { return this.endereco; }
        set { this.endereco = value; }
    }

}