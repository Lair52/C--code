using System;
using System.Globalization;

namespace SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Produto p = new Produto();

             Console.WriteLine("Entre com os dados do produto:");
             Console.Write("Nome: ");
             p.Nome = Console.ReadLine();
             Console.Write("Preço(em reais): ");
             p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.Write("Quantidade no estoque: ");
             p.Quantidade = int.Parse(Console.ReadLine());

             Console.WriteLine();
             Console.WriteLine("Dados do produto: " +p);

             Console.WriteLine();
             Console.Write("Digite o número de produtos a ser adicionado: ");
             int qte = int.Parse(Console.ReadLine());
             p.AdicionarProdutos(qte);

             Console.WriteLine();
             Console.WriteLine("Dadso atualizados: " +p);

             Console.WriteLine();
             Console.Write("Digite o número de produtos a ser removido: ");
             qte = int.Parse(Console.ReadLine());
             p.RemoverProdutos(qte);

             Console.WriteLine();
             Console.WriteLine("Dados atualizados: " +p);*/



            /* Retangulo r = new Retangulo();

             Console.WriteLine("Entre a largura e altura do retângulo:");
             r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Área = " + r.Area());
             Console.WriteLine("Perimeto = " + r.Perimetro());
             Console.WriteLine("Diagonal = " + r.Diagonal());*/

            /*Aluno a = new Aluno();

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            a.Resultado();*/


            Console.Write("Qual e a contacao do dólar?");
            float Cont = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares voce vai comprar?");
            float Quant = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversordeMoeda.Resultado(Cont, Quant).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
