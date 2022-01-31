using System.IO

namespace exemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho){
            var returnCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in returnCaminho){
                System.Console.WriteLine(retorno);
            }

        }

        public void ListaArquivosDiretorios(string caminho){
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories); 

            foreach (var retorno in retornoArquivos){
                System.Console.WriteLine(retorno);
            }
        }

        public void criarDiretorio(string caminho){
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

    }
}