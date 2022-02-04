using ExemploConstrutores.Models;

namespace ExemploConstrutores{
    class Program{

        static void main (String[] args){

            // Pessoa p1 = new Pessoa("Joao", Julho);
            // p1.Apresentar();

            // Log log = Log.getInstance();

            // log.PropriedadeLog = "Testa instancia";

            // Log log2 = Log.getInstance();
            // System.Console.WriteLine(log2);

            // Aluno p1 = new Aluno("Joao", "Julho", "C comp");
            // p1.Apresentar();

            Data data = new Data();
            data.SetMes(2);

            data.Mes = 12;
            System.Console.WriteLine(data.Mes);
        }
    }
}
