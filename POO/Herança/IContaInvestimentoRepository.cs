using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public interface IContaInvestimentoRepository : IBaseRepository<ContaInvestimento>
    {
        void ResgatarTitulo(ContaInvestimento contaInvestimento);

        List<ContaInvestimento> ListarInvestimento();

        List<ContaInvestimento> ListarInvetimentoPorData(DateTime dataInicio, DateTime dataFim);

        void Investir(ContaInvestimento contaInvestimento);
    }
}
