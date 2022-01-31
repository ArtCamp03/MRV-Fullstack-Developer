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

        public void apagarDiretorio(string caminho, bool apagarArquivos){
            Directory.Delete(caminho, apagarArquivos);
            
        }

        public void criarArquivoTexto(string caminho, string conteudo){
            if(!File.Exists(caminho)){
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void criarArquivoTextoStream(string caminho, List<string> conteudo){
            
            using(var stream = File.CreateText(caminho)){
                foreach (var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }
        }

        public void adicionarTexto(string caminho, string conteudo){
            File.AppendAllText(caminho, conteudo);
        }

         public void adicionarTextoStream(string caminho, List<string> conteudo){
            
            using(var stream = File.AppendText(caminho)){
                foreach (var linha in conteudo){
                    stream.WriteLine(linha);
                }
            }
        }

        public void lerArquivo(string caminho){
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void lerArquivoStream(string caminho){
            string linha = string.Empty;
            
            using(var stream = File.OpenText(caminho)){
                while ((linha = stream.ReadLine()) != null){
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void moverArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Move(caminho, novoCaminho);
        }

        public void copiarArquivo(string caminho, string novoCaminho, bool sobrescrever){
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void deletarArquivo(string caminho){
            File.Delete(caminho);
        }
    }
}