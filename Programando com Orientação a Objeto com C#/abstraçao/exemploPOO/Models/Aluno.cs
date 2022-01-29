using System

namespace exemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; };

         public override void Apresentar(){
            Console.WriteLine($"Ola meu nome e {Nome} tenho {Idade} anos e nota: {Nota}");
        }
    }
}