using System

namespace exemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; };

         public override void Apresentar(){
            Console.WriteLine($"Ola meu nome e {Nome} e ganho: {Salario}");
        }
    }
}