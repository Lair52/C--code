using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProblema
{
    class ConversordeMoeda
    {

        public static float Iof = 1.06f;

        public static float  Resultado(float Contdolar, float Quantdolar)
        {
            return  Quantdolar * Contdolar * Iof;
        }

    }
}
