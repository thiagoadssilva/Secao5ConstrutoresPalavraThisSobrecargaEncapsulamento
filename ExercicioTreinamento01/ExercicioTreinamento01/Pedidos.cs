namespace ExercicioTreinamento01
{
    public class Pedidos
    {
        public int Id;
        public int FkProduto;
        public int FkCliente;        
        public string FormaPagamento;
        public string Troco;

        public string mensagem()
        {
            string men = "Id: " + Id 
                + " Id Produto "
                + FkProduto
                + " Id Cliente"
                + FkCliente
                + " Forma de Pagamento"
                + FormaPagamento
                + "Troco: "
                + Troco;
            return men;
        }
    }
}
