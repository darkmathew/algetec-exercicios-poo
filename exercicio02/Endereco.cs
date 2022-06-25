using System;
using System.Collections.Generic;

public class Endereco {
    private string rua;
    private int numero;
    private string cep;
    private string cidade;

    public string Rua { 
        get { return this.rua; }
        set { this.rua = value; }
    }
    
    public int Numero { 
        get { return this.numero; }
        set { this.numero = value; }
    }

    public string Cep { 
        get { return this.cep; }
        set { this.cep = value; }
    }

    public string Cidade { 
        get { return this.cidade; }
        set { this.cidade = value; }
    }
    
}