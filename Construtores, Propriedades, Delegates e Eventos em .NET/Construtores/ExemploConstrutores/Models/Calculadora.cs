namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public static void Somar(int x, int y){
            System.Console.WriteLine($"Soma: {x+y}");
        }

         public static void Subtrair(int x, int y){
            System.Console.WriteLine($"Subtrair: {x-y}");
        }
    }
}