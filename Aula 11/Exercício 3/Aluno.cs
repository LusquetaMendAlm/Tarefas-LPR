using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Aluno
    {
        internal int matricula;
        internal string nome;
        internal int prova1;
        internal int prova2;
        internal int trabalho;
        internal double mediaNota;
        internal double falta;

        internal double media()
        {
            mediaNota = (((2.5 * (prova1 + prova2)) + (2 * trabalho)) / 2);

            return mediaNota;
        }

        internal double final()
        {
            if (mediaNota < 60)
            {

                return 0;
            }
            else
            {
                falta = 100 - mediaNota;

                return falta;
            }
        }
    }
}
