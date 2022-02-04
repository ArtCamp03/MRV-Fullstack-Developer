namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string Nome = "Luiz";
        private readonly string Sobrenome;


        // public Pessoa()
        // {
        //     Nome = string.Empty;
        //     Sobrenome = string.Empty;
        // }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe Pessoa");
        }

        public void Apresentar(){
            System.Console.WriteLine($"Meu nome e {nome} {sobrenome}");
        }
    }
}