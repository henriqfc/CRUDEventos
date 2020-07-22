using Modelo.Domain.Core.Interfaces.Repositorys;
using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Infra.Data;

namespace WebApi.Infra.Repository.Repositorys
{
    public class RepositorySala : RepositoryBase<Sala>, IRepositorySala
    {
        private readonly SqlContext _context;
        public RepositorySala(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}
