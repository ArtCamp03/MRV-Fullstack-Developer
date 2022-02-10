namespace colecoes.Helper
{
    public class OperacaoLista
    {
        public void ImprimirListaString(List<string> lista){
            for(int i = 0; i < lista.Count; i++){
                System.Console.WriteLine($"Indice: {i} valor: {lista[i]}");
            }
        }
    }
}