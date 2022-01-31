using System;
using exemploPOO.Helper;
using exemploPOO.interfaces;
using exemploPOO.Models;

namespace exemploPOO{
    class Program{
        static void Main(string[] args){
            var caminho = "C:\Users\artur\Documents\DIO - Digital Innovation One\MRV-Fullstack-Developer\Programando com Orientação a Objeto com C#\Arquivos"
            var caminhoPathCombine = Path.Combine(caminho, "teste3", "subTeste3");
            var criarArquivo = Path.Combine(caminho, "NovoArquivo.txt")
            var caminhoArquivoTeste = Path.Combine(caminho, "NovoArquivo.txt")
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "NovoArquivoTeste-bkp.txt")
            var novoCaminhoArquivo = Path.Combine(caminho,"teste2", "NovoArquivo2.txt")
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaString2 = new List<string> {"Linha 4", "Linha 5", "Linha 6"};


            FileHelper helper = new FileHelper();
            // helper.ListaArquivosDiretorios(caminho);
            // helper.ListarDiretorios(caminho);
            // System.Console.WriteLine("criando diretorio: "+caminhoPathCombine);
            // helper.criarDiretorio(caminhoPathCombine);
            // helper.apagarDiretorio(caminhoPathCombine, true);
            // helper.criarArquivoTexto(criarArquivo, "Ola a todos");
            // helper.criarArquivoTextoStream(criarArquivo, listaString);
            // helper.adicionarTextoStream(criarArquivo, listaString2);
            // helper.lerArquivoStream(criarArquivo);
            // helper.moverArquivo(criarArquivo, novoCaminhoArquivo, false);
            helper.copiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.deletarArquivo(caminhoArquivoTesteCopia);

            // iCalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(45, 10));

            // Computador pc = new Computador();
            // System.Console.WriteLine(pc.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.exibirSaldo();
            
            // Calculadora cl = new Calculadora();
            // System.Console.WriteLine("Resultado da primeria soma: "+ cl.Somar(20, 30));
            // System.Console.WriteLine("Resultado da segunda soma: "+ cl.Somar(20, 30, 10));

            // Aluno al = new Aluno();
            // al.Nome = "Jose";
            // al.Idade = 30;
            // al.Nota = 10;
            // al.Apresentar();

            // Professor prof = new Professor();
            // prof.Nome = "Mario";
            // prof.Salario = 2000.00
            // prof.Apresentar();

            // Retangulo r = new Retangulo();
            // r.definirMedidas(30, 30);
            // System.Console.WriteLine($"Area: {r.obterArea()}");
            
            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Joao";
            // p1.Idade = 27;
            // p1.Apresentar();
        }
    }
}
