using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course {
    class Produto {
        private string _nome;
        
        public Double Preco { get; private set; }
        public int Quantidade { get; private set; }
        /*
         Instanciar e pegar valores
         Produto p = new Produto();
         p.pegarValores();
         Produto p = new Produto("TV", 500, 10);

            p.Nome = "TV 4K" ;


            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Preco);
            Console.ReadKey();
        */

    //        int n = int.Parse(Console.ReadLine());
    //        double[] vect = new double[n];
    //        double media = 0;

    //            for (int i = 0; i<n; i++) {
    //                vect[i] = double.Parse(Console.ReadLine());
    //        media += vect[i];
    //            }

           
    //            for (int i = 0; i<vect.Length; i++) {

    //                Console.WriteLine("Valor na posição " + (i + 1) + " : " + vect[i]);
    //            }

    //media = (double) media / n;
    //            Console.WriteLine("Média:" + media.ToString("F2"));
    //            Console.ReadKey();

        public Produto() {
            this.Quantidade = 10;
        }


        public Produto(string nome, double preco) : this() {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = 0;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            this.Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public string GetNome() {
            return _nome;
        }
        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }

        }

        
        public void pegarValores() {
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            double Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco, Quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionados ao estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser removidos do estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.ReadKey();
        }
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return "Nome: " + _nome
                // +"\nPreco: $"+Preco.ToString("F2",CultureInfo.InvariantCulture)
                + "\nPreco: $" + Preco.ToString("F2")
                + "\nQuantidade: " + Quantidade
                + "\n Valor Total:" + ValorTotalEmEstoque().ToString("##,###.00");

        }


    }
}
