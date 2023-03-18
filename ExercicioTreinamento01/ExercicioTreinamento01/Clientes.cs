namespace ExercicioTreinamento01
{
    public class Clientes
    {
        public int Id;
        public string Nome;
        public string Telefone;
        public string Rua;
        public string Bairro;
        public string PontoReferencia;

        public string mesagem() {
            string men = "Id: " + Id + " Telefone: " + Telefone
                + " Rua: " + Rua + " Bairro " + Bairro 
                + " Ponto de referência: " + PontoReferencia;

            return men;
        }
    }
}
