using System;


public abstract class Pessoa {

    private string nome;
    private string cpf;
    private float salario;

    public string Nome {
        get { return this.nome; }
        set { this.nome = value; }
    }

    public string Cpf {
        get { return this.cpf; }
        set { this.cpf = value; }
    }

    public float Salario {
        get { return this.salario; }
        set { this.salario = value; }
    }

}