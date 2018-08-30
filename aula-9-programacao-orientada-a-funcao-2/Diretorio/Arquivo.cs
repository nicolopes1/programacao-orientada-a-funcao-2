using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        public static void Ler(int numeroArq)
        {
            string arquivoComCaminho = caminhoArquivo() + "arq" + numeroArq + ".txt";
            Console.WriteLine("\nLendo arquivo " + arquivoComCaminho + "\n");

            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoComCaminho2 = caminhoArquivo() + "arq" + ( numeroArq + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.Ler(numeroArq + 1);
            }

        }
    }
}
