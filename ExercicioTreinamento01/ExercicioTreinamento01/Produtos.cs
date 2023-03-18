namespace ExercicioTreinamento01
{
    public class Produtos
    {
        public int Id;
        public string Nome;
        public double Valor;
        public string Descricao;
        public int Quantidade;

        public string mesagem()
        {
            string men = "Id: " + Id + " Nome: " + Nome
                + " Valor: " + Valor + " Descrição " + Descricao
                + " Quantidade: " + Quantidade;

            return men;
        }

    }
}
