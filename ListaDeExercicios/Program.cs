using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleExercicio control = new ControleExercicio();//Instanciar
            control.ExecutarMenu();//Chamando o método da classe controle
            Console.ReadLine();//Manter o prompt aberto
        }//fim do static void main
    }//fim da classe
}//fim do projeto
