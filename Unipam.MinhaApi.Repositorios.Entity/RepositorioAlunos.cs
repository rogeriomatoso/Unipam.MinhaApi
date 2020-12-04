using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unipam.Integracao.Repositorios.Entity;
using Unipam.MinhaApi.Dados.Entity.Content;

namespace Unipam.MinhaApi.Repositorios.Entity
{
    public class RepositorioAlunos : RepositorioUnipam<RepositorioAlunos, int>
    {
        public RepositorioAlunos(MinhaApiDbContext context)
            : base(context)
        {

        }
    }
}
