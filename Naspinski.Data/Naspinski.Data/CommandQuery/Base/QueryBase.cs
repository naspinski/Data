using Naspinski.Data.CommandQuery.Interfaces;
using System;

namespace Naspinski.Data.CommandQuery.Base
{
    public abstract class QueryBase<TDbContext> : IDisposable where TDbContext : IDbContext<TDbContext>, IDisposable
    {
        protected TDbContext _context;

        protected QueryBase()
        { }

        protected QueryBase(TDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
