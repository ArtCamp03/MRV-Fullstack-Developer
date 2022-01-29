using System;
using exemploPOO.Models;

namespace exemploPOO{
    class Program{
        static void Main(string[] args){
            Pessoa p1 = new Pessoa();

            p1.Nome = "Joao";
            p1.Idade = 27;

            p1.Apresentar();
        }
    }
}
