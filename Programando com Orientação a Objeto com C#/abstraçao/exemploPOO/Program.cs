using System;
using exemploPOO.Models;

namespace exemploPOO{
    class Program{
        static void Main(string[] args){

            Calculadora cl = new Calculadora();
            System.Console.WriteLine("Resultado da primeria soma: "+ cl.Somar(20, 30));
            System.Console.WriteLine("Resultado da segunda soma: "+ cl.Somar(20, 30, 10));

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
