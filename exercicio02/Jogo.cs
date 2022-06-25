using System;
using System.Collections.Generic;

public class Jogo
{
    private string titulo;
    private double valor;
    private string genero;

    public string Titulo
    {
        get{ return this.titulo; }
        set{ this.titulo = value; }
    }

    public double Valor
    {
        get{ return this.valor; }
        set{ this.valor = value; }
    }

    public string Genero
    {
        get{ return this.genero; }
        set{ this.genero = value; }
    }

}