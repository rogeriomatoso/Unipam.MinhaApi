using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unipam.MinhaApi.Dominio;

namespace Unipam.MinhaApi.Dados.Entity.Content
{
    public class MinhaApiDbContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }

        public MinhaApiDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
