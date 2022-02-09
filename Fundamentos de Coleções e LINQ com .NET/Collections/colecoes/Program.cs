namespace colecoes {
    class Program{

        static void Main(string[] args){
            
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] {4,5,6,3,8};
            int[] arrayCopia = new int[10];

            string[] arrayString = op.converterParaString(array);
            
            // int valorProcurado = 1;

            // int indice = op.ObterIndice(array, valorProcurado);

            // System.Console.WriteLine($"Capacidade atual do array {array.Length}");
            // op.RedimensionarArray(array,array.Length * 2)
            // System.Console.WriteLine($"Capacidade atual do array apos redimensionar:  {array.Length}");


            // if(indice > -1){
            //     System.Console.WriteLine("O indice do elemneto {0} e {1}",valorProcurado,indice);
            // }else{
            //     System.Console.WriteLine("Valor nao existente no Array");
            // }


            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0){
            //     System.Console.WriteLine("Encontrei o valor");
            // }else{
            //     System.Console.WriteLine("Nao encontrei ovalor");
            // }

            // bool todosMaiorQue = op.todosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue){
            //     System.Console.WriteLine("todos os valores ao Maior que: {0}",valorProcurado);
            // }else{
            //     System.Console.WriteLine("Existe valores que nao sao maiores que {0}",valorProcurado);
            // }

            // bool existe = op.Existe(array,valorProcurado);

            // if(existe){
            //     System.Console.WriteLine("Encontrei o valor {0}",valorProcurado);
            // }else{
            //     System.Console.WriteLine("Valor {0} nao encontrado ",valorProcurado);
            // }

            // System.Console.WriteLine("Array original");
            // op.ImprimirArrays(array);

            // op.OrdenarBoubleSort(ref array);
            // System.Console.WriteLine("Array ordenado");
            // op.ImprimirArrays(array);

            // op.Ordenar(ref array);

            // System.Console.WriteLine("Array antes da Copia");
            // op.ImprimirArrays(arrayCopia);

            // op.Copiar(ref array,ref arrayCopia);
            // System.Console.WriteLine("Array apos Copia");
            // op.ImprimirArrays(arrayCopia);
            
            
            // int[,] matriz = new int[4,2]{
            //     {8,7},
            //     {2,6},
            //     {3,4},
            //     {4,3}
            // };

            // for(int i = 0; i < matriz.GetLength(0); i++){
            //     for(int j = 0; j < matriz.GetLength(1); i++){
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }

            // matriz[0,1] = 5;

            // int[] arrayInteiros = new int[3];
            // arrayInteiros[0] = 10;
            // arrayInteiros[0] = 20;
            // arrayInteiros[0] = 30;

            // System.Console.WriteLine("Percorrendo array pelo FOR");
            // for(int i = 0; i < arrayInteiros.Length; i++){
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo array pelo FOREACH");
            // foreach(int item in arrayInteiros){
            //     System.Console.WriteLine(item);
            // }

        }
    }
}