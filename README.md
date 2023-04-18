# Construtores, Palavra This, Sobrecarga e Encapsulamento

### Esses são conceitos fundamentais em programação orientada a objetos, que visam promover a organização e modularidade do código, bem como aumentar a legibilidade, manutenibilidade e escalabilidade.

<hr>

## Construtores

### Construtores são métodos especiais que têm como objetivo criar e inicializar um objeto de uma classe em específico. Eles podem receber parâmetros para configurar o objeto, e são chamados automaticamente quando o objeto é instanciado.

## Um exemplo de construtor em C#:

    public class Pessoa {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }
    }

<hr>

## Palavra This

### A palavra-chave this é usada em programação orientada a objetos para fazer referência ao objeto atual. É especialmente útil para diferenciar entre variáveis locais e variáveis de instância com o mesmo nome.

## Por exemplo, em C#:

    public class Pessoa {
        private string nome;

        public Pessoa(string nome) {
            this.nome = nome; // 'this' é usado para referenciar o atributo 'nome' da classe
        }
    }

<hr>

## Sobrecarga

### A sobrecarga é um recurso que permite definir diversos métodos com o mesmo nome, mas com parâmetros diferentes. Isso é especialmente útil para aumentar a flexibilidade do código e torná-lo mais intuitivo.

## Por exemplo, em C#:

    public class Calculadora {
        public int Somar(int a, int b) {
            return a + b;
        }

        public double Somar(double a, double b) {
            return a + b;
        }
    }

<hr>

## Encapsulamento

### O encapsulamento é um dos pilares da programação orientada a objetos, que busca proteger os dados da classe de acessos externos não autorizados, ao mesmo tempo que fornece métodos de acesso controlado aos dados.

### Em outras palavras, o encapsulamento busca garantir que o estado interno de um objeto só possa ser modificado através de métodos específicos, reduzindo assim o acoplamento entre as diferentes partes do código.

## Por exemplo, em C#:

    public class Pessoa {
        private string nome;

        public string GetNome() {
            return nome;
        }

        public void SetNome(string nome) {
            this.nome = nome;
        }
    }

<hr>

## Esses conceitos são fundamentais para o desenvolvimento de aplicações orientadas a objetos de alta qualidade e podem ser aplicados em diversas linguagens de programação.


