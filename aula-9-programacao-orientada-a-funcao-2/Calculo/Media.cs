using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite porfavor, o nome do aluno: \n");
            string nome = Console.ReadLine();

            int qtdNotas = 3;
            int totalNotas = 0;

            List<int> notas = new List<int>();

            for (int x = 1; x <= qtdNotas; x++)
            {
                Console.WriteLine("Digite a nota numero " + x + " :\n");
                int nota = int.Parse(Console.ReadLine());

                totalNotas += nota;
                notas.Add(nota);
            }

            foreach (int nota in notas)
            {
                Console.WriteLine("Exibindo as notas do aluno " + nome + " :\n" + nota);
            }
            int media = totalNotas / qtdNotas;
            Console.WriteLine("Exibindo a média :" + media);

        }

    }
}
