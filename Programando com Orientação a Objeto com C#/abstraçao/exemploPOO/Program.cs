using System;
using exemploPOO.Models;

namespace exemploPOO{
    class Program{
        static void Main(string[] args){

            Retangulo r = new Retangulo();


            r.definirMedidas(30, 30);

            System.Console.WriteLine($"Area: {r.obterArea()}");
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Joao";
            // p1.Idade = 27;

            // p1.Apresentar();
        }
    }
}
