﻿using System;
using exemploPOO.Helper;
using exemploPOO.interfaces;
using exemploPOO.Models;

namespace exemploPOO{
    class Program{
        static void Main(string[] args){
            var caminho = "C:\Users\artur\Documents\DIO - Digital Innovation One\MRV-Fullstack-Developer\Programando com Orientação a Objeto com C#\Arquivos"
            var caminhpPàthCombine = Path.Combine(caminho, "teste3", "subTeste3");

            FileHelper helper = new FileHelper();
            // helper.ListaArquivosDiretorios(caminho);
            // helper.ListarDiretorios(caminho);
            System.Console.WriteLine("criando diretorio: "+caminhpPàthCombine);
            helper.criarDiretorio(caminhpPàthCombine);

            // iCalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(45, 10));

            // Computador pc = new Computador();
            // System.Console.WriteLine(pc.ToString());

            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.exibirSaldo();
            
            // Calculadora cl = new Calculadora();
            // System.Console.WriteLine("Resultado da primeria soma: "+ cl.Somar(20, 30));
            // System.Console.WriteLine("Resultado da segunda soma: "+ cl.Somar(20, 30, 10));

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
