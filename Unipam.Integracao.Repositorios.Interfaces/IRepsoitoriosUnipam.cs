using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Unipam.Integracao.Repositorios.Interfaces
{
   public interface IRepsoitoriosUnipam <TDominio, TChave>
        where TDominio : class
    {
        List<TDominio> Selecionar(Expression<Func<TDominio, bool>> where = null);

        TDominio SelecionarPorId(TChave id);
        void Inserir(TDominio dominio);
        void Autalizar(TDominio dominio);
        void Excluir(TDominio dominio);
        void ExcluirPorId(TChave id);
    }
}
