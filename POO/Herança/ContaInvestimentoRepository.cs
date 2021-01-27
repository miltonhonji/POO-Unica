using System;
using System.Collections.Generic;

namespace POO.Herança
{
    //Herdando IContaCorrenteRepository
    public class ContaInvestimentoRepository : IContaCorrenteRepository
    {
        void IBaseRepository<ContaCorrente>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        List<ContaCorrente> IContaCorrenteRepository.ObterExtratoConta()
        {
            throw new NotImplementedException();
        }

        void IContaCorrenteRepository.Pix(string chave, double valor)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<ContaCorrente>.Save(ContaCorrente entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<ContaCorrente>.Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
