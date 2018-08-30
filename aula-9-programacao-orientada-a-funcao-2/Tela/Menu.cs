using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Mostrar()
        {
            while (true)
            {
                Console.WriteLine("Digite a opção que você deseja : " + "\n" +
                    "Opção 0: Sair do programa" + "\n" +
                    "Opção 1: Ler Arquivos" + "\n" +
                    "Opção 2: Tabuada" + "\n" +
                    "Opção 3: Calcular média\n");

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }

                else if (valor == LER_ARQUIVOS)
                {
                    Arquivo.Ler(1);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }

                else if (valor == TABUADA)

                {
                    Console.WriteLine("Digite o valor que você deseja executar na tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }

                else
                {
                    Media.Aluno();
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }

            }
        }

    }
}
