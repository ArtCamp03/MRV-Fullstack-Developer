namespace colecoes {
    class Program{

        static void Main(string[] args){

            OperacaoLista opLista = new OperacaoLista();
            string[] estadoArrays = new string[2] {"GO","RS"};

            List<string> estados = new List<string> {"BA", "PA"};

            // estados.Add("MT");
            // estados.Add("GO");
            // estados.Add("MS");
            // estados.Add("SP");

            System.Console.WriteLine($"quantidades de elementos na lista: {estados.Count}");

            opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("MG");

            estados.AddRange(estadoArrays);

            estados.Insert(1, "RJ");

            opLista.ImprimirListaString(estados);

            // foreach (var item in estados){
            //     System.Console.WriteLine(item);
            // }

            // for(int i = 0; i < estados.Count; i++){
            //     System.Console.WriteLine($"Indice: {i} valor: {estados[i]}");
            // }

        }
    }
}