namespace exemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        private bool valido;

        public void definirMedidas(double comprimento, double largura){
            if(comprimento > 0 && largura > 0){
            this.comprimento = comprimento;
            this.largura = largura;
            valido = true;
            }else{
                System.Console.WriteLine("Valores invalidos");
            }
        }

        public double obterArea(){
            if(valido){
                return comprimento * largura;
            }else{
                System.Console.WriteLine("escreva valores validos");
                return 0;
            }
        }
    }
}