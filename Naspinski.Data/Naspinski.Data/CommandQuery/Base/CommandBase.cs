using Naspinski.Data.CommandQuery.Interfaces;

namespace Naspinski.Data.CommandQuery.Base
{
    public abstract class CommandBase<TDbContext> where TDbContext : IDbContext<TDbContext>
    {
        protected TDbContext _context;
        protected string _user;
        
        protected CommandBase(TDbContext context, string user)
        {
            _user = user;
            _context = context;
        }
    }
}
