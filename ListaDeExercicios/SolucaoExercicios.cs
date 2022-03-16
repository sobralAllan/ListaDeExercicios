using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class SolucaoExercicios
    {
        private int A, B, aux;
        public SolucaoExercicios()
        {
            A = 10;
            B = 20;
            aux = 0;
        }//fim do construtor

        //Criar os métodos gets e sets
        public int ModificarA
        {
            get
            {
                return A;
            }
            set
            {
                A = value;
            }
        }//fim do método ModificarA

        public int ModificarB
        {
            get
            {
                return B;
            }
            set
            {
                B = value;
            }
        }//fim do método modificarB

        public int ModificarAux
        {
            get
            {
                return aux;
            }
            set
            {
                aux = value;
            }
        }//fim do método ModificarAux

        public string ExercicioUm()
        {
            ModificarAux = ModificarA;
            ModificarA   = ModificarB;
            ModificarB   = ModificarAux;
            return "A: " + ModificarA + "\nB: " + ModificarB;
        }//fim do ExercicioUm

        public int ExercicioDois(int num)
        {
            return num - 1;
        }//fim do exercício do Antecessor

        public double ExercicioTres(double bas, double altura)
        {
            return bas* altura;
        }//fim do ExercicioTres



    }//fim da classe
}//fim do projeto
