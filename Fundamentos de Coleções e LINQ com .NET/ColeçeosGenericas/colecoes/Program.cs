namespace colecoes {
    class Program{

        static void Main(string[] args){

            Stack<string> pilhaLivros = new Stack<string>;

            pilhaLivros.Push(".NET");
            pilhaLivros.Push("DDD");
            pilhaLivros.Push("Codigo Limpo");

            System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");
            while(pilhaLivros.Count > 0){
                System.Console.WriteLine($"Proximo livro para a aleitura: {pilhaLivros.Peek()}");
                System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            }

            System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count}");

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