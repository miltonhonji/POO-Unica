using POO.Classes_e_Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public interface IPedidoService : IBaseService<Pedido>
    {
        void FecharPedido(int id);
        Pedido DetalhesPedido(int id);
        void Salvar(Pedido pedido);
    }
}
