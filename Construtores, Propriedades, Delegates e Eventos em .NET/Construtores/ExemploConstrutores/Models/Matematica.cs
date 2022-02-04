namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int x { get; set; };
        public int y { get; set; };

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Somar(){
            Calculadora.Somar(x,Y);
            Calculadora.EventoCalculadora += EventoHendler;
        }

        public void EventoHendler(){
            System.Console.WriteLine("Metodo Executado");
        }
    }
}