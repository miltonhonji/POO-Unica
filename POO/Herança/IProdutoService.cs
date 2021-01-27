using POO.Classes_e_Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public interface IProdutoService : IBaseService<Produto>
    {
        //Detalhes do Produto
        Produto DetalhesProduto(int id);
        void AdicionarProduto(int id);
    }
}
