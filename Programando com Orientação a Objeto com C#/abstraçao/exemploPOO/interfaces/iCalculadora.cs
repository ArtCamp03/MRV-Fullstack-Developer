namespace exemploPOO.interfaces
{
    public interface iCalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);

        // implementaçao do metodo padrao
        int Dividir(int num1, int num2){
            return num1 / num2;
        }

    }
}