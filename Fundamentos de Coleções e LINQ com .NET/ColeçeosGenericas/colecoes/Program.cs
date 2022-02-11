using System.Linq;
using System.Collections.Generic;
using colecoes.Helper;  
using colecoes.Models;

namespace colecoes {
    class Program{

        static void Main(string[] args){

            // utilizando Linq
            int[] arrayNumeros = new int[7] {5,7,8,9,6,5,8};

            // adiconando valores max , min e medios
            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            // sum soma tds valores e retorna o resultado
            var soma = arrayNumeros.Sum();
            // elementos distintos
            var arrayUnico = arrayNumeros.Distinct().ToArray() ;

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Medio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");


            // utilizando busca com Query s
            // var numerosParesQuery =
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodo = arrayNumeros.Where(x -> x % 2 == 0 ).orderby(x -> x).ToList();

            // System.Console.WriteLine("Numeros pares query: "+ string.Join(", ",numerosParesMetodo));
            // System.Console.WriteLine("Numeros pares metodos: "+ string.Join(", ",numerosParesMetodo));

            
            // Stack<string> pilhaLivros = new Stack<string>;

            // Dicionario
            // Dictionary<string,string> estados = new Dictionary<string, string>;
            // estados.Add("SP", "Sao Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("MT", "Mato Grosso")
            
             
            // foreach (KeyValueParse<string,string> item in estados){
            //     System.Console.WriteLine($"Chave: {item.Key} valor: {item.Value}");
            // }

            // string valorProcurado = "BA";
            // valor inexistente
            // var teste = estados["SC"]
            // acessando o dicionario de maneira segura
            // if(estados.TryGetValue(valorProcurado, out string estadoEncontrado)){
            //     System.Console.WriteLine(estadoEncontrado);
            // }else{
            //     System.Console.WriteLine($"Chave: {valorProcurado} nao existe");
            // }

            // System.Console.WriteLine(Original$"Removendo o valor: {valorProcurado});
            // estados.Remove(valorProcurado);

            // foreach (KeyValueParse<string,string> item in estados){
            //     System.Console.WriteLine($"Chave: {item.Key} valor: {item.Value}");
            // }

            // System.Console.WriteLine("valor Original: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // atualiza valor da chave BA
            // estados[valorProcurado] = "BA - teste atualziacao";

            // System.Console.WriteLine("valor atualizado: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Codigo Limpo");

            // System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
            // while(pilhaLivros.Count > 0){
            //     System.Console.WriteLine($"Proximo livro para a aleitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

            // Queue<string> fila = new Queue<string>;

            // fila.Enqueue("Joao");
            // fila.Enqueue("Marcos");
            // fila.Enqueue("Lucas");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count()}");

            // while(fila.Count > 0){
            //     System.Console.WriteLine($"Vex de: {fila.Peek()}");
            //     System.Console.WriteLine($" {fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count()}");

            // OperacaoLista opLista = new OperacaoLista();
            // string[] estadoArrays = new string[2] {"GO","RS"};

            // List<string> estados = new List<string> {"BA", "PA"};

            // estados.Add("MT");
            // estados.Add("GO");
            // estados.Add("MS");
            // estados.Add("SP");

            // System.Console.WriteLine($"quantidades de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");

            // estados.AddRange(estadoArrays);

            // estados.Insert(1, "RJ");

            // opLista.ImprimirListaString(estados);

            // foreach (var item in estados){
            //     System.Console.WriteLine(item);
            // }

            // for(int i = 0; i < estados.Count; i++){
            //     System.Console.WriteLine($"Indice: {i} valor: {estados[i]}");
            // }

        }
    }
}