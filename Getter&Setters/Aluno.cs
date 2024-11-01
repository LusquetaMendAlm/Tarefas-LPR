using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter_Setters
{
    internal class Aluno
    {
        //POR ENCAPSULAMENTO , MEUS ATRIBUTOS DEVEM SER PRIVADOS
        string nome;
        //int turma;
        public int Turma { get; set;}
        double mediaNotas;

        //CONSTRUTOR= MÉTODO ESPECIAL PÚBLICO
        public Aluno(string nome, int turma)
        {
            this.nome = nome;
            this.turma = turma;
        }

        ////GET = MÉTODO ESPECIAL
        //public string getNome()
        //{
        //return nome; 
        //}

        ////SET = MÉTODO ESPECIAL
        //public void setNome(string nome)
        //{
        //    this.nome = nome;
        //}

        //MÉTODO GETSET = MÉTODO ESPECIAL
        public string Nome
        {
            get  { return nome; }
            set  { nome = value; }
        }
    }
}
