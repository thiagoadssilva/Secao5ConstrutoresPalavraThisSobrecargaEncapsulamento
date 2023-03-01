using System.Globalization;

namespace ExercicioEncapsulamento01
{
    public class Produto
    {
        private string _nome; // Atributos privados
        public double Preco { get; private set; } // Propriedades autoimplementadas
        public int Quantidade { get; private set; } // Propriedades autoimplementadas

        public Produto(string nome, double preco, int quantidade) // Construtores
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome // Propriedades customizadas
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        /*public double Preco
        {
            get { return _preco; }
        }*/
        /*public int Quantidade
        {
            get { return _quantidade; }
        }*/

        /*public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }*/
        /*public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }*/

        public double ValorTotalEmEstoque() // Outros métodos da classe

        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) // Outros métodos da classe
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) // Outros métodos da classe
        {
            Preco -= quantidade;
        }
        public override string ToString() // Outros métodos da classe
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
