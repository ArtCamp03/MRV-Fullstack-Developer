using System;

namespace exemploPOO.Models
{
    public class Pessoa
    {
        public string Nome{get; set;}
        public int Idade{get; set;}

        public virtual void Apresentar(){
            Console.WriteLine($"Ola meu nome e {Nome} e tenho {Idade} anos");
        }
    }
}