using ProjectEntityFramework.Interfaces;
using RepositoryT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntityFramework
{
    public class DefaultDataContextFactory<TContext> : IDataContextFactory<TContext> 
                        where TContext : class, IDbContext, IDisposable, new()
    {
        private TContext _dataContext;

        public TContext GetContext()
        {
            return _dataContext ?? (_dataContext = new TContext());
        }

        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}
