using System;

public class Anuncio
{
	string Nome { get; set; }
	Cliente Cliente { get; set; }
	DateTime DataInicio { get; set; }
	DateTime DataTermino { get; set; }
	decimal InvestimentoPorDia { get; set; }

	// Construtor para criar anúncio, recebe nome, data de início e termino e investimento
	public Anuncio(string nome, cliente Cliente, DateTime dataInicio, DateTime dataTermino, decimal investimentoPorDia)
	{
		this.Nome = nome;
		this.Cliente = Cliente;
		this.DataInicio = dataInicio;
		this.DataTermino = dataTermino;
		this.InvestimentoPorDia = investimentoPorDia;
	}

	
	// Relatório do valor total investido por cliente e data
	valorTotalInvestido(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
    	{

    	}
	
	// Relatório da quantidade máxima de visualizações por cliente e data
	quantidadeMaximaDeVisualizacoes(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
	{

	}
	
	// Relatório da quantidade máxima de cliques por cliente e data
	quantidadeMaximaDeCliques(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
	{

	}
	
	// Relatório da quantidade máxima de compartilhamentos por cliente e data
	quantidadeMaximaDeCompartilhamentos(cliente Cliente, dataInicio DateTime, dataTermino DateTime)
	{

	}
}
