using System.Globalization;
namespace ExercicioProdutos1
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; } // aqui estamos usando auto-properties
        public int Quantidade { get; private set; } // aqui estamos usando auto-properties

        public string Nome // aqui estamos usando properties
        {
            get { return _nome; }
            set { _nome = value; }
        }

        /*public string getNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }*/

        /*public double getPreco()
        {
            return _preco;
        }*/

        /*public double Preco // aqui estamos usando properties
        {
            get { return _preco; }
        }*/

        /*public int getQuantidade()
        {
            return _quantidade;
        }*/

        /*public int Quantidade // aqui estamos usando properties
        {
            get { return _quantidade; }
        }*/

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}