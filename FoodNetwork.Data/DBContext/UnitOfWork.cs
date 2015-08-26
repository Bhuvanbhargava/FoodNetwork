using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNetwork.Data.DBContext
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IFoodNetworkDatabaseContext _context;
        private bool disposed = false;

        public UnitOfWork(IConnectionStringBuilder connectionBuilder)
        {
            var factory = new FoodNetworkDataBaseConnectionFactory(connectionBuilder);
            _context = factory.GetDbContext();
        }

        public int SaveChanges()
        {
            if (_context != null)
            {
                return _context.SaveChanges();
            }
            return -1;
        }

        public IFoodNetworkDatabaseContext Context
        {
            get { return _context; }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

/*
 * public interface IUnitOfWork
{
    void SaveChanges();
    DbContext Context { get; }
}

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DbContext _context;
    private bool disposed = false;

    public UnitOfWork(IDbContextFactory contextFactory)
    {
        _context = contextFactory.GetContext();
    }

    public void SaveChanges()
    {
        if (_context != null)
        {
            _context.SaveChanges();
        }
    }

    public DbContext Context
    {
        get { return _context; }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
 */