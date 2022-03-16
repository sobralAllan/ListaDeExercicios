using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios
{
    class ControleExercicio
    {
        SolucaoExercicios solucao;
        private int opcao;
        public ControleExercicio()
        {
            solucao = new SolucaoExercicios();
        }//fim do construtor

        public void MostrarExercicioUm()
        {
            //A e B sem a troca
            Console.WriteLine("Variaveis sem alteração: \nA: " +
                solucao.ModificarA + "\nB: " + solucao.ModificarB);
            //A e B depois da troca
            Console.WriteLine("\n\nVariaveis após a troca: \n" + solucao.ExercicioUm());
        }//fim do método MostrarExercicioUm

        public void MostrarExercicioDois()
        {
            Console.WriteLine("Informe um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            //Uso o método exercicio 2
            Console.WriteLine("O antecessor do número " + num + " é: " + 
                                         solucao.ExercicioDois(num));
        }//fim do método mostrarexerciciodois

        public void MostrarExercicioTres()
        {
            double bas;
            double altura;
            //Solicitar a base
            do {
                Console.WriteLine("Digite o tamanho da base: ");
                bas = Convert.ToDouble(Console.ReadLine());
                //Validação e aviso ao usuário
                if(bas <= 0)
                {
                    Console.WriteLine("Informe um tamanho maior do que zero!");
                }
            } while (bas <= 0);

            //Solicitar a altura
            do
            {
                Console.WriteLine("Digite a altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
                //Validação e aviso ao usuário
                if (altura <= 0)
                {
                    Console.WriteLine("Informe um tamanho maior do que zero!");
                }
            } while (altura <= 0);

            //Realizar a conta
            Console.WriteLine("A área do retângulo é: " + solucao.ExercicioTres(bas, altura));
        }//fim do método
        public int MostrarOpcoes()
        {
            Console.WriteLine("\n\n Menu \n\n" +
                "0. Sair do Programa\n" +
                "1. Exercicio 01\n" +
                "2. Exercicio 02\n" +
                "3. Exercicio 03\n\n\n " +
                "Escolha uma das opções acima: ");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
            return ModificarOpcao;
        }//fim do menu

        public int ModificarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                opcao = value;
            }
        }//fim do ModificarOpcao
        public void ExecutarMenu()
        {
            do
            {
                MostrarOpcoes(); // Mostrar o menu e coletar a opão
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        MostrarExercicioUm();
                        break;
                    case 2:
                        MostrarExercicioDois();
                        break;
                    case 3:
                        MostrarExercicioTres();
                        break;
                    default:
                        Console.WriteLine("Opção digitada invalida!");
                        break;
                }//fim do Switch
            } while (ModificarOpcao != 0);
        }//fim do método ExecutarMenu
    }//fim da classe
}//fim do projeto
