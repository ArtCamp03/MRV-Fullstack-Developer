namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes(){

            return this.mes;
        }

        public void SetMes(int mes){
            if(mes > 0 && mes <= 12){
                this.mes = mes;
                mesValido = true;
            }else{
                mesValido = false;
            }
            
        }

        public int Mes {
            get{
                return this.mes;
            }
            set{
                if(mes > 0 && mes <= 12){
                this.mes = mes;
                mesValido = true;
                }
            } 
            
        }

        public void AprentarMes(){
            if(this.mesValido){
                System.Console.WriteLine(this.mes);
            }else{
                System.Console.WriteLine("mes invalido");
            }
        }

    }
}