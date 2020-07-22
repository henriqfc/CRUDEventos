using Modelo.Domain.Core.Interfaces.Repositorys;
using Modelo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi.Infra.Data;

namespace WebApi.Infra.Repository.Repositorys
{
    public class RepositoryEvento : RepositoryBase<Evento>, IRepositoryEvento
    {
        private readonly SqlContext _context;
        public RepositoryEvento(SqlContext Context)
            : base(Context)
        {
            _context = Context;
        }

        public override void Update(Evento obj)
        {
            var local = _context.Set<Evento>().Local.FirstOrDefault(entry => entry.Id == obj.Id);

            if (local != null)
            {
                _context.Entry(local).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }

            base.Update(obj);
        }
        public override void Remove(Evento obj)
        {
            var local = _context.Set<Evento>().Local.FirstOrDefault(entry => entry.Id == obj.Id);

            if (local != null)
            {
                _context.Entry(local).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }

            base.Remove(obj);
        }
    }
}
