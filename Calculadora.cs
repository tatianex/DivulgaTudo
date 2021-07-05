using System;

namespace CalculadoraDeAlcanceDeAnunciosOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            // a cada 100 pessoas que visualizam o anúncio 12 clicam nele.
            // 12 / 100 = 0.12
            var taxaDeCliques = 0.12;

            // a cada 20 pessoas que clicam no anúncio 3 compartilham nas redes sociais.
            // 3 / 20 = 0.15
            var taxaDeCompartilhamento = 0.15;

            // cada compartilhamento nas redes sociais gera 40 novas visualizações.
            var taxaDeNovasVisualizacoesPorCompartilhamento = 40;

            // 30 pessoas visualizam o anúncio original (não compartilhado) a cada R$ 1,00 investido.
            var numPessoasQueVisualizamAnuncioOriginal = 30;

            // o mesmo anúncio é compartilhado no máximo 4 vezes em sequência
            var quantidadeMaxCompartilhamento = 4;


            Console.WriteLine("Por favor informe o valor que deseja investir: ");
            var valorInvestido = Convert.ToInt32(Console.ReadLine()); // Considerando valor inicial de R$300,00
            var projecaoAnunciosOriginal = valorInvestido * numPessoasQueVisualizamAnuncioOriginal;
            // O que gera um alcance de 9000 pessoas/visualizações do anúncio original
            
            var projecaoCliques = projecaoAnunciosOriginal * taxaDeCliques; // 1080 cliques
            
            var projecaoCompartilhamentos = projecaoCliques * taxaDeCompartilhamento; // 162 compartilhamentos

            var projecaoCompartilhamentoMax = projecaoCompartilhamentos * quantidadeMaxCompartilhamento; // 648 máximo compartilhamento

            var projecaoDeNovasVisualizacoesPorCompartilhamento = projecaoCompartilhamentoMax * taxaDeNovasVisualizacoesPorCompartilhamento; //25920

            var totalProjecoes = projecaoDeNovasVisualizacoesPorCompartilhamento + projecaoAnunciosOriginal; // 25920(viram o anúncio por compartilhamento) + 9000(viram o anúncio original)
            Console.WriteLine(totalProjecoes); // 34920
        }
    }
}
