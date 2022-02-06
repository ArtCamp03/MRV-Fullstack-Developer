namespace colecoes {
    class Program{

        static void Main(string[] args){

            int[,] matriz = new int[4,2]{
                {8,7},
                {2,6},
                {3,4},
                {4,3}
            };

            for(int i = 0; i < matriz.GetLength(0); i++){
                for(int j = 0; j < matriz.GetLength(1); i++){
                    System.Console.WriteLine(matriz[i,j]);
                }
            }

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