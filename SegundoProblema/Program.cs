using System;
using System.Globalization;

namespace SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {


            //Simulação loja
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


            //Calculo de area
            /* Retangulo r = new Retangulo();

             Console.WriteLine("Entre a largura e altura do retângulo:");
             r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Área = " + r.Area());
             Console.WriteLine("Perimeto = " + r.Perimetro());
             Console.WriteLine("Diagonal = " + r.Diagonal());*/

            //Media de notas
            /*
             Aluno a = new Aluno();

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            a.Resultado();
            */


            //Converçao de moedas
            /*
            Console.Write("Qual e a contacao do dólar?");
            float Cont = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares voce vai comprar?");
            float Quant = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversordeMoeda.Resultado(Cont, Quant).ToString("F2", CultureInfo.InvariantCulture));
            */

            //Simulação de sistema bancário
            Conta u = new Conta();
            string sim = "s";

            Console.Write("Entre com o numero da conta: ");
            u.Numconta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            u.Nome = Console.ReadLine();
            Console.Write("Havera deposito incial?(s/n): ");
            string resp = Console.ReadLine();

            if (String.Equals(resp, sim))
            {
                Console.Write("Entre com o deposito: ");
                u.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                u.Saldo = 0;
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(u.ToString());

            Console.Write("Entre com o valor do deposito: ");
            double q = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            u.Deposito(q);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(u);

            Console.Write("Entre com o valor do saque (O custo fixo pelo saque e de $5): ");
            q = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            u.Saque(q);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(u);


        }
    }
}
