namespace exemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void exibirSaldo(){
            System.Console.WriteLine("Seu saldo eh: "+saldo);
        }
    }
}