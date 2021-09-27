using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SegundoProblema
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;

        }

        public void Resultado()
        {
            if(NotaFinal() >= 60)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                double dif = 60 - NotaFinal();

                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam "+ dif.ToString("F2", CultureInfo.InvariantCulture) +" pontos");
            }

        }
    }
}
