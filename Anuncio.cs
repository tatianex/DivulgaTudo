using System;

public class Anuncio
{
	string Nome { get; set; }
	Cliente Cliente { get; set; }
	DateTime DataInicio { get; set; }
	DateTime DataTermino { get; set; }
	decimal InvestimentoPorDia { get; set; }

	public Anuncio(string nome, cliente Cliente, DateTime dataInicio, DateTime dataTermino, decimal investimentoPorDia)
	{
		this.Nome = nome;
		this.Cliente = Cliente;
		this.DataInicio = dataInicio;
		this.DataTermino = dataTermino;
		this.InvestimentoPorDia = investimentoPorDia;
	}

	valorTotalInvestido(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
    {

    }
	quantidadeMaximaDeVisualizacoes(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
	{

	}
	quantidadeMaximaDeCliques(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
	{

	}
	quantidadeMaximaDeCompartilhamentos(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
	{

	}
}
