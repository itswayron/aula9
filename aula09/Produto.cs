using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09
{
    public struct Produto(String nome, double preco, int quantidade)
    {
        public string Nome { get; } = nome;
        public double Preco { get; } = preco;
        public int Quantidade { get; } = quantidade;
        public double getValorEstoque() => preco * quantidade;

    }
}
