using System

namespace exemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; };

        // metodo selado
         public sealed override void Apresentar(){
            Console.WriteLine($"Ola meu nome e {Nome} e ganho: {Salario}");
        }
    }
}