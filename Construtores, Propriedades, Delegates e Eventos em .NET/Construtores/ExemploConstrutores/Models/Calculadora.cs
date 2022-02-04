namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y){

            if(EventoCalculadora != null){
                System.Console.WriteLine($"Adiçao: {x+y}");
                EventoCalculadora();

            }else{
                System.Console.WriteLine("Enhum evento realizado");
            }
            
        }

         public static void Subtrair(int x, int y){
            System.Console.WriteLine($"Subtrair: {x-y}");
        }
    }
}