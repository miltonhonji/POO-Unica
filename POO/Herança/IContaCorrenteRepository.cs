using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public interface IContaCorrenteRepository : IBaseRepository<ContaCorrente>
    {
        void Pix(string chave, double valor);

        List<ContaCorrente> ObterExtratoConta();
    }
}
