using ExemploConstrutores.Models;

namespace ExemploConstrutores{
    class Program{

        public delegate void Operacao(int a, int );

        
        static void main (String[] args){

            Matematica m = new Matematica(10, 20);
            m.Somar()
            
            // Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op.Invoke(10,5);
            // adicona mais um metodo a op sem perder referencia do metodo soma
            // p += Calculadora.Subtrair;
            // op(20,47);

            // const double pi = 3.14
            // System.Console.WriteLine(pi);

            // Pessoa p1 = new Pessoa("Joao", Julho);
            // p1.Apresentar();

            // Log log = Log.getInstance();

            // log.PropriedadeLog = "Testa instancia";

            // Log log2 = Log.getInstance();
            // System.Console.WriteLine(log2);

            // Aluno p1 = new Aluno("Joao", "Julho", "C comp");
            // p1.Apresentar();

            // Data data = new Data();
            // data.SetMes(2);

            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);
        }
    }
}
